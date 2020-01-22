using System;
using System.Windows.Forms;

namespace ScriptHost.Forms
{
    public partial class frmScriptsLoaded : Form
    {
        ScriptHost Host;

        public frmScriptsLoaded(ScriptHost Host)
        {
            this.Host = Host;
            InitializeComponent();
        }

        private void frmScriptsLoaded_Shown(object sender, EventArgs e)
        {
            lstScripts.SetObjects(Host.GetLoadedExtensions());
        }
    }
}
