using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmLocation : Form
    {
        public List<EncounterZoneLocation> Locations = new List<EncounterZoneLocation>();
        List<EncounterZoneLocation> ExistingLocations;
        bool IsDup(String Loc)
        {
            if (ExistingLocations == null) return false;
            foreach (EncounterZoneLocation ELoc in ExistingLocations)
                if (Loc == ELoc.Name)
                    return true;
            return false;
        }

        public frmLocation(List<EncounterZoneLocation> ExistingLocations)
        {
            this.ExistingLocations = ExistingLocations;
            InitializeComponent();
            foreach(String Loc in EditorData.Locations.ToArray())
                if(!IsDup(Loc))
                    lstLocations.Items.Add(Loc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (object item in lstLocations.SelectedItems)
            {
                EncounterZoneLocation ezl = new EncounterZoneLocation();
                ezl.Name=item.ToString();
                Locations.Add(ezl);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
