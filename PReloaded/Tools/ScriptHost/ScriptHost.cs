using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CSScriptLibrary;
using ScriptHost.Forms;

// A rudimentary scripthost using C# Script Engine with an extremely simplistic preprocessor.
// Used as a script engine in some other tools in this repo.

// Evaluation of code is also possible via ::DoEval and ::DoEvalExpression

namespace ScriptHost
{
    public abstract class ScriptGlobal
    {
        protected Random Rand;
        protected ScriptHost Host;

        public dynamic DoEval(string Text, bool Preprocess, out string Error)
        {
            if(Preprocess)
                Host.Preprocess(ref Text);

            string imports = Host.GetImports();

            try
            {
                System.Reflection.Assembly assembly = CSScript.LoadCode(imports + @"
                        public class Eval
                        { static public dynamic Expr() { return " + Text + " } }");
                var Expr = new AsmHelper(assembly).GetStaticMethod();
                dynamic ret = Expr();
                Error = "";
                return ret;
            }
            catch (Exception ex)
            {
                Error = Host.ProcessError(ex.Message);
                return null;
            }
        }

        public void Init(ScriptHost Host)
        {
            this.Host = Host;
            Rand = new Random();
        }
    }

    public interface IScript 
    {
        bool init(Form Main);
        uint update();

        bool mouse_click(Form EventForm, MouseEventArgs Args);
        bool mouse_doubleclick(Form EventForm, MouseEventArgs Args);
        bool mouse_up(Form EventForm, MouseEventArgs Args);
        bool key_down(Form EventForm, KeyEventArgs Args);
        bool key_press(Form EventForm, KeyPressEventArgs Args);
        bool key_up(Form EventForm, KeyEventArgs Args);

        string get_author();
        string get_name();
        string get_description();
        string get_version();
    }

    public class ScriptExtension
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string FileName { get; set; }
        public string ClassName { get; set; }
        public int ApiVersion { get; set; }
        public List<String> Code { get; set; }
        public dynamic Handle { get; set; }
        public long UpdateTimeCount { get; set; }
        public uint UpdateTime { get; set; }
    }

    [Serializable]
    public abstract class ScriptHost
    {
        Form fMain;
        string ScriptPath;
        protected List<ScriptExtension> Extensions = new List<ScriptExtension>(); // [0]==MainScript
        List<String> Scripts = new List<string>();
        protected Dictionary<String, String> EventStubs = new Dictionary<string, string>();

        string InteractiveBuffer = "";

        RichTextBox csl;

        public void RegisterConsole(RichTextBox ncsl)
        {
            csl = ncsl;
        }

        public void WriteLine(string Text)
        {
            csl.AppendText(Text + "\n");
        }

        public abstract void Log(string Text);
        public abstract string GetImports();
        public abstract void Preprocess(ref string text);
        public abstract void InitEventStubs();

        public void InstallExtensionsMenu(MenuStrip Menu, int Index)
        {
            ToolStripMenuItem ts = new ToolStripMenuItem();
            ts.Text = "Extensions";

            ToolStripMenuItem tsLoaded = new ToolStripMenuItem();
            ToolStripMenuItem tsConfig = new ToolStripMenuItem();

            tsLoaded.Text = "Loaded Extensions";
            tsLoaded.Click += new EventHandler(tsLoaded_Click);
            tsConfig.Text = "Configure";
            tsConfig.Click += new EventHandler(tsConfig_Click);

            ts.DropDownItems.Add(tsLoaded);
            ts.DropDownItems.Add(tsConfig);

            Menu.Items.Insert(Index, ts);
        }

        void tsConfig_Click(object sender, EventArgs e)
        {
            frmExtensionList frmExtensionLoad = new frmExtensionList(ScriptPath);
            frmExtensionLoad.ShowDialog();
        }

        void tsLoaded_Click(object sender, EventArgs e)
        {
            frmScriptsLoaded frmLoaded = new frmScriptsLoaded(this);
            frmLoaded.ShowDialog();
        }

        public List<ScriptExtension> GetLoadedExtensions() 
        {
            return Extensions;
        }

        public void ClearEvalBuffer()
        {
            InteractiveBuffer = "";
        }

        protected bool Alias(ref string text, string org, string alias)
        {
            bool Found = text.Contains(org);
            Regex reg = new Regex("(^|\\s+)" + org); // Because we want to make sure not 
                                                    // to replace "SaveLocations" while we search for "Locations".
            if (reg.Match(text).Success)
                text = reg.Replace(text, alias);
            return Found;
        }

