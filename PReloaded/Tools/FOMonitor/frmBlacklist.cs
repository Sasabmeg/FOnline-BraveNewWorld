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
    public partial class frmBlacklist : Form
    {
        public Dictionary<string, string> Blacklist = new Dictionary<string, string>();

        public frmBlacklist()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Blacklist = new Dictionary<string, string>();
            Blacklist = Utils.ParseBlacklist(txtBlacklist.Lines);
            this.Close();
        }

        private void frmBlacklist_Load(object sender, EventArgs e)
        {
            txtBlacklist.Lines = Utils.BlacklistToLines(Blacklist).ToArray();
        }
    }
}
