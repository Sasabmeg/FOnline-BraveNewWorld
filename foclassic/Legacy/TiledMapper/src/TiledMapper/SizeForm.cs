using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiledMapper
{
    public partial class SizeForm : Form
    {
        public bool OK { get; private set; }
        public int N { get; private set; }
        public int E { get; private set; }
        public int S { get; private set; }
        public int W { get; private set; }

        private int minx;
        private int miny;

        public SizeForm(int width, int height)
        {
            OK = false;
            minx = -width + 1;
            miny = -height + 1;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK = true;
            E = (int)this.numEast.Value;
            W = (int)this.numWest.Value;
            N = (int)this.numNorth.Value;
            S = (int)this.numSouth.Value;
            this.Close();
        }

        private void SizeForm_Load(object sender, EventArgs e)
        {
            this.numEast.Minimum = minx;
            this.numWest.Minimum = minx;
            this.numNorth.Minimum = miny;
            this.numSouth.Minimum = miny;
        }
    }
}
