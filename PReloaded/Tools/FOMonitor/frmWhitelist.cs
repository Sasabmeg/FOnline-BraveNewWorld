using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOMonitor
{
    public partial class frmWhitelist : Form
    {
        public Dictionary<int, string> Whitelist = new Dictionary<int, string>();

        public frmWhitelist()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Whitelist = new Dictionary<int, string>();
            Whitelist = Utils.ParseWhitelist(txtWhitelist.Lines);
            this.Close();
        }

        private void frmWhitelist_Load(object sender, EventArgs e)
        {
            txtWhitelist.Lines = Utils.WhitelistToLines(Whitelist).ToArray();
        }
    }
}