        protected bool Alias(ref string text, string[] org, string alias)
        {
            bool Found=false;
            foreach (string o in org)
            {
                text = Regex.Replace(text, "(^|\\s+)" + o, alias, RegexOptions.IgnoreCase);
                if (text.Contains(o))
                    Found = true;
            }
            return Found;
        }

        public dynamic Cast(dynamic obj, Type castTo)
        {
            return Convert.ChangeType(obj, castTo);
        }

        private string GetTextFromTextToChar(string str, string text, char c)
        {
            int index = str.IndexOf(text) + text.Length;
            int findex = str.IndexOf(c, index, str.Length - index);
            string ret = str.Substring(index, findex - index);
            return ret;
        }

        protected void PreprocessAccessor(ref string Text, string Type, string Property, bool Contains)
        {
            if (Text.Contains(Type))
            {
                char endChar = '"';
                if(!Contains)
                    endChar='\'';

                string Value = GetTextFromTextToChar(Text, Type, endChar);
                int startIndex = Text.IndexOf(Type) - 2 + Type.Length;
                int endIndex = Text.IndexOf(endChar, startIndex + 2);
                Text = Text.Remove(startIndex, endIndex - (startIndex - 1));
                if(Contains)
                    Text = Text.Insert(startIndex, ".FindAll(x => x." + Property + ".Contains(\"" + Value + "\"))");
                else
                    Text = Text.Insert(startIndex, ".Find(x => x."+Property+"==\"" + Value + "\")");
            }
        }



        private void PreprocessEvents(ref string Code)
        {
            List<String> ToInject = new List<string>();
            foreach (String Declaration in EventStubs.Keys)
            {
                if (!Code.Contains(Declaration))
                {
                    Log("Declaration of func not found, injecting " + Declaration);
                    ToInject.Add(EventStubs[Declaration]);
                }
            }

            foreach (String Inj in ToInject)
                Code = Code.Insert(Code.LastIndexOf('}')-1, Inj);
        }

        public string ProcessError(string error)
        {
            return error.Remove(0, error.IndexOf(')') + 3);
        }

