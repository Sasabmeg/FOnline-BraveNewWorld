using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WorldEditor.Controls;

using FOCommon.WMLocation;
using WorldEditor.ProtoEditor;

namespace WorldEditor
{
    public partial class frmShell : Form
    {
        bool Debug;
        const string inputToken = ">>";

        List<String> history = new List<string>();
        int historyIndex=-1;
        string version;

        public WorldEditor.Controls.Console GetConsole()
        {
            return csl;
        }

        public frmShell(string version, bool Debug)
        {
            this.Debug = Debug;
            this.version = version;
            InitializeComponent();
        }

        private void frmShell_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void frmShell_Load(object sender, EventArgs e)
        {
            if (Debug)
                return;

            csl.AppendText("Welcome to FOnline shell.\n", Color.Yellow);
            csl.Text += "Using WorldEditor core " + version + "\n";
            csl.Text += "Type 'help' for a list of commands. And 'help a_command' for usage info.\n";
            csl.Text += "Use 'clear' to clear buffer. 'quit' to quit.\n";
            csl.Text += "-------------------------------------------\n";
            

            csl.AppendText(inputToken, Color.OliveDrab);
            csl.SetLastCaretLine();

        }

        private void SetLastLine(string text)
        {
            csl.DeselectAll();
            string str = csl.Lines[csl.Lines.Length - 1].Substring(inputToken.Length, csl.Lines[csl.Lines.Length - 1].Length - inputToken.Length);
            csl.Find(str, RichTextBoxFinds.Reverse);
            csl.SelectedText = text;
        }

        private void csl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control || e.Alt)
            {
                e.Handled = false;
                return;
            }

            if (csl.ReadOnly)
                return;

            string str = csl.Lines[csl.Lines.Length - 1];
            
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                if (historyIndex <= 0)
                {
                    historyIndex = history.Count;
                    SetLastLine("");
                    return;
                }
                SetLastLine(history[--historyIndex]);
                return;
            }
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                if (historyIndex >= history.Count - 1)
                {
                    SetLastLine("");
                    return;
                }
                SetLastLine(history[++historyIndex]);
                return;
            }
            
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.W))
            {
                e.Handled = false;
                return;
            }
            if(e.KeyCode == Keys.Back)
            {
                if (csl.Lines[csl.Lines.Length - 1] == inputToken)
                {
                    e.Handled = true;
                    return;
                }
                else if (csl.SelectedText.Contains(csl.Lines[csl.Lines.Length - 1]))
                {
                    SetLastLine("");
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                str = csl.Lines[csl.Lines.Length - 1].Substring(inputToken.Length, csl.Lines[csl.Lines.Length - 1].Length - inputToken.Length);

                bool Intercepted = false;
                if (Config.ScriptingEnabled)
                {
                    Intercepted = Scripting.Host.ScriptHost.shell_input(ref str);
                }
                
                history.Add(str);
                historyIndex = history.Count;
                csl.AppendText("\n");
                if (!Intercepted)
                {
                    if (str == "quit")
                    {
                        this.Close();
                        return;
                    }
                    else if (str == "help")
                    {
                        csl.AppendText("Not implemented yet!\n");
                    }

                    else if (str == "clear")
                    {
                        Scripting.Host.ScriptHost.ClearEvalBuffer();
                    }
                    else
                    {
                        String Error;
                        dynamic Output;
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (!Scripting.Host.ScriptHost.DoEval(str, true, out Error, out Output))
                            {
                                csl.AppendText((Error) + "\n");
                            }
                            else
                            {
                                // TODO: move this to external handler in host app, frmShell should be generic and usable in all apps.
                                if (Output is List<Location>) { foreach (Location loc in Output)  csl.AppendText((loc.ToString()) + "\n"); }
                                else if (Output is List<Map>) { foreach (Map map in Output)  csl.AppendText(map.ToString() + "\n"); }
                                else if (Output is List<ProtoCritter>) { foreach (ProtoCritter cr in Output)  csl.AppendText((cr.ToString()) + "\n"); }
                                else { csl.AppendText(Output + "\n"); }
                            }
                        });
                    }
                }

                csl.AppendText(inputToken, Color.OliveDrab);
                e.Handled = true;
            }

            if (e.KeyCode != Keys.Control && e.KeyCode != Keys.Alt)
            {
                int linestart = csl.TextLength - (csl.Lines[csl.Lines.Length - 1].Length - inputToken.Length);

                if(csl.SelectionStart<linestart)
                    csl.SelectionStart = csl.TextLength;
                

                csl.SelectionColor = csl.ForeColor;
            }
        }
    }
}
