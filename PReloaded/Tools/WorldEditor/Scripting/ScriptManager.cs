using System;
using System.Windows.Forms;

namespace WorldEditor.Scripting
{
    class ScriptManager
    {
        public ScriptManager(Form form)
        {
            Utils.Log("Starting scripthost...");
            Scripting.Host.ScriptHost = new WEScriptHost();
            Scripting.Host.ScriptGlobal = new ScriptGlobal();
            Scripting.Host.ScriptHost.Init(form, Config.PathEditorScript);
            
        }

        public void RegisterFormEvents(Form form)
        {
            Scripting.Host.ScriptHost.RegisterFormEvents(form);
        }

        public void InitHost(bool Shell, string version, WorldMap worldmap, PictureBox pctWorldMap)
        {
            Scripting.Host.ScriptGlobal.Init(Scripting.Host.ScriptHost, worldmap, pctWorldMap);
            Scripting.Host.ScriptHost.resources_loaded();
            if (Shell)
            {
                frmShell shell = new frmShell(version, false);
                Scripting.Host.ScriptHost.RegisterConsole(shell.GetConsole());
                shell.Show();
            }
        }

        public bool AnyUpdateExtensions()
        {
            bool Found = false;
            foreach (ScriptHost.ScriptExtension Ext in Scripting.Host.ScriptHost.GetLoadedExtensions())
            {
                if (Ext.UpdateTime != 0)
                    Found = true;
            }
            return Found;
        }

        public void UpdateScripts_Tick()
        {
            foreach (ScriptHost.ScriptExtension Ext in Scripting.Host.ScriptHost.GetLoadedExtensions())
            {
                if (Ext.UpdateTime == 0)
                    continue;

                long delta = Environment.TickCount - Ext.UpdateTimeCount;

                if (delta >= Ext.UpdateTime)
                {
                    Ext.UpdateTimeCount = Environment.TickCount;
                    Scripting.Host.ScriptHost.update(Ext);
                }
            }
        }
    }
}
