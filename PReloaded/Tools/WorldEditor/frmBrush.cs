using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorldEditor
{
    public partial class frmBrush : Form
    {
        public List<EncounterZoneGroup> Groups = new List<EncounterZoneGroup>();
        public List<EncounterZoneLocation> Locations = new List<EncounterZoneLocation>();
        public List<string> Flags = new List<string>();
        public int EncounterChance;
        public bool Cancelled;
        public bool Mode;
        public bool OverwriteChance;

        public frmBrush()
        {
            InitializeComponent();
        }

        private void frmErase_Load(object sender, EventArgs e)
        {
            numEncounterQuantity.Visible = Mode;
            lblChance.Visible = Mode;

            numEncounterQuantity.Value = 1;
            
            lstGroups.Items.Clear();
            lstLocations.Items.Clear();
            lstFlags.Items.Clear();
            lstGroups.Items.AddRange(EditorData.Groups.ToArray());
            lstLocations.Items.AddRange(EditorData.Locations.ToArray());
            lstFlags.Items.AddRange(EditorData.Flags.ToArray());
            Cancelled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Groups.Clear();
            Locations.Clear();
            Flags.Clear();

            OverwriteChance = chkOverwriteChance.Checked;
            EncounterChance = Decimal.ToInt32(numEncounterQuantity.Value);

            foreach (object o in lstGroups.SelectedItems)
            {
                EncounterZoneGroup group = new EncounterZoneGroup();
                group.Name = o.ToString();
                group.Quantity = Decimal.ToInt32(numEncounterQuantity.Value);
                Groups.Add(group);
            }

            foreach (object o in lstLocations.SelectedItems)
            {
                EncounterZoneLocation location = new EncounterZoneLocation();
                location.Name = o.ToString();
                Locations.Add(location);
            }

            foreach (object o in lstFlags.SelectedItems)
            {
                string flag;
                flag = o.ToString();
                Flags.Add(flag);
            }

            Cancelled = false;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            this.Close();
        }
    }
}
