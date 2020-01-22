using System;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmAbout : Form
    {
        public frmAbout(string Version)
        {
            InitializeComponent();
            txtAbout.Text = txtAbout.Text.Replace("%VERSION%", Version);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Help.ShowHelp(this, e.LinkText);
        }
    }
}
