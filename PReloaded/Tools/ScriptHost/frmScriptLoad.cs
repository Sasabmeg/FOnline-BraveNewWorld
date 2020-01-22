using System;
using System.Windows.Forms;

namespace ScriptHost.Forms
{
    public partial class frmScriptLoad : Form
    {
        bool Retry;
        string ScriptPath;

        public frmScriptLoad(string ScriptPath)
        {
            this.ScriptPath = ScriptPath;
            InitializeComponent();
        }

        public TextBox GetTextBox() { return this.txtLog; }

        public bool IsRetry() { return Retry; }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            Retry = true;
            this.Close();
        }

        private void btnEditConfig_Click(object sender, EventArgs e)
        {
            frmExtensionList frm = new frmExtensionList(ScriptPath);
            frm.ShowDialog();
        }

        private void frmScriptLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
