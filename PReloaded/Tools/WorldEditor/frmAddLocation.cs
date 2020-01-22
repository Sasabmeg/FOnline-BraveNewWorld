using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmAddLocation : Form
    {
        public List<Location> Locations;
        public Location Loc;
        public bool Selected = false;
        bool ShowAll = false; // false, show only those not on WM, true, all locations.

        public frmAddLocation(string Title, string Description, bool ShowAll)
        {
            InitializeComponent();
            this.Text = Title;
            this.ShowAll = ShowAll;
            lblDescription.Text = Description;
        }

        public frmAddLocation(string Title, string Description, List<Location> Locations, bool ShowAll)
        {
            InitializeComponent();
            this.Locations = Locations;
            this.Text = Title;
            this.ShowAll = ShowAll;
            lblDescription.Text = Description;
        }

        private void frmAddLocation_Load(object sender, EventArgs e)
        {
            if (ShowAll)
                lstLocations.SetObjects(Locations);
            else
            {
                foreach (Location Loc in Locations)
                {
                    if (!Loc.OnWorldmap)
                        lstLocations.AddObject(Loc);
                }
            }
            this.Loc = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Loc = (Location)lstLocations.SelectedObject;
            if (Loc == null)
                return;
            Selected = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
