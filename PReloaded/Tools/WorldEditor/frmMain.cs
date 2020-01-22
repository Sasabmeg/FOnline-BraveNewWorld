using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

using WorldEditor.NZone.EncounterGroup;
using WorldEditor.ProtoEditor;
using WorldEditor.Scripting;

using ScriptHost.Forms;

using WorldEditor.Debug;

using FOCommon.Items;

using FOCommon.WMLocation;
using FOCommon.Parsers;
using FOCommon.Worldmap.EncounterGroup;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WorldEditor
{
    public partial class frmMain : Form
    {
        frmSettingsCopying SettingsCopying = new frmSettingsCopying();
        frmSettingsGeneral SettingsGeneral = new frmSettingsGeneral();
        frmBrush BrushOptions = new frmBrush();
        frmEditLocation EditLocation;
        frmZoneValueDisplay ZoneValueDisplay = new frmZoneValueDisplay();
        frmMapEditor MapDataEditor;
        frmAddLocation AddLocation = new frmAddLocation("Worldmap - Add Location", "Choose a location that you want to add to the worldmap:", false);
        ToolTip LocationToolTip = new ToolTip();
        bool DrawToolTip = false;
        bool IsFirstPaint = true;
        WorldMap worldmap;
        IZone CopiedZone;
        IZone PaintZone;
        ICopy ICopyParams;
        EncounterGroup SelectedGroup;
        Point ToolTipLast = new Point(0, 0);
        Point MouseZoneLocation = new Point();
        private Config Config = null;

        Thread ScriptThread;

        Commandline.Commandline cmd = new Commandline.Commandline();

        ScriptManager ScriptManager;
        DebugManager DebugManager;

        int ProgressLoadMaps=0;
        int ProgressLoadMisc=0;

        const string version = "1.12 (modified by Cubik).";

        public frmMain()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture   = new System.Globalization.CultureInfo("en-US");

            Config = new Config("WorldEditor");
            Config.Load();
            if (Config.DebugConsole)     DebugManager  = new DebugManager(version);
            if (Config.ScriptingEnabled) ScriptManager = new ScriptManager(this);

            Display.ZoneSize = Config.WorldmapZoneSize;
            Display.WorldmapScale = Config.WorldmapScale;

            InitializeComponent();

            ScriptManager.RegisterFormEvents(this);
            
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }

        private void HandleToolButtonClick(ToolStripButton button)
        {
            bool check = false;

            if (button.Checked == true)
                check = true;

            toolbtnClone.Checked = false;
            toolbtnBrush.Checked = false;
            toolbtnErase.Checked = false;

            button.Checked = check;
        }

        private bool AnyBrushModeEnabled()
        {
            return (toolbtnClone.Checked || toolbtnBrush.Checked || toolbtnErase.Checked);
        }

        private bool OpenBrushOptions(bool Mode)
        {
            BrushOptions.Mode = Mode;
            BrushOptions.ShowDialog();
            return !BrushOptions.Cancelled;
        }

        private void ResetZonePropertyControls()
        {
            lstGroups.Items.Clear();
            lstLocations.Items.Clear();
            cmbTerrain.Text = "";
            //cmbChance.Text = "";
        }

        private void RefreshZoneProperties()
        {
            IZone zone = worldmap.GetSelectedZone();
            if (zone == null)
            {
                ResetZonePropertyControls();
                ChangeEnableStateOfZonePropertyControls(false);
                lblSelectedZoneCoords.Text = "Zone Coordinates: ";
                return;
            }

            //cmbChance.Text = zone.Chance;
            cmbTerrain.Text = zone.Terrain;
            lstGroups.ClearObjects();

            pnlWorldMap.Focus();

            RefreshLocationList();
            RefreshGroupList();
            RefreshFlagsList();


            lblSelectedZoneCoords.Text = "Zone Coordinates: " + zone.X + ", " + zone.Y;
            
            pctWorldMap.Refresh();
        }

        private void QuitPrompt()
        {
            Utils.Log("Launching QuitPrompt()");
            bool Modified = worldmap.IsModified();
            DialogResult ret=DialogResult.Abort;
            if (Modified)
            {
                ret = Message.Show("Are you really sure that you want to exit? If you havn't saved your work, it will be lost.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (ret == DialogResult.Yes || !Modified)
            {
                FOCommon.Cache.Cache.Save(".\\Cache.dat");
                SaveUISettings();
                Config.Save();
                Environment.Exit(0);
            }
        }

        private void ReplaceSelectedZone(IZone ReplaceZone, ICopy CopyParams)
        {
            IZone zone = worldmap.GetSelectedZone();
            if (zone == null)
                return;

            if (ReplaceZone != null)
                worldmap.ReplaceSelectedZone(ReplaceZone, CopyParams);
        }

        private void LoadUISettings()
        {
            Utils.Log("Loading UI Settings");
            this.Location = new Point(Config.WindowX, Config.WindowY);
            this.Height = Config.WindowH;
            this.Width = Config.WindowW;
            this.chkShowImplemented.Checked = Config.ZoneShowImplemented;
            this.chkShowModified.Checked = Config.ZoneShowModified;
            this.chkShowZones.Checked = Config.ZoneShowSpecific;

            this.Text = "FOnline WorldEditor " + version;
            Utils.Log("Loaded UI Settings");
        }

        private void SaveUISettings()
        {
            Utils.Log("Saving UI Settings");
            Config.WindowX = this.Location.X;
            Config.WindowY = this.Location.Y;
            Config.WindowH = this.Height;
            Config.WindowW = this.Width;
            Config.ZoneShowImplemented = this.chkShowImplemented.Checked;
            Config.ZoneShowSpecific = this.chkShowZones.Checked;
            Config.ZoneShowModified = this.chkShowModified.Checked;
            //Config.Sa;
            Utils.Log("Saved UI Settings");
        }

        private void ClearControls()
        {
            Utils.Log("Clearing controls");
            //cmbChance.Items.Clear();
            //cmbTable.Items.Clear();
            cmbTerrain.Items.Clear();
            cmbShowTable.Items.Clear();
            cmbShowGroup.Items.Clear();
            cmbShowTerrain.Items.Clear();
            cmbShowChance.Items.Clear();
            cmbShowFlag.Items.Clear();
        }

        private void ChangeEnableStateOfZonePropertyControls(bool mode)
        {
            //cmbChance.Enabled = mode;
            cmbTerrain.Enabled = mode;
            //cmbTable.Enabled = mode;
            cmbShowGroup.Enabled = mode;
            cmbShowTerrain.Enabled = mode;
            cmbShowTable.Enabled = mode;
            cmbShowChance.Enabled = mode;
            numericDifficulty.Enabled = mode;
            btnAddGroup.Enabled = mode;
            btnRemoveGroup.Enabled = mode;
            btnAddLocation.Enabled = mode;
            btnRemoveLocation.Enabled = mode;
            btnAddFlag.Enabled = mode;
            btnRemoveFlag.Enabled = mode;
        }

        private void AddStringsToZonePropertyControls()
        {
            ClearControls();
            while (!EditorData.IsParsed) { Thread.Sleep(1); }

            //cmbChance.Items.AddRange(EditorData.Chances.ToArray());
            //cmbTable.Items.AddRange(EditorData.Tables.ToArray());
            cmbTerrain.Items.AddRange(EditorData.Terrains.ToArray());
            cmbShowTable.Items.AddRange(EditorData.Tables.ToArray());
            cmbShowGroup.Items.AddRange(EditorData.Groups.ToArray());
            cmbShowLocation.Items.AddRange(EditorData.Locations.ToArray());
            cmbShowTerrain.Items.AddRange(EditorData.Terrains.ToArray());
            cmbShowChance.Items.AddRange(EditorData.Chances.ToArray());
            cmbShowFlag.Items.AddRange(EditorData.Flags.ToArray());
        }

        private void LoadWorldMapImage()
        {
            Utils.Log("Loading " + Config.PathWorldMapPic);
            try
            {
                Bitmap Bitmap = new Bitmap(Config.PathWorldMapPic);
                pctWorldMap.Image = Bitmap.ScaleByPercent(Display.WorldmapScale);
            }
            catch (FileNotFoundException)
            {
                Utils.Log("Failed to load " + Config.PathWorldMapPic);
                Message.Show("Couldn't find " + Config.PathWorldMapPic, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitColors()
        {
            Drawing.SelectedColor =    FOCommon.Utils.GetColor(Config.ColorSelected);
            Drawing.ImplementedColor = FOCommon.Utils.GetColor(Config.ColorImplemented);
            Drawing.FilteredColor =    FOCommon.Utils.GetColor(Config.ColorFiltered);
            Drawing.ModifiedColor =    FOCommon.Utils.GetColor(Config.ColorModified);
            Drawing.BrushedColor  =    FOCommon.Utils.GetColor(Config.ColorBrushed);
        }

        private void pctWorldMap_MouseMove(object sender, MouseEventArgs e)
        {
            int ZoneX = Display.PixelToZoneCoord(e.X);
            int ZoneY = Display.PixelToZoneCoord(e.Y);

            Point ZoneCoords = new Point(ZoneX, ZoneY);

            toolStripStatusLabelMouseCoords.Text = "| Coords: " + e.X.ToString() + ", " + e.Y.ToString();
            toolStripStatusLabelZoneCoords.Text = "Zone: " + ZoneCoords.X.ToString() + ", " + ZoneCoords.Y.ToString();
            toolStripStatusLabelGameCoords.Text = "Game Coords: " + Display.PixelToGameCoords(e.X).ToString() + ", " + Display.PixelToGameCoords(e.Y).ToString();

            if (AddLocation.Selected)
            {
                AddLocation.Loc.X = Display.PixelToGameCoords(e.X);
                AddLocation.Loc.Y = Display.PixelToGameCoords(e.Y);
                AddLocation.Loc.OnWorldmap = true;
                AddLocation.Loc.Modified = true;
                pctWorldMap.Refresh();
            }

            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (AnyBrushModeEnabled())
                    worldmap.SetSelectedZone(ZoneX, ZoneY);

                if (toolbtnClone.Checked)
                {
                    ReplaceSelectedZone(PaintZone, ICopyParams);
                    RefreshZoneProperties();
                }

                if (toolbtnErase.Checked)
                {
                    if (worldmap.ModifySelectedZoneWithBrush(BrushOptions.Groups, BrushOptions.Locations, BrushOptions.Flags, false, 0))
                        RefreshZoneProperties();
                }

                if (toolbtnBrush.Checked)
                {
                    int chance = 0;
                    if ((BrushOptions.OverwriteChance)) chance=BrushOptions.EncounterChance;
                    if (worldmap.ModifySelectedZoneWithBrush(BrushOptions.Groups, BrushOptions.Locations, BrushOptions.Flags, true, chance))
                        RefreshZoneProperties();
                }

                //if (AnyBrushModeEnabled())
                //    RefreshZoneProperties();

            }

            if (!Config.ShowTooltip || AddLocation.Selected)
                return;

            if (DrawToolTip)
            {

                int x = e.X + 15;
                int y = e.Y + 15;
                string str = (string)LocationToolTip.Tag.ToString();
                int strlength = str.Length;

                if ((Cursor.Position.X + (strlength * 4)) > Screen.PrimaryScreen.Bounds.Width)
                {
                    x -= ((Cursor.Position.X + (strlength * 4)) - Screen.PrimaryScreen.Bounds.Width);
                }
                if ((x != ToolTipLast.X) || (y != ToolTipLast.Y))
                {
                    LocationToolTip.Show((string)LocationToolTip.Tag, pctWorldMap, x, y, 100000);
                    ToolTipLast.X = x;
                    ToolTipLast.Y = y;
                }
            }

                MouseZoneLocation = ZoneCoords;

                if (worldmap == null)
                    return;

                Location Loc = worldmap.GetLocation(Display.PixelToGameCoords(e.X), Display.PixelToGameCoords(e.Y));
                if (Loc != null && Loc.OnWorldmap)
                {
                    LocationToolTip.Tag = Loc.Name + " (" + Loc.Pid + ")" + Environment.NewLine + Loc.WorldMapDescription
                        + Environment.NewLine + (Loc.Visible ? "Visible: Yes" : "Visible: No");
                    LocationToolTip.UseFading = true;
                    DrawToolTip = true;
                }
                else
                {
                    LocationToolTip.Hide(pctWorldMap);
                    DrawToolTip = false;
                    return;
                }
        }

        private void pctWorldMap_Paint(object sender, PaintEventArgs e)
        {
            if (worldmap == null)
                return;

            if (chkShowImplemented.Checked)
                worldmap.DrawAvailable(e.Graphics);

            if (chkShowZones.Checked)
            {
                worldmap.DrawFilteredWorldZones(new DefaultFilter(chkShowTerrain.Checked, chkShowChance.Checked, chkShowNoLocation.Checked,
                    chkShowNoEncounter.Checked, chkShowLocation.Checked, chkShowGroup.Checked, chkShowFlag.Checked, cmbShowTerrain.Text, 
                    cmbShowChance.Text, cmbShowGroup.Text, cmbShowLocation.Text, cmbShowFlag.Text ), e.Graphics);
            }

            if (chkShowItemZones.Checked && (cmbShowItemZones.SelectedItem!=null))
                worldmap.DrawItemZones(e.Graphics, cmbShowItemZones.SelectedItem.ToString(), chkShowItemZonesAmount.Checked);

            if (chkShowModified.Checked)
                worldmap.DrawModified(e.Graphics);

            if (chkShowDifficultyMap.Checked)
                worldmap.DrawDifficultyZones(e.Graphics, cmbDifficultyMode.SelectedIndex == 0 ? true : false, Decimal.ToInt32(numDifficultyOnlyAbove.Value), chkShowNumbersDiff.Checked);

            if (chkShowGroupDensity.Checked)
                worldmap.DrawGroupDensity(e.Graphics, chkShowNumbers.Checked);

            if (chkShowGroupQuantities.Checked)
            {
                int modifier=0;
                if (rbtnGroupQuantityDay.Checked)
                    modifier = 1;
                else if (rbtnGroupQuantityNight.Checked)
                    modifier = 2;

                worldmap.DrawGroupQuantities(e.Graphics, chkShowNumbers.Checked, modifier);
            }

            if (ZoneValueDisplay.displayzones)
                worldmap.DrawZoneValue(e.Graphics, ZoneValueDisplay.zones);

            worldmap.DrawBrushed(e.Graphics);
            worldmap.DrawSelectedZone(e.Graphics);
            worldmap.DrawLocations(e.Graphics);
            worldmap.DrawScript(e.Graphics);
        }

        private void pctWorldMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (worldmap == null)
                return;

            this.ActiveControl = null;

            if (Config.ScriptingEnabled)
            {
                if (Scripting.Host.ScriptHost.worldmap_coords_clicked(e, e.X, e.Y))
                    return;
            }

            if (e.Button == MouseButtons.Right)
            {
                if (AddLocation.Loc != null)
                {
                    AddLocation.Selected = false;
                    AddLocation.Loc.OnWorldmap = false;
                    AddLocation.Loc = null;
                }
                worldmap.SetSelectedZone(-1, -1);
                pctWorldMap.Focus();
                pctWorldMap.Refresh();
                ChangeEnableStateOfZonePropertyControls(false);
                RefreshZoneProperties();
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                if (AddLocation.Selected)
                {
                    AddLocation.Loc.X = Display.PixelToGameCoords(e.X);
                    AddLocation.Loc.Y = Display.PixelToGameCoords(e.Y);
                    AddLocation.Loc.OnWorldmap = true;
                    AddLocation.Loc.Modified = true;
                    AddLocation.Selected = false;
                    AddLocation.Loc = null;
                }
                else
                {
                    int ZoneX = Display.PixelToZoneCoord(e.X);
                    int ZoneY = Display.PixelToZoneCoord(e.Y);

                    if (Config.ScriptingEnabled)
                    {
                        if (Scripting.Host.ScriptHost.zone_activated(ZoneX, ZoneY))
                            return;
                    }

                    worldmap.SetSelectedZone(ZoneX, ZoneY);
                    ChangeEnableStateOfZonePropertyControls(true);
                    RefreshZoneProperties();
                    pctWorldMap.Refresh();
                }

                if (checkBox2.Checked == true)
                {
                    IExtZone zone = (IExtZone)worldmap.GetSelectedZone();
                    frmAddGroup group = new frmAddGroup(worldmap.GroupParser.GetGroups(), zone.EncounterGroups);
                    group.ShowDialog();
                    //group.Show();
                    if (group.SelectedGroups.Count == 0)
                        return;

                    if (zone.EncounterGroups == null)
                        zone.EncounterGroups = new List<EncounterZoneGroup>();

                    zone.EncounterGroups.AddRange(group.SelectedGroups);
                    zone.Modified = true;
                    RefreshGroupList();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitPrompt();
        }

        private void Save()
        {
            if (worldmap.Save())
                Message.Show("Saved successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Message.Show("Failed to save.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void numericDifficulty_ValueChanged(object sender, EventArgs e)
        {
            worldmap.ModifyDifficulty(numericDifficulty.Value.ToString());
        }

        private void chkImplemented_CheckStateChanged(object sender, EventArgs e)
        {
            pctWorldMap.Refresh();
        }

        private void numericDifficulty_KeyUp(object sender, KeyEventArgs e)
        {
            worldmap.ModifyDifficulty(numericDifficulty.Value.ToString());
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (pnlWorldMap.Focused)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    IZone zone = worldmap.GetSelectedZone();
                    CopiedZone = zone.Clone();
                }

                if (e.Control && e.KeyCode == Keys.V)
                {
                    ReplaceSelectedZone(CopiedZone, ICopyParams);
                    RefreshZoneProperties();
                }

                if ((e.KeyCode == Keys.Delete) && !e.Control && !e.Alt)
                {
                    worldmap.DeleteSelected();
                    RefreshZoneProperties();
                    pctWorldMap.Refresh();
                }

                if (e.KeyCode == Keys.Left)
                    worldmap.MoveSelectedZone(-1,0);
                if (e.KeyCode == Keys.Right)
                    worldmap.MoveSelectedZone(1, 0);
                if (e.KeyCode == Keys.Up)
                    worldmap.MoveSelectedZone(0, -1);
                if (e.KeyCode == Keys.Down)
                    worldmap.MoveSelectedZone(0, 1);

                RefreshZoneProperties();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuitPrompt();
            e.Cancel = true;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            IExtZone zone = (IExtZone)worldmap.GetSelectedZone();
            frmAddGroup group = new frmAddGroup(worldmap.GroupParser.GetGroups(), zone.EncounterGroups);
            group.ShowDialog();
            //group.Show();
            if (group.SelectedGroups.Count == 0)
                return;

            if (zone.EncounterGroups == null)
                zone.EncounterGroups = new List<EncounterZoneGroup>();

            zone.EncounterGroups.AddRange(group.SelectedGroups);
            zone.Modified = true;
            RefreshGroupList();
        }

        private void btnRemoveMap_Click(object sender, EventArgs e)
        {
            IExtZone zone = (IExtZone)worldmap.GetSelectedZone();

            ArrayList SLocs = (ArrayList)lstLocations.SelectedObjects;
            foreach (EncounterZoneLocation loc in SLocs.ToArray())
                zone.EncounterLocations.Remove(loc);
            zone.Modified = true;
            RefreshLocationList();
        }

        private void btnAddMap_Click(object sender, EventArgs e)
        {
            IExtZone zone = (IExtZone)worldmap.GetSelectedZone();
            frmLocation location = new frmLocation(zone.EncounterLocations);
            location.ShowDialog();
            if (location.Locations.Count == 0)
                return;

            if (zone.EncounterLocations == null)
                zone.EncounterLocations = new List<EncounterZoneLocation>();

            zone.EncounterLocations.AddRange(location.Locations);
            zone.Modified = true;
            RefreshLocationList();
        }

        private void RefreshFlagsList()
        {
            IExtZone zone = (IExtZone)worldmap.GetSelectedZone();
            lstFlags.Items.Clear();
            if (zone.Flags != null)
            {
                lstFlags.Items.AddRange(zone.Flags.ToArray());
            }
        }

        private void RefreshGroupList()
        {
            IExtZone zone = (IExtZone)worldmap.GetSelectedZone();
            lstGroups.ClearObjects();
            if (zone.EncounterGroups != null)
            {
                lstGroups.AddObjects(zone.EncounterGroups);
                //zone.Modified = true;
            }

            
            //fastObjectListView1.ClearObjects();
            //if (zone.EncounterGroups != null)
            //    fastObjectListView1.AddObjects(zone.EncounterGroups);
            
        }

        private void RefreshLocationList()
        {
            IExtZone zone = (IExtZone)worldmap.GetSelectedZone();
            lstLocations.ClearObjects();
            if(zone.EncounterLocations != null)
                lstLocations.AddObjects(zone.EncounterLocations);
            numericDifficulty.Value = zone.Difficulty;
        }

        private void lstGroups_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            EncounterGroup group = new EncounterGroup();
            group.Name = e.Item.Text;
            group.Quantity = Int32.Parse(e.Item.SubItems[1].Text);
            SelectedGroup = group;
        }

        private void copyingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsCopying.ShowDialog();
            ICopyParams = SettingsCopying.ICopyObj;
        }

        private void toolBtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolbtnClone_Click(object sender, EventArgs e)
        {
            HandleToolButtonClick((ToolStripButton)sender);

            IZone zone = worldmap.GetSelectedZone();
            if (zone == null)
            {
                Message.Show("No zone selected." + Environment.NewLine + "You must select a zone to clone from.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolbtnClone.Checked = false;
                return;
            }

            if (!toolbtnClone.Checked)
            {
                worldmap.ClearAllBrushed();
                pctWorldMap.Refresh();
            }
            else
            {
                PaintZone = zone.Clone();
                PaintZone.Brushed = true;
            }
        }

        private void toolbtnErase_Click(object sender, EventArgs e)
        {
            HandleToolButtonClick((ToolStripButton)sender);

            if (toolbtnErase.Checked)
            {
                if (!OpenBrushOptions(false))
                    toolbtnErase.Checked = false;
            }
            else
            {
                worldmap.ClearAllBrushed();
                pctWorldMap.Refresh();
            }
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsGeneral.ShowDialog();
            InitColors();
            pctWorldMap.Refresh();
        }

        private void toolbtnBrush_Click(object sender, EventArgs e)
        {
            HandleToolButtonClick((ToolStripButton)sender);

            if (toolbtnBrush.Checked)
            {
                if (!OpenBrushOptions(true))
                    toolbtnBrush.Checked = false;
            }
            else
            {
                worldmap.ClearAllBrushed();
                pctWorldMap.Refresh();
            }
        }

        private void stringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStringEditor StringEditor = new frmStringEditor();

            StringEditor.ShowDialog();
            if (StringEditor.ChangedStrings)
            {
                AddStringsToZonePropertyControls();
                RefreshZoneProperties();
            }
        }

        private void pctWorldMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Location Loc = worldmap.GetLocation(Display.PixelToGameCoords(e.X), Display.PixelToGameCoords(e.Y));

            if (Loc!=null)
            {
                EditLocation = new frmEditLocation(Loc, worldmap.MapParser, worldmap.LocParser, false);
                EditLocation.ShowDialog();
                pctWorldMap.Refresh();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Directory.GetParent(Assembly.GetExecutingAssembly().Location).ToString());
            Utils.InitLog();
            Utils.Log("Starting in " + Directory.GetParent(Assembly.GetExecutingAssembly().Location).ToString());
            Utils.Log("Loading config");
            FOCommon.Utils.InitLog(".\\FOCommon.log", true);
            Utils.Log(FOCommon.Utils.GetCLRInfo());

            //frmShell frm = new frmShell();
            //frm.ShowDialog();

            LoadUISettings();

            toolStripStatusLabelMouseCoords.Text = "";
            toolStripStatusLabelZoneCoords.Text = "";
            toolStripStatusLabelStatus.Text = "Status: Loading...";
            toolStripStatusLabelMode.Text = "| 2238 mode.";

            InitColors();

            if (Config.ScriptingEnabled)
            {
                Utils.Log("Starting script thread...");
                ScriptThread = new Thread(new ThreadStart(UpdateScripts_Tick));
                ScriptThread.Start();
                //ScriptThread.Start();
            }

            if(Config.AsyncLoading)
                Utils.Log("Loading resources async...");
            else
                Utils.Log("Loading resources sequentially...");

            // Maps / Locations
            if (Config.AsyncLoading)
                bwMaps.RunWorkerAsync();
            else
                bwMaps_DoWork(null, null);

            // Misc gamedata
            if (Config.AsyncLoading)
                bwMisc.RunWorkerAsync();
            else
                bwMisc_DoWork(null, null);

            //frmShell shell = new frmShell();
            //shell.Show();

            LoadWorldMapImage();

            string[] args = Environment.GetCommandLineArgs();
            cmd.ParseCommandline(args);
            if (cmd.NoGUI)
                HideWindow();

            if (Config.ScriptingEnabled && !Config.AsyncLoading)
            {
                InitScriptHost();
            }

            // UI stuff
            if(Config.AsyncLoading)
                bwUI.RunWorkerAsync();
            else
                bwUI_DoWork(null, null);

            

            //this.Size = new System.Drawing.Size(0, 0);
            //this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            //pnlWorldMap.MaximumSize = pctWorldMap.Size;
            //this.MaximumSize = new Size(pctWorldMap.Location.X + pctWorldMap.Width + 50, pctWorldMap.Location.Y + pctWorldMap.Height + 20);
        }

        private void InitScriptHost()
        {
            ScriptManager.InitHost(cmd.Shell, version, worldmap, pctWorldMap);
        }

        private void HideWindow()
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            BeginInvoke(new MethodInvoker(delegate
            {
                Hide();
            }));
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            if (IsFirstPaint)
            {
                Utils.Log("Main form loaded.");
                IsFirstPaint = false;
                if (Config.ScriptingEnabled)
                    Scripting.Host.ScriptHost.main_form_loaded();
            }
        }

        private void bwUI_DoWork(object sender, DoWorkEventArgs e)
        {

                List<Item> Items = ItemPid.GetItems();
                this.BeginInvoke((MethodInvoker)delegate
            {
                AddStringsToZonePropertyControls();
                foreach (Item Item in Items)
                    cmbShowItemZones.Items.Add(Item.Define);

                cmbShowItemZones.Sorted = true;
                //ChangeEnableStateOfZonePropertyControls(false);
            });
        }

        private void bwMaps_DoWork(object sender, DoWorkEventArgs e)
        {
                DefineParser WorldMapHeaderData = new DefineParser();
                if (!WorldMapHeaderData.ReadDefines(@Config.PathWorldmapHeader))
                    Utils.HandleParseError(WorldMapHeaderData.Error, @Config.PathWorldmapHeader);

                worldmap = new WorldMap(Config.PathWorldMap, Config.PathWorldMapCompiled, new WorldMapFormat(WorldMapHeaderData));
                worldmap.Parse();
                
                //worldmap = new WorldMap("worldmap_sdk.fowm", "worldmap_sdk.focwm", new SDKWorldMapFormat(WorldMapHeaderData));
                bwMaps.ReportProgress(52);
                this.BeginInvoke((MethodInvoker)delegate
                {
                    pctWorldMap.Refresh();
                    locationEditorToolStripMenuItem.Enabled = true;
                    mapdataEditorToolStripMenuItem.Enabled = true;
                });
                Utils.Log("Loaded maps and location data.");
                bwMaps.ReportProgress(100);
            
        }

        private void bwMisc_DoWork(object sender, DoWorkEventArgs e)
        {
            //this.Invoke((MethodInvoker)delegate { Utils.Log("Init colors"); });
               
            this.BeginInvoke((MethodInvoker)delegate { Utils.Log("Loading ITEMPID.H"); });
            ItemPid.Init();
            LoadParamDefines();
            bwMisc.ReportProgress(50);
            LoadProtoManager();
            bwMisc.ReportProgress(100);

            this.BeginInvoke((MethodInvoker)delegate { Utils.Log("Loaded game data."); });
        }

        private void LoadProtoManager()
        {
            while (worldmap == null || worldmap.FODLGParser==null || !worldmap.FODLGParser.IsParsed)
                Thread.Sleep(1);
            ProtoManager.Init(Config.BaseProtoFiles.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries),
                Config.ProtoFiles.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries),
                worldmap.FODLGParser);
            ProtoManager.Load();
        }

        private void LoadParamDefines()
        {
            ParamsDefines.Init(Config.PathParamNames);
            Utils.Log("Loading param defines.");
            ParamsDefines.Parse();
        }

        private void mapdataEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapDataEditor = new frmMapEditor(worldmap.MapParser);
            MapDataEditor.ShowDialog();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog FileDialog = new SaveFileDialog();
            FileDialog.RestoreDirectory = true;
            FileDialog.Filter = "JPG Image (*.jpg)|*.jpg";
            if (FileDialog.ShowDialog() != DialogResult.Cancel)
            {
                Bitmap bitmap = new Bitmap(pctWorldMap.Image);
                pctWorldMap.DrawToBitmap(bitmap, new Rectangle(0,0, pctWorldMap.Width, pctWorldMap.Height));
                bitmap.Save(FileDialog.FileName);
            }
        }

        private void btnAddFlag_Click(object sender, EventArgs e)
        {
            frmAddFlag flagform = new frmAddFlag();
            flagform.ShowDialog();
            if (flagform.Flags.Count == 0)
                return;

            lstFlags.BeginUpdate();
            lstFlags.Items.AddRange(flagform.Flags.ToArray());
            lstFlags.EndUpdate();

            List<String> flags = new List<String>();
            foreach (object i in lstFlags.Items)
                flags.Add(i.ToString());

            Zone zone = (Zone)worldmap.GetSelectedZone();
            if (zone == null)
                return;
            zone.Flags = flags;
        }

        private void btnRemoveFlag_Click(object sender, EventArgs e)
        {
            lstFlags.BeginUpdate();
            while (lstFlags.SelectedItems.Count > 0)
            {
                lstFlags.Items.Remove(lstFlags.SelectedItem);
            }
            lstFlags.EndUpdate();

            List<String> flags = new List<String>();
            foreach (object i in lstFlags.Items)
                flags.Add(i.ToString());

            Zone zone = (Zone)worldmap.GetSelectedZone();
            zone.Flags = flags;
        }

        private void RefreshZoneFilter(object sender, EventArgs e)
        {
            pctWorldMap.Refresh();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation.Locations = worldmap.GetLocations();
            AddLocation.ShowDialog();
        }

        private void encounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<IZone> IZones = worldmap.GetZones();
            //List<Zone> Zones = (List<Zone>)IZones;

            frmEncounterGroupEditor groupeditor = new frmEncounterGroupEditor(IZones, worldmap.FOGameParser, worldmap.GroupParser, 
                                    worldmap.DialogListParser, worldmap.FOOBJParser, worldmap.FODLGParser, worldmap.DefineParser);
            groupeditor.ShowDialog();
            cmbShowGroup.Items.Clear();
            cmbShowGroup.Items.AddRange(EditorData.Groups.ToArray());
            GC.Collect();
            worldmap.RefreshZoneGroups();
        }

        private void locationEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocationEditor locationeditor = new frmLocationEditor(worldmap.GetLocations(), worldmap.MapParser, worldmap.LocParser);
            locationeditor.ShowDialog();
            pctWorldMap.Refresh();
        }

        private void scriptlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScriptList scriptlist = new frmScriptList(worldmap.ScriptListParser.GetScripts());
            scriptlist.ShowDialog();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            Zone zone = (Zone)worldmap.GetSelectedZone();

            ArrayList SGroups = (ArrayList)lstGroups.SelectedObjects;
            foreach (EncounterZoneGroup group in SGroups.ToArray())
            {
                for (int i = 0, j = zone.EncounterGroups.Count; i < j; )
                {
                    if (group.Name == zone.EncounterGroups[i].Name)
                    {
                        zone.EncounterGroups.RemoveAt(i);
                        j--;
                        continue;
                    }
                    i++;
                }
            }
            zone.Modified = true;
            RefreshGroupList();
        }

        private void chkHideEncounterProperties_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideZoneProperties.Checked)
            {
                checkBox1.Checked = false;
                tabZoneProperties.Visible = false;
                grpSelectedZone.Height = 120;
                tabControl1.Location = new Point(5,180);
                //this.MinimumSize = new Size(this.MinimumSize.Width, 527);
            }
            else
            {
                grpSelectedZone.Height = 478;
                tabZoneProperties.Visible = true;
                tabControl1.Location = new Point(5,536);
                //this.MinimumSize = new Size(this.MinimumSize.Width, 877);
            }

        }

        private void crittersProtoEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ProtoManager.Initialized || !ParamsDefines.Initialized)
            {
                Message.Show("Proto Editor not initialized.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCritterProtoList form = new frmCritterProtoList();
            form.ShowDialog();
        }

        private void lstGroups_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EncounterZoneGroup group = (EncounterZoneGroup)lstGroups.SelectedObject;
            if (group == null)
                return;

            frmEditGroup EditGroup = new frmEditGroup();
            EditGroup.group = group;
            EditGroup.ShowDialog();
            RefreshGroupList();
        }

        private void specialEncounterEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message.Show("Not available yet.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void aboutWorldEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout(version);

            About.ShowDialog();
        }

        private void bwMisc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Message.Show("An exception occured:" + Environment.NewLine + e.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                Environment.Exit(0);
            }
        }

        private void bwMaps_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Message.Show("An exception occured:" + Environment.NewLine + e.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                Environment.Exit(0);
            }
            if (Config.ScriptingEnabled)
            {
                InitScriptHost();
            }
        }

        private void bwUI_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Message.Show("An exception occured:" + Environment.NewLine + e.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                Environment.Exit(0);
            }
        }

        private void UpdateScripts_Tick()
        {
            if (!ScriptManager.AnyUpdateExtensions())
                return;

            while(true)
            {
                ScriptManager.UpdateScripts_Tick();
                Thread.Sleep(1);
            }
        }

        private void UpdateLoadProgress()
        {
            toolStripProgressBarLoading.Value = (ProgressLoadMaps!=0?ProgressLoadMaps/ 2:0 ) + 
                                                    (ProgressLoadMisc!=0?ProgressLoadMisc/ 2:0 );
            if (toolStripProgressBarLoading.Value == 100)
            {
                SetStatus("Ready");
            }
                
        }

        private void bwMaps_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressLoadMaps=e.ProgressPercentage;
            UpdateLoadProgress();
        }

        private void bwMisc_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressLoadMisc = e.ProgressPercentage;
            UpdateLoadProgress();
        }

        private void SetStatus(string Text)
        {
            toolStripStatusLabelStatus.Text = "Status: "+Text;
        }

        private void generateDefinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateDefines GenDefines = new frmGenerateDefines(worldmap);
            GenDefines.ShowDialog();
            //worldmap.GenerateMapsDefines();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ScriptHost.Reload();
        }

        private void loadedExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScriptsLoaded frmLoaded = new frmScriptsLoaded(Scripting.Host.ScriptHost);
            frmLoaded.ShowDialog();
        }

        private void configureExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtensionList frm = new frmExtensionList(Config.PathEditorScript);
            frm.ShowDialog();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display.ZoomIn(2f);
            Bitmap Bitmap = new Bitmap(Config.PathWorldMapPic);
            pctWorldMap.Image = Bitmap.ScaleByPercent(Display.WorldmapScale);
            pctWorldMap.Refresh();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display.ZoomOut(2f);
            Bitmap Bitmap = new Bitmap(Config.PathWorldMapPic);
            pctWorldMap.Image = Bitmap.ScaleByPercent(Display.WorldmapScale);
            pctWorldMap.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // ukrywanie okna filtrów
            {
                chkHideZoneProperties.Checked = false;

                tabControl1.Visible = false;                
                grpSelectedZone.Height = 878;
                tabZoneProperties.Height = 754;
                lstGroups.Height = 339;
                btnAddGroup.Location = new Point(2, 364);
                btnRemoveGroup.Location = new Point(189, 364);

                lstLocations.Height = 287;
                label7.Location = new Point(1, 390);
                lstLocations.Location = new Point(3, 406);
                btnAddLocation.Location = new Point(1, 698);
                btnRemoveLocation.Location = new Point(189, 698);
            }
            else  //normalny układ kontrolek
            {
                tabControl1.Visible = true;
                grpSelectedZone.Height = 478;
                tabZoneProperties.Height = 354;
                lstGroups.Height = 139;
                btnAddGroup.Location = new Point(2, 164);
                btnRemoveGroup.Location = new Point(189, 164);

                lstLocations.Height = 87;
                label7.Location = new Point(1, 190);
                lstLocations.Location = new Point(3, 206);
                btnAddLocation.Location = new Point(1, 298);
                btnRemoveLocation.Location = new Point(189, 298);
            }

            
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<IZone> IZones = worldmap.GetZones();
            //List<Zone> Zones = (List<Zone>)IZones;

            frmEncounterGroupEditor groupeditor = new frmEncounterGroupEditor(IZones, worldmap.FOGameParser, worldmap.GroupParser,
                                    worldmap.DialogListParser, worldmap.FOOBJParser, worldmap.FODLGParser, worldmap.DefineParser);
            groupeditor.ShowDialog();
            cmbShowGroup.Items.Clear();
            cmbShowGroup.Items.AddRange(EditorData.Groups.ToArray());
            GC.Collect();
            worldmap.RefreshZoneGroups();
        }
    }
}