        public bool DoEvalExpression(string Text, bool DoPreprocess, out string Error, out dynamic Output)
        {
            if (DoPreprocess)
                Preprocess(ref Text);

            Output = new List<string>();

            try
            {
                bool Save = false;
                string path = "";
                if (Text.Contains(">>"))
                {
                    Save = true;
                    int idx = Text.LastIndexOf(">>") + 2;
                    path = Text.Substring(idx, Text.Length - idx);
                    Text = Text.Remove(idx - 3, Text.Length - (idx - 3));
                }

                System.Reflection.Assembly assembly = CSScript.LoadCode(GetImports() + @"
                        public class Eval
                        { static public dynamic Expr() { " + InteractiveBuffer + " return " + Text + "; } }");
                var Expr = new AsmHelper(assembly).GetStaticMethod();
                dynamic ret = Expr();
                Output = ret;

                if (Save)
                    File.WriteAllLines(path, Output.ToArray());

                Error = "";
                return true;
            }
            catch (Exception)
            {
                try
                {
                    System.Reflection.Assembly assembly = CSScript.LoadCode(GetImports() + @"
                        public class Eval
                        { static public dynamic Expr() { " + InteractiveBuffer + " return " + Text + "; } }");
                    var Expr = new AsmHelper(assembly).GetStaticMethod();
                    dynamic ret = Expr();
                }
                catch (Exception ex2)
                {
                    Error = ProcessError(ex2.Message);
                    return false;
                }
            }
            Error = "Invalid error.";
            return false;
        }

        public bool DoEval(string Text, bool DoPreprocess, out string Error, out dynamic EvalOutput)
        {
            // Maybe an expression?
            bool Expression=false;
            bool Success = false;
            Error = "";
            EvalOutput = null;

            if(!Text.Contains(";"))
            {
                Expression = true;
                dynamic Output;
                if (DoEvalExpression(Text, DoPreprocess, out Error, out Output))
                {
                    EvalOutput = Output;
                    Success = true;
                }
            }

            if (DoPreprocess)
                Preprocess(ref Text);

            if (Expression)
                return Success;

            try
            {
                System.Reflection.Assembly assembly = CSScript.LoadCode(GetImports() + @"
                    public class Eval
                    { static public void Code() { " + InteractiveBuffer + Text + " } }");
                var Code = new AsmHelper(assembly).GetStaticMethod();
                Code();
                InteractiveBuffer += Text;
            }
            catch (Exception ex)
            {
                Error = ProcessError(ex.Message);
                return false;
            }
            Error = "";
            return true;
        }

        private void ParseScriptsList(string Path) // Path == Config.PathEditorScript
        {
            if (!Directory.Exists(Path))
            {
                MessageBox.Show("Unable to find scripts directory " + Path, "ScriptHost");
                return;
            }
            if (!File.Exists(Path + "scripts.lst"))
            {
                MessageBox.Show("Unable to find scripts list", "ScriptHost");
                return;
            }
            List<String> lines = new List<string>(File.ReadAllLines(Path+"scripts.lst"));
            foreach (String line in lines)
            {
                if (line.Length == 0 || (line[0] == '/' && line[1] == '/'))
                    continue;
                if (line[0] != '@')
                    continue;
                Scripts.Add(Path+line.Remove(0, 1));
            }
        }

        // Find classname
        private void PreParseScripts()
        {
            foreach (String script in Scripts)
            {
                if (!File.Exists(script))
                {
                    continue;
                }

                List<String> lines = new List<string>(File.ReadAllLines(script));

                ScriptExtension Ext = new ScriptExtension();
                Ext.FileName = script;

                foreach (String line in lines)
                {
                    if (line.Contains("public class"))
                    {
                        string[] param = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        for (uint i = 0; i < param.Length; i++)
                        {
                            if (param[i] == "public" && param.Length >= i + 4 && param[i + 1] == "class" && param[i + 4] == "IScript")
                            {
                                Ext.ClassName = param[i + 2];
                                Ext.Code = lines;
                                Ext.UpdateTime = 0;
                                Extensions.Add(Ext);
                            }
                        }
                    }
                }
            }
        }

        public bool Reload()
        {
            frmScriptLoad frmLoad = new frmScriptLoad(ScriptPath);
            TextBox txt = frmLoad.GetTextBox();

            ParseScriptsList(ScriptPath);
            PreParseScripts();

            bool Success = false;

            DialogResult Ret = DialogResult.Cancel;
            bool RetryDialog = false;
            do
            {
                Ret = DialogResult.Cancel;
                try
                {
                    RetryDialog = false;
                    CSScriptLibrary.CSScript.ShareHostRefAssemblies = true;

                    bool Error=false;

                    foreach (String path in Scripts)
                    {
                        if (Path.GetFileName(path) == "main.cs")
                            continue;
                        
                        txt.Text += "Compiling " + Path.GetFileName(path)+"... ";
                        try
                        {
                            ScriptExtension Ext = Extensions.Find(i => i.FileName == path);
                            if (Ext != null)
                            {
                                Log("Loading extension " + Ext.FileName + "...");
                                string Code = File.ReadAllText(Ext.FileName);
                                Log("Preprocessing " + Ext.FileName + "...");
                                Preprocess(ref Code);
                                PreprocessEvents(ref Code);
                                Log("Compiling " + Ext.FileName + "...");
                                Ext.Handle = CSScript.LoadCode(Code).CreateObject(Ext.ClassName);
                            }
                            else
                                CSScript.Load(path);
                            
                            txt.Text += "Ok" + Environment.NewLine;
                        }
                        catch (Exception e)
                        {
                            txt.Text += "Error!" + Environment.NewLine;
                            txt.Text += e.Message;
                            Error = true;
                        }
                    }

                    if (!Error)
                    {
                        // init all loaded extensions
                        init(fMain);

                        get_author();
                        get_name();
                        get_description();
                        get_version();

                        foreach (ScriptExtension Ext in Extensions)
                            update(Ext);

                        Success = true;
                    }
                    if(Error)
                    {
                        frmLoad.ShowDialog();
                        if (frmLoad.IsRetry())
                            RetryDialog = true;
                        else
                            return false;
                    }
                }
                catch (Exception e)
                {
                    Ret = MessageBox.Show("Exception occured when loading scripts: " + Environment.NewLine +
                        e.Message, "ScriptEngine", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Log(e.Message);
                }
            } while (Ret == DialogResult.Retry || RetryDialog);
            return Success;
        }

        public bool Init(Form Main, string ScriptPath)
        {
            EventStubs.Add("public bool mouse_click", "public bool mouse_click(Form EventForm, MouseEventArgs e) { return false; }");
            EventStubs.Add("public bool mouse_up", "public bool mouse_up(Form EventForm, MouseEventArgs e) { return false; }");
            EventStubs.Add("public bool mouse_doubleclick", "public bool mouse_doubleclick(Form EventForm, MouseEventArgs e) { return false; }");
            EventStubs.Add("public bool key_up", "public bool key_up(Form EventForm, KeyEventArgs e) { return false; }");
            EventStubs.Add("public bool key_press", "public bool key_press(Form EventForm, KeyPressEventArgs e) { return false; }");
            EventStubs.Add("public bool key_down", "public bool key_down(Form EventForm, KeyEventArgs e) { return false; }");
            EventStubs.Add("public void resources_loaded", "public void resources_loaded() { }");
            EventStubs.Add("public void main_form_loaded", "public void main_form_loaded() { }");
            EventStubs.Add("public uint update", "public uint update() { return 0; }");
            EventStubs.Add("public bool shell_input", "public bool shell_input(ref string text) { return false; }");
            InitEventStubs(); // defined in derived class

            this.ScriptPath = ScriptPath;
            fMain = Main;
            return Reload();
        }

        /////////// Event handlers ///////////////////////////////////////////
        public void RegisterFormEvents(Control frm)
        {
            //frm.KeyUp += KeyUp;
            foreach (Control ctrl in frm.Controls)
            {
                ctrl.MouseClick += MouseClick;
                ctrl.MouseDoubleClick += MouseDoubleClick;
                ctrl.MouseUp += MouseUp;
                ctrl.KeyPress += KeyPress;
                ctrl.KeyUp += KeyUp;
                ctrl.KeyDown += KeyDown;
                if (ctrl.Controls.Count > 0)
                    RegisterFormEvents(ctrl);
            }
        }

        private Form GetForm(Control Ctrl)
        {
            return Ctrl.FindForm();
        }


        // Base callbacks
        public void init(Form Main)                             { foreach (ScriptExtension Ext in Extensions) Ext.Handle.init(Main); }
        public void update(ScriptExtension Ext)                 { Ext.UpdateTime = Ext.Handle.update(); }

        public void get_author()                                { foreach (ScriptExtension Ext in Extensions) Ext.Author = Ext.Handle.get_author(); }
        public void get_name()                                  { foreach (ScriptExtension Ext in Extensions) Ext.Name    = Ext.Handle.get_name(); }
        public void get_description()                           { foreach (ScriptExtension Ext in Extensions) Ext.Description = Ext.Handle.get_description(); }
        public void get_version()                               { foreach (ScriptExtension Ext in Extensions) Ext.Version = Ext.Handle.get_version(); }

        public bool mouse_click(Form EventForm, MouseEventArgs Args)        { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.mouse_click(EventForm, Args)) return true; return false; }
        public bool mouse_doubleclick(Form EventForm, MouseEventArgs Args) { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.mouse_doubleclick(EventForm, Args)) return true; return false; }
        public bool mouse_up(Form EventForm, MouseEventArgs Args)           { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.mouse_up(EventForm, Args)) return true; return false; }
        public bool key_down(Form EventForm, KeyEventArgs Args)             { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.key_down(EventForm, Args)) return true; return false; }
        public bool key_press(Form EventForm, KeyPressEventArgs Args)       { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.key_press(EventForm, Args)) return true; return false; }
        public bool key_up(Form EventForm, KeyEventArgs Args)               { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.key_up(EventForm, Args)) return true; return false; }

        public void KeyUp(object sender, KeyEventArgs e)               { e.Handled = key_up(GetForm((Control)sender), e); }
        public void KeyPress(object sender, KeyPressEventArgs e)       { e.Handled = key_press(GetForm((Control)sender), e); }
        public void KeyDown(object sender, KeyEventArgs e)             { e.Handled = key_down(GetForm((Control)sender), e); }
        public void MouseClick(object sender, MouseEventArgs e)        { mouse_click(GetForm((Control)sender), e); }
        public void MouseDoubleClick(object sender, MouseEventArgs e)  { mouse_doubleclick(GetForm((Control)sender), e); }
        public void MouseUp(object sender, MouseEventArgs e)           { mouse_up(GetForm((Control)sender), e); }
    }
}