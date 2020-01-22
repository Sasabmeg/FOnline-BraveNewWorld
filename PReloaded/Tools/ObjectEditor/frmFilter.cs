using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectEditor
{
    public partial class frmFilter : Form
    {
        private uint Flags;

        public uint GetFlags() { return Flags; }

        public frmFilter(Custom CustomElements)
        {
            InitializeComponent();
            CustomElements.CreateFlags(grpFilterFlags, 7, 20, false);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Flags = 0;
            foreach (CheckBox chkBox in grpFilterFlags.Controls)
            {
                if (chkBox.Checked)
                {
                    String Define = (String)chkBox.Tag;
                    FOCommon.Utils.SetFlag(ref Flags, (uint)Data.Defines[Define]);
                }
            }

            this.Close();
        }
    }
}
