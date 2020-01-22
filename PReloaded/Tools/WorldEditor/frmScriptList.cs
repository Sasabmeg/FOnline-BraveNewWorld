using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FOCommon.Script;

namespace WorldEditor
{
    public partial class frmScriptList : Form
    {
        List<ScriptDeclaration> Scripts;

        public frmScriptList(List<ScriptDeclaration> Scripts)
        {
            this.Scripts = Scripts;
            InitializeComponent();
        }

        private void frmScriptList_Load(object sender, EventArgs e)
        {
            lstScripts.SetObjects(Scripts);
        }
    }
}
