using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmAddFlag : Form
    {
        public List<String> Flags = new List<string>();

        public frmAddFlag()
        {
            InitializeComponent();
        }

        private void frmAddFlag_Load(object sender, EventArgs e)
        {
            lstFlags.Items.AddRange(EditorData.Flags.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (object item in lstFlags.SelectedItems)
            {
                Flags.Add(item.ToString());
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
