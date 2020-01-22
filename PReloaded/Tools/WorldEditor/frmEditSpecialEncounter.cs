using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FOCommon.WMLocation;

namespace WorldEditor
{
    // This feature is not implemented yet.

    public partial class frmEditSpecialEncounter : Form
    {
        public SpecialEncounter Encounter;
        public bool Save;
        Location Loc;
        List<Location> Locations;

        public frmEditSpecialEncounter(SpecialEncounter Encounter, List<Location> Locations)
        {
            this.Locations = Locations;
            InitializeComponent();
            if (Encounter == null)
                return;
            txtName.Text = Encounter.Name;
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            frmAddLocation SelectLocation = new frmAddLocation("Special Encounter - Select a location", "Choose a location that you want to use for special encounter:", Locations, true);
            SelectLocation.ShowDialog();
            if (!SelectLocation.Selected)
                return;
            this.Loc = SelectLocation.Loc;
            txtLocation.Text = Loc.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Encounter = new SpecialEncounter(txtName.Text, txtDescription.Text, this.Loc, (100/(int)numChance.Value));
            Save = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
