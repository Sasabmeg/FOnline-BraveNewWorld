using System;
using System.Windows.Forms;

using ScriptHost;

namespace ObjectEditor.Scripting
{
    public interface IScript : ScriptHost.IScript
    {
        bool add_control(ref Control Ctrl, ref bool Add);
        void resources_loaded();
        void main_form_loaded();
        bool shell_input(ref string text);
    }

    public class ScriptGlobal : ScriptHost.ScriptGlobal
    {
        public int Random(int min, int max) { return new Random((int)DateTime.Now.Ticks).Next(min, max+1); }
        public void RegisterForm(Form form) { Host.RegisterFormEvents(form); }

        new public void Init(ScriptHost.ScriptHost Host)
        {
            Rand = new Random();
        }
    }

    public static class Host
    {
        public static ScriptGlobal ScriptGlobal;
        public static OEScriptHost ScriptHost;
    }

    public class OEScriptHost : ScriptHost.ScriptHost
    {

        public override string GetImports()
        {
            return @"using System;
                        using System.Collections;
                        using System.Drawing;
                        using System.Windows.Forms;
                        using System.Collections.Generic;
                        using System.Linq;
                        using ObjectEditor.Scripting;" + Environment.NewLine;
        }

        public override void Preprocess(ref string Text) {}

        public override void Log(string Text)
        {
            Utils.Log(Text);
        }

        public override void InitEventStubs()
        {
            EventStubs.Add("public bool add_control", "public bool add_control(ref Control Ctrl, ref bool Add) { return true; }");
        }

        /////////// Wrappers for callbacks ///////////////////////////////////
        // if return parameter, only for main script                         /
        // else for all registered extensions                                /
        //////////////////////////////////////////////////////////////////////
        public void main_form_loaded() { foreach (ScriptExtension Ext in Extensions) Ext.Handle.main_form_loaded(); }
        public void resources_loaded() { foreach (ScriptExtension Ext in Extensions) Ext.Handle.resources_loaded(); }
        public bool shell_input(ref string text)                { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.shell_input(ref text)) return true; return false; }
        public bool add_control(ref Control Ctrl, ref bool Add) { foreach (ScriptExtension Ext in Extensions) if (Ext.Handle.add_control(ref Ctrl, ref Add)) return true; return false; }
    }
}
