using System;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmSettingsCopying : Form
    {
        public ICopy ICopyObj { get; set; }

        public frmSettingsCopying()
        {
            InitializeComponent();
        }

        private void SetControls(bool ToUI)
        {
            FOCommon.Utils.SetControl(chkChance,     ref Config.CopyChance, ToUI);
            FOCommon.Utils.SetControl(chkDifficulty, ref Config.CopyDifficulty, ToUI);
            FOCommon.Utils.SetControl(chkGroups,     ref Config.CopyGroups, ToUI);
            FOCommon.Utils.SetControl(chkLocations,  ref Config.CopyLocations, ToUI);
            FOCommon.Utils.SetControl(chkTerrain,    ref Config.CopyTerrain, ToUI);
            FOCommon.Utils.SetControl(chkOverwrite,  ref Config.CopyOverwrite, ToUI);
            FOCommon.Utils.SetControl(chkFlags,      ref Config.CopyFlags, ToUI);
        }

        private void frmSettingsCopying_Load(object sender, EventArgs e)
        {
            label1.Text = "Here you can choose which properties " + Environment.NewLine + "of a zone that will be cloned when using Clone mode:";
            SetControls(true);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetControls(false);

            Copy CopyObj = new Copy();
            CopyObj.CopyChance = chkChance.Checked;
            CopyObj.CopyTerrain = chkTerrain.Checked;
            CopyObj.CopyDifficulty = chkDifficulty.Checked;
            CopyObj.CopyGroups = chkGroups.Checked;
            CopyObj.CopyLocations = chkLocations.Checked;
            CopyObj.CopyFlags = chkFlags.Checked;
            CopyObj.Overwrite = chkOverwrite.Checked;

            ICopyObj = CopyObj;

            this.Close();
        }
    }
}
