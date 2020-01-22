using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FOCommon;
using FOCommon.Dialog;

namespace WorldEditor.NZone.EncounterGroup
{
    public partial class frmSelectObject : Form
    {
        private List<object> SelectableObjects = new List<object>();
        public int Selected = 0;

        public frmSelectObject(string Caption, string SomeText)
        {
            InitializeComponent();
            this.Text = Caption;
            if (string.IsNullOrEmpty(SomeText))
                this.lblSomeText.Text = "";
            else
                this.lblSomeText.Text = SomeText;
        }

        public void AddObject(object SelectableObject)
        {
            SelectableObjects.Add(SelectableObject);
        }

        private void frmSelectProto_Load(object sender, EventArgs e)
        {
            lstObjects.SetObjects(SelectableObjects);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstObjects.SelectedObject!=null)
            {
                ISelectable obj = (ISelectable)lstObjects.SelectedObject;
                if (obj==null)
                    Selected = 0;
                else
                    Selected = obj.Id;
            }

            this.Close();
        }

        private void lstObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ISelectable obj = (ISelectable)lstObjects.SelectedObject;
            if (obj == null)
                return;
            if (obj is ListDialog)
            {
                ListDialog dlg = (ListDialog)obj;
                if (!FOCommon.Utils.LaunchDialogEditor(dlg, Config.PathScriptsDir + "../DialogEditor.exe"))
                    Message.Show("DialogEditor not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
