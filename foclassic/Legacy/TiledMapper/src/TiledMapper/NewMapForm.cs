using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiledMapper
{
    public partial class NewMapForm : Form
    {
        public bool OK { get; private set; }

        public NewMapForm()
        {
            OK = false;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int MapHeight
        {
            get
            {
                return (int)this.numHeight.Value;
            }
        }

        public int MapWidth
        {
            get
            {
                return (int)this.numWidth.Value;
            }
        }
    }
}
