using System;
using System.Windows.Forms;

namespace ObjectEditor
{
    public partial class frmAbout : Form
    {
        public frmAbout(String Text)
        {
            InitializeComponent();
            txtAbout.Text = Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Help.ShowHelp(this, e.LinkText);
        }
    }
}
