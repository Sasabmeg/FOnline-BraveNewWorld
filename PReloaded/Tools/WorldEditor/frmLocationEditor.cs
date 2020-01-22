using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FOCommon.Parsers;
using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmLocationEditor : Form
    {
        List<Location> Locations = new List<Location>();
        MapParser MapParser;
        LocationParser LocParser;

        public frmLocationEditor(List<Location> Locations, MapParser MapParser, LocationParser LocParser)
        {
            this.Locations = Locations;
            this.MapParser = MapParser;
            this.LocParser = LocParser;
            InitializeComponent();
        }

        private void frmLocationEditor_Load(object sender, EventArgs e)
        {
            lstLocations.RestoreState(TableSerializer.Load("lstLocations"));
            lstLocations.SetObjects(Locations);
        }

        private void lstLocations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Location loc = (Location)lstLocations.SelectedObject;
            if (loc == null)
                return;
            frmEditLocation editLoc = new frmEditLocation(loc, MapParser,LocParser,false);
            editLoc.ShowDialog();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            TableSerializer.Save("lstLocations", lstLocations.SaveState());
            this.Close();
        }

        private void btnAddNewLocation_Click(object sender, EventArgs e)
        {
            frmEditLocation editLoc = new frmEditLocation(null, MapParser,LocParser, true);
            editLoc.ShowDialog();
            if (editLoc.Save)
            {
                Locations.Add(editLoc.Loc);
                lstLocations.SetObjects(Locations);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            Location loc = (Location)lstLocations.SelectedObject;
            if (loc == null)
                return;
            LocParser.RemoveLocation(loc);
            Locations.Remove(loc);
            lstLocations.SetObjects(Locations);
        }
    }
}
