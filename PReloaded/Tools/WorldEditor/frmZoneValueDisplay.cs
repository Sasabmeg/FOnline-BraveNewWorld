using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmZoneValueDisplay : Form
    {
        public List<ValueZone> zones = new List<ValueZone>();
        public string zonevaluestring;
        public bool displayzones;

        public frmZoneValueDisplay()
        {
            InitializeComponent();
        }

        private void frmZoneValueDisplay_Load(object sender, EventArgs e)
        {
            txtZoneValue.Text = zonevaluestring;
            chkDisplay.Checked = displayzones;
        }

        private void btnDisplayZones_Click(object sender, EventArgs e)
        {
            zonevaluestring = txtZoneValue.Text;
            try
            {
                zones.Clear();
                string[] splitted = zonevaluestring.Split(' ');
                for (int i = 0; i < splitted.Length; i += 4)
                {
                    ValueZone newzone = new ValueZone();
                    string blah = splitted[i + 3].Substring(0, 2);
                    int r = Int32.Parse(splitted[i + 3].Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    int g = Int32.Parse(splitted[i + 3].Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    int b = Int32.Parse(splitted[i + 3].Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    newzone.x = Int32.Parse(splitted[i]);
                    newzone.y = Int32.Parse(splitted[i + 1]);
                    newzone.n = Int32.Parse(splitted[i + 2]);
                    newzone.c = Color.FromArgb(r, g, b);
                    zones.Add(newzone);
                }

            }
            catch (Exception ex)
            {
                Message.Show("Failed to parse string: " + ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkDisplay.Checked = false;
            }

            zonevaluestring = txtZoneValue.Text;
            displayzones = chkDisplay.Checked;
            this.Close();
        }
    }
}
