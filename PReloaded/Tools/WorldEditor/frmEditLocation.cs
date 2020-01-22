using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using FOCommon.Parsers;

using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmEditLocation : Form
    {
        public Location Loc;
        LocationParser LocParser;
        MapParser MapParser;
        bool NewLoc;
        public bool Save = false;
        int LoadedPid;

        frmEditMap EditMap;

        public frmEditLocation(Location Loc, MapParser MapParser, LocationParser LocParser, bool NewLoc)
        {
            this.NewLoc = NewLoc;
            this.MapParser = MapParser;
            this.LocParser = LocParser;
            this.Loc = Loc;
            if(Loc!=null)
                LoadedPid = Loc.Pid;
            InitializeComponent();

            toolTip = new ToolTip();
            toolTip.SetToolTip(lblName, "Internal name, used to generate define (for _maps.fos)");
            toolTip.SetToolTip(lblWmName, "Worldmap name, shown in-game on the worldmap.");
        }

        private void frmEditLocation_Load(object sender, EventArgs e)
        {
            this.olvMusic.AspectToStringConverter = delegate(object x)
            {
                List<String> MusicNames = (List<String>)x;
                return String.Format("{0}", Utils.ToCSV(", ", MusicNames));
            };
            
            if (!NewLoc)
            {
                this.Text = "Location - " + Loc.Name + ", PID = " + Loc.Pid;
                txtName.Text = Loc.Name;
                txtWMName.Text = Loc.WorldMapName;
                txtDescription.Text = Loc.WorldMapDescription;
                txtEntranceScript.Text = Loc.EntranceScript;
                txtEntrance.Text = Loc.Entrance;
                txtSignImagePath.Text = Loc.WorldMapSignImagePath;
                txtTownImagePath.Text = Loc.WorldMapTownImagePath;
                numXPos.Value = Loc.X;
                numYPos.Value = Loc.Y;
                numSize.Value = Loc.Size;
                numPID.Value = Loc.Pid;
                numMaxCopies.Value = Loc.MaxPlayers;
                chkGeck.Checked = Loc.GeckVisible;

                chkVisible.Checked = Loc.Visible;
                chkEncounter.Checked = Loc.AutoGarbage;

                numPID.Enabled = false;
                btnAssignPID.Enabled = false;

                txtFlags.Lines = Loc.Flags.ToArray();

                if (String.IsNullOrEmpty(txtTownImagePath.Text))
                    btnEditTownMap.Enabled = false;

                if (!Loc.OnWorldmap)
                    btnRemoveFromWM.Visible = false;
            }
            else
            {
                this.Text = "Location";
                btnRemoveFromWM.Visible = false;
                Loc = new Location();
                numPID.Value = LocParser.GetFreeLocationPID(1);
                numSize.Value = 24;
                if (chkEncounter.Checked)
                {
                    numMaxCopies.Enabled = false;
                    txtEntrance.Enabled = false;
                }
                numMaxCopies.Value = 1;
                txtEntrance.Text = "1";

                Loc.Modified = true;
                Loc.Maps = new List<Map>();
            }

            lstMaps.RestoreState(TableSerializer.Load("lstMaps"));
            lstMaps.Items.Clear();
            if (Loc.Maps == null)
                return;
            lstMaps.SetObjects(Loc.Maps);
        }

        private void SaveProperties()
        {
            Loc.Name = txtName.Text;
            Loc.Pid = Decimal.ToInt32(numPID.Value);
            Loc.Size = Decimal.ToInt32(numSize.Value);
            Loc.X = Decimal.ToInt32(numXPos.Value);
            Loc.Y = Decimal.ToInt32(numYPos.Value);
            Loc.Entrance = txtEntrance.Text;
            Loc.EntranceScript = txtEntranceScript.Text;
            Loc.MaxPlayers = Decimal.ToInt32(numMaxCopies.Value);
            Loc.WorldMapName = txtWMName.Text;
            Loc.WorldMapDescription = txtDescription.Text;
            Loc.WorldMapSignImagePath = txtSignImagePath.Text;
            Loc.WorldMapTownImagePath = txtTownImagePath.Text;
            Loc.Visible = chkVisible.Checked;
            Loc.Modified = true;
            Loc.AutoGarbage = chkEncounter.Checked;
            Loc.GeckVisible = chkGeck.Checked;
            Loc.Flags = new List<string>(txtFlags.Lines);
            Save = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveProperties();
            TableSerializer.Save("lstMaps", lstMaps.SaveState());

            if ((Loc.Pid!=LoadedPid)&&!LocParser.IsFreeLocationPID(Loc.Pid))
            {
                Message.Show("Location PID is already in use.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Loc.Name))
            {
                Message.Show("You have to select a name for the location.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Loc.Maps.Count == 0)
            {
                Message.Show("The location has no maps.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Loc.Size == 0)
            {
                Message.Show("Location has no size.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        private void lstMaps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Map map = (Map)lstMaps.SelectedObject;
            if (map == null)
                return;
            EditMap = new frmEditMap(map, MapParser, false);
            EditMap.ShowDialog();
        }

        private void btnRemoveFromWM_Click(object sender, EventArgs e)
        {
            Loc.OnWorldmap = false;
            Loc.Modified = true;
            SaveProperties();
            this.Close();
        }

        private void btnRemoveMap_Click(object sender, EventArgs e)
        {
            Map map = (Map)lstMaps.SelectedObject;
            if (map == null)
                return;

            Loc.Maps.Remove(map);
            lstMaps.SetObjects(Loc.Maps);
        }

        private void btnAddMap_Click(object sender, EventArgs e)
        {
            frmAddMaps addMaps = new frmAddMaps(MapParser, Loc.Maps);
            addMaps.ShowDialog();
            if (addMaps.Maps == null)
                return;
            Loc.Maps.AddRange(addMaps.Maps);
            lstMaps.SetObjects(Loc.Maps);
        }

        private void btnAssignPID_Click(object sender, EventArgs e)
        {
            numPID.Value = LocParser.GetFreeLocationPID(Decimal.ToInt32(numPID.Value)+1);
        }

        private void chkEncounter_CheckedChanged(object sender, EventArgs e)
        {
            txtEntrance.Enabled = !chkEncounter.Checked;
            if (chkEncounter.Checked)
            {
                numMaxCopies.Value = 0;
                numMaxCopies.Enabled = false;
            }
            else
                numMaxCopies.Enabled = true;
        }

        private void lstMaps_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Map map = (Map)lstMaps.SelectedObject;
            if (map == null)
                return;

            frmEditMap editmap = new frmEditMap(map, MapParser, false);
            editmap.ShowDialog();
            lstMaps.SelectObjects(null);
            lstMaps.SelectObjects(Loc.Maps);
        }

        private void btnEditTownMap_Click(object sender, EventArgs e)
        {
            frmEditTownMap townmap = new frmEditTownMap(Path.GetFileNameWithoutExtension(txtTownImagePath.Text), Loc.EntryPoints, Loc.Maps);
            if(!townmap.Failed)
                townmap.ShowDialog();
            if (!townmap.Saved)
                return;
            Loc.Entrance = townmap.EntranceString;
            txtEntrance.Text = townmap.EntranceString;
            Loc.EntryPoints = townmap.EntryPoints;
        }

        private void btnFlagsHelp_Click(object sender, EventArgs e)
        {
            Message.Show("Used flags:" + Environment.NewLine +
                         "IsEncounter" + Environment.NewLine +
                         "IsBase" + Environment.NewLine +
                         "IsTown" + Environment.NewLine +
                         "IsTCTown" + Environment.NewLine +
                         "IsTent" + Environment.NewLine +
                         "IsInstancedQuest" + Environment.NewLine +
                         "IsReplication" + Environment.NewLine +
                         "IsMine" + Environment.NewLine, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTownImagePath_TextChanged(object sender, EventArgs e)
        {
            btnEditTownMap.Enabled = (!string.IsNullOrEmpty(txtTownImagePath.Text));
        }

        private void txtTownImagePath_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTownImagePath_Move(object sender, EventArgs e)
        {

        }

        private void btnEntranceHelp_Click(object sender, EventArgs e)
        {
            Message.Show("Enter for example map_script@entrance" + Environment.NewLine +
                         "bool entrance(Critter@[]& critters, uint8 entrance)" + Environment.NewLine +
                         "Return true to allow entrance, false to disallow.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }
}
