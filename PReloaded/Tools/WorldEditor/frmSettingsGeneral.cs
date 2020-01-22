using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmSettingsGeneral : Form
    {
        private void DrawLine(Graphics g, Color color)
        {
            Pen pen = new Pen(color, 8.0f);
            g.DrawLine(pen, new Point(0, 10), new Point(50, 10));
        }

        public frmSettingsGeneral()
        {
            InitializeComponent();
        }

        private void SetControls(bool ToUI)
        {
            FOCommon.Utils.SetControl(chkDisplayToolTip,       ref Config.ShowTooltip, ToUI);
            FOCommon.Utils.SetControl(chkDisplayLocationNames, ref Config.ShowLocationNames, ToUI);
            FOCommon.Utils.SetControl(chkDisplayLocations,     ref Config.ShowLocations, ToUI);

            FOCommon.Utils.SetColor(cmbImplemented,            ref Config.ColorImplemented, ToUI);
            FOCommon.Utils.SetColor(cmbFiltered,               ref Config.ColorFiltered, ToUI);
            FOCommon.Utils.SetColor(cmbSelected,               ref Config.ColorSelected, ToUI);
            FOCommon.Utils.SetColor(cmbModified,               ref Config.ColorModified, ToUI);
            FOCommon.Utils.SetColor(cmbBrushed,                ref Config.ColorBrushed, ToUI);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetControls(false);
            this.Close();
        }

        private void LocationOptionCheck()
        {
            if (!chkDisplayLocations.Checked)
            {
                chkDisplayLocationNames.Checked = false;
                chkDisplayLocationNames.Enabled = false;
                chkDisplayToolTip.Checked = false;
                chkDisplayToolTip.Enabled = false;
            }
            else
            {
                chkDisplayLocationNames.Enabled = true;
                chkDisplayToolTip.Enabled = true;
            }
        }

        private void frmSettingsGeneral_Load(object sender, EventArgs e)
        {
            SetControls(true);
            LocationOptionCheck();
        }

        private void chkDisplayLocations_CheckedChanged(object sender, EventArgs e)
        {
            LocationOptionCheck();
        }

    }
}
