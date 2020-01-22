namespace WorldEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlWorldMap = new System.Windows.Forms.Panel();
            this.pctWorldMap = new System.Windows.Forms.PictureBox();
            this.grpSelectedZone = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkHideZoneProperties = new System.Windows.Forms.CheckBox();
            this.tabZoneProperties = new System.Windows.Forms.TabControl();
            this.tabPageEncounters = new System.Windows.Forms.TabPage();
            this.lstLocations = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lstGroups = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageFlags = new System.Windows.Forms.TabPage();
            this.btnRemoveFlag = new System.Windows.Forms.Button();
            this.btnAddFlag = new System.Windows.Forms.Button();
            this.lstFlags = new System.Windows.Forms.ListBox();
            this.lblZoneFlags = new System.Windows.Forms.Label();
            this.numericDifficulty = new System.Windows.Forms.NumericUpDown();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbTerrain = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedZoneCoords = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crittersProtoEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialEncounterEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapdataEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDefinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadedExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWorldEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolbtnBrush = new System.Windows.Forms.ToolStripButton();
            this.toolbtnErase = new System.Windows.Forms.ToolStripButton();
            this.toolbtnClone = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.lblShowChance = new System.Windows.Forms.Label();
            this.cmbShowChance = new System.Windows.Forms.ComboBox();
            this.chkShowChance = new System.Windows.Forms.CheckBox();
            this.lblEncounterTable = new System.Windows.Forms.Label();
            this.chkShowTable = new System.Windows.Forms.CheckBox();
            this.cmbShowTable = new System.Windows.Forms.ComboBox();
            this.chkShowFlag = new System.Windows.Forms.CheckBox();
            this.cmbShowFlag = new System.Windows.Forms.ComboBox();
            this.lblFlag = new System.Windows.Forms.Label();
            this.chkShowNoLocation = new System.Windows.Forms.CheckBox();
            this.chkShowLocation = new System.Windows.Forms.CheckBox();
            this.cmbShowLocation = new System.Windows.Forms.ComboBox();
            this.lblEncounterLocation = new System.Windows.Forms.Label();
            this.chkShowNoEncounter = new System.Windows.Forms.CheckBox();
            this.chkShowGroup = new System.Windows.Forms.CheckBox();
            this.cmbShowGroup = new System.Windows.Forms.ComboBox();
            this.lblEncounterGroup = new System.Windows.Forms.Label();
            this.chkShowTerrain = new System.Windows.Forms.CheckBox();
            this.cmbShowTerrain = new System.Windows.Forms.ComboBox();
            this.lblTerrain = new System.Windows.Forms.Label();
            this.chkShowModified = new System.Windows.Forms.CheckBox();
            this.chkShowImplemented = new System.Windows.Forms.CheckBox();
            this.chkShowZones = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkShowNumbersDiff = new System.Windows.Forms.CheckBox();
            this.cmbDifficultyMode = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numDifficultyOnlyAbove = new System.Windows.Forms.NumericUpDown();
            this.chkShowDifficultyMap = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnGroupQuantityNight = new System.Windows.Forms.RadioButton();
            this.rbtnGroupQuantityDay = new System.Windows.Forms.RadioButton();
            this.rbtnGroupQuantityAnyTime = new System.Windows.Forms.RadioButton();
            this.chkShowGroupQuantities = new System.Windows.Forms.CheckBox();
            this.chkShowGroupDensity = new System.Windows.Forms.CheckBox();
            this.chkShowNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkShowItemZonesAmount = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbShowItemZones = new System.Windows.Forms.ComboBox();
            this.chkShowItemZones = new System.Windows.Forms.CheckBox();
            this.bwMaps = new System.ComponentModel.BackgroundWorker();
            this.bwMisc = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslblMouseCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarLoading = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMouseCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGameCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelZoneCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.bwUI = new System.ComponentModel.BackgroundWorker();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlWorldMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWorldMap)).BeginInit();
            this.grpSelectedZone.SuspendLayout();
            this.tabZoneProperties.SuspendLayout();
            this.tabPageEncounters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstGroups)).BeginInit();
            this.tabPageFlags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFilters.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficultyOnlyAbove)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorldMap
            // 
            this.pnlWorldMap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlWorldMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorldMap.AutoScroll = true;
            this.pnlWorldMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlWorldMap.Controls.Add(this.pctWorldMap);
            this.pnlWorldMap.Location = new System.Drawing.Point(337, 52);
            this.pnlWorldMap.Name = "pnlWorldMap";
            this.pnlWorldMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlWorldMap.Size = new System.Drawing.Size(940, 676);
            this.pnlWorldMap.TabIndex = 2;
            // 
            // pctWorldMap
            // 
            this.pctWorldMap.Location = new System.Drawing.Point(0, 3);
            this.pctWorldMap.Name = "pctWorldMap";
            this.pctWorldMap.Size = new System.Drawing.Size(250, 250);
            this.pctWorldMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctWorldMap.TabIndex = 3;
            this.pctWorldMap.TabStop = false;
            this.pctWorldMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pctWorldMap_Paint);
            this.pctWorldMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctWorldMap_MouseClick);
            this.pctWorldMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pctWorldMap_MouseDoubleClick);
            this.pctWorldMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctWorldMap_MouseMove);
            // 
            // grpSelectedZone
            // 
            this.grpSelectedZone.Controls.Add(this.checkBox2);
            this.grpSelectedZone.Controls.Add(this.checkBox1);
            this.grpSelectedZone.Controls.Add(this.chkHideZoneProperties);
            this.grpSelectedZone.Controls.Add(this.tabZoneProperties);
            this.grpSelectedZone.Controls.Add(this.numericDifficulty);
            this.grpSelectedZone.Controls.Add(this.lblDifficulty);
            this.grpSelectedZone.Controls.Add(this.cmbTerrain);
            this.grpSelectedZone.Controls.Add(this.label3);
            this.grpSelectedZone.Controls.Add(this.lblSelectedZoneCoords);
            this.grpSelectedZone.Controls.Add(this.lblTable);
            this.grpSelectedZone.Location = new System.Drawing.Point(4, 52);
            this.grpSelectedZone.Name = "grpSelectedZone";
            this.grpSelectedZone.Size = new System.Drawing.Size(327, 478);
            this.grpSelectedZone.TabIndex = 15;
            this.grpSelectedZone.TabStop = false;
            this.grpSelectedZone.Text = "Selected Zone";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(145, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 19);
            this.checkBox2.TabIndex = 40;
            this.checkBox2.Text = "auto open";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(239, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Hide Filters";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkHideZoneProperties
            // 
            this.chkHideZoneProperties.AutoSize = true;
            this.chkHideZoneProperties.Location = new System.Drawing.Point(6, 94);
            this.chkHideZoneProperties.Name = "chkHideZoneProperties";
            this.chkHideZoneProperties.Size = new System.Drawing.Size(126, 17);
            this.chkHideZoneProperties.TabIndex = 52;
            this.chkHideZoneProperties.Text = "Hide Zone Properties";
            this.chkHideZoneProperties.UseVisualStyleBackColor = true;
            this.chkHideZoneProperties.CheckedChanged += new System.EventHandler(this.chkHideEncounterProperties_CheckedChanged);
            // 
            // tabZoneProperties
            // 
            this.tabZoneProperties.Controls.Add(this.tabPageEncounters);
            this.tabZoneProperties.Controls.Add(this.tabPageFlags);
            this.tabZoneProperties.Location = new System.Drawing.Point(6, 117);
            this.tabZoneProperties.Name = "tabZoneProperties";
            this.tabZoneProperties.SelectedIndex = 0;
            this.tabZoneProperties.Size = new System.Drawing.Size(315, 354);
            this.tabZoneProperties.TabIndex = 26;
            // 
            // tabPageEncounters
            // 
            this.tabPageEncounters.Controls.Add(this.lstLocations);
            this.tabPageEncounters.Controls.Add(this.lstGroups);
            this.tabPageEncounters.Controls.Add(this.label6);
            this.tabPageEncounters.Controls.Add(this.btnRemoveLocation);
            this.tabPageEncounters.Controls.Add(this.btnAddLocation);
            this.tabPageEncounters.Controls.Add(this.btnRemoveGroup);
            this.tabPageEncounters.Controls.Add(this.btnAddGroup);
            this.tabPageEncounters.Controls.Add(this.label7);
            this.tabPageEncounters.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncounters.Name = "tabPageEncounters";
            this.tabPageEncounters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncounters.Size = new System.Drawing.Size(307, 328);
            this.tabPageEncounters.TabIndex = 0;
            this.tabPageEncounters.Text = "Encounters";
            this.tabPageEncounters.UseVisualStyleBackColor = true;
            // 
            // lstLocations
            // 
            this.lstLocations.AllColumns.Add(this.olvColumn6);
            this.lstLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6});
            this.lstLocations.FullRowSelect = true;
            this.lstLocations.Location = new System.Drawing.Point(6, 206);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.ShowGroups = false;
            this.lstLocations.Size = new System.Drawing.Size(295, 87);
            this.lstLocations.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstLocations.TabIndex = 39;
            this.lstLocations.UseCompatibleStateImageBehavior = false;
            this.lstLocations.View = System.Windows.Forms.View.Details;
            this.lstLocations.VirtualMode = true;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Name";
            this.olvColumn6.Text = "Name";
            this.olvColumn6.Width = 290;
            // 
            // lstGroups
            // 
            this.lstGroups.AllColumns.Add(this.olvColumn12);
            this.lstGroups.AllColumns.Add(this.olvColumn5);
            this.lstGroups.AllColumns.Add(this.olvColumn1);
            this.lstGroups.AllColumns.Add(this.olvColumn2);
            this.lstGroups.AllowColumnReorder = true;
            this.lstGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn12,
            this.olvColumn5});
            this.lstGroups.FullRowSelect = true;
            this.lstGroups.Location = new System.Drawing.Point(6, 19);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.SelectAllOnControlA = false;
            this.lstGroups.ShowGroups = false;
            this.lstGroups.Size = new System.Drawing.Size(298, 139);
            this.lstGroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstGroups.TabIndex = 37;
            this.lstGroups.UseCompatibleStateImageBehavior = false;
            this.lstGroups.View = System.Windows.Forms.View.Details;
            this.lstGroups.VirtualMode = true;
            this.lstGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstGroups_MouseDoubleClick);
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "Name";
            this.olvColumn12.Text = "Name";
            this.olvColumn12.Width = 233;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Quantity";
            this.olvColumn5.Text = "Quantity";
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "QuantityDay";
            this.olvColumn1.DisplayIndex = 2;
            this.olvColumn1.IsVisible = false;
            this.olvColumn1.Text = "Quantity Day";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "QuantityNight";
            this.olvColumn2.DisplayIndex = 3;
            this.olvColumn2.IsVisible = false;
            this.olvColumn2.Text = "Quantity Night";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Encounter Groups:";
            // 
            // btnRemoveLocation
            // 
            this.btnRemoveLocation.Location = new System.Drawing.Point(189, 298);
            this.btnRemoveLocation.Name = "btnRemoveLocation";
            this.btnRemoveLocation.Size = new System.Drawing.Size(112, 23);
            this.btnRemoveLocation.TabIndex = 36;
            this.btnRemoveLocation.Text = "Remove Location(s)";
            this.btnRemoveLocation.UseVisualStyleBackColor = true;
            this.btnRemoveLocation.Click += new System.EventHandler(this.btnRemoveMap_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(6, 298);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(108, 23);
            this.btnAddLocation.TabIndex = 35;
            this.btnAddLocation.Text = "Add Location(s)";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddMap_Click);
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Location = new System.Drawing.Point(189, 164);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(112, 23);
            this.btnRemoveGroup.TabIndex = 34;
            this.btnRemoveGroup.Text = "Remove Group(s)";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(7, 164);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(107, 23);
            this.btnAddGroup.TabIndex = 30;
            this.btnAddGroup.Text = "Add Group(s)";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Encounter Locations:";
            // 
            // tabPageFlags
            // 
            this.tabPageFlags.Controls.Add(this.btnRemoveFlag);
            this.tabPageFlags.Controls.Add(this.btnAddFlag);
            this.tabPageFlags.Controls.Add(this.lstFlags);
            this.tabPageFlags.Controls.Add(this.lblZoneFlags);
            this.tabPageFlags.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlags.Name = "tabPageFlags";
            this.tabPageFlags.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlags.Size = new System.Drawing.Size(307, 328);
            this.tabPageFlags.TabIndex = 1;
            this.tabPageFlags.Text = "Flags";
            this.tabPageFlags.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFlag
            // 
            this.btnRemoveFlag.Location = new System.Drawing.Point(199, 300);
            this.btnRemoveFlag.Name = "btnRemoveFlag";
            this.btnRemoveFlag.Size = new System.Drawing.Size(102, 23);
            this.btnRemoveFlag.TabIndex = 40;
            this.btnRemoveFlag.Text = "Remove Flag(s)";
            this.btnRemoveFlag.UseVisualStyleBackColor = true;
            this.btnRemoveFlag.Click += new System.EventHandler(this.btnRemoveFlag_Click);
            // 
            // btnAddFlag
            // 
            this.btnAddFlag.Location = new System.Drawing.Point(3, 300);
            this.btnAddFlag.Name = "btnAddFlag";
            this.btnAddFlag.Size = new System.Drawing.Size(108, 23);
            this.btnAddFlag.TabIndex = 39;
            this.btnAddFlag.Text = "Add Flag(s)";
            this.btnAddFlag.UseVisualStyleBackColor = true;
            this.btnAddFlag.Click += new System.EventHandler(this.btnAddFlag_Click);
            // 
            // lstFlags
            // 
            this.lstFlags.FormattingEnabled = true;
            this.lstFlags.Location = new System.Drawing.Point(3, 19);
            this.lstFlags.Name = "lstFlags";
            this.lstFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFlags.Size = new System.Drawing.Size(298, 277);
            this.lstFlags.TabIndex = 38;
            // 
            // lblZoneFlags
            // 
            this.lblZoneFlags.AutoSize = true;
            this.lblZoneFlags.Location = new System.Drawing.Point(3, 3);
            this.lblZoneFlags.Name = "lblZoneFlags";
            this.lblZoneFlags.Size = new System.Drawing.Size(63, 13);
            this.lblZoneFlags.TabIndex = 37;
            this.lblZoneFlags.Text = "Zone Flags:";
            // 
            // numericDifficulty
            // 
            this.numericDifficulty.Location = new System.Drawing.Point(178, 62);
            this.numericDifficulty.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericDifficulty.Name = "numericDifficulty";
            this.numericDifficulty.Size = new System.Drawing.Size(139, 20);
            this.numericDifficulty.TabIndex = 22;
            this.numericDifficulty.ValueChanged += new System.EventHandler(this.numericDifficulty_ValueChanged);
            this.numericDifficulty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericDifficulty_KeyUp);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(8, 64);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblDifficulty.TabIndex = 9;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // cmbTerrain
            // 
            this.cmbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerrain.FormattingEnabled = true;
            this.cmbTerrain.Location = new System.Drawing.Point(178, 35);
            this.cmbTerrain.Name = "cmbTerrain";
            this.cmbTerrain.Size = new System.Drawing.Size(139, 21);
            this.cmbTerrain.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Terrain Type:";
            // 
            // lblSelectedZoneCoords
            // 
            this.lblSelectedZoneCoords.AutoSize = true;
            this.lblSelectedZoneCoords.Location = new System.Drawing.Point(7, 16);
            this.lblSelectedZoneCoords.Name = "lblSelectedZoneCoords";
            this.lblSelectedZoneCoords.Size = new System.Drawing.Size(66, 13);
            this.lblSelectedZoneCoords.TabIndex = 0;
            this.lblSelectedZoneCoords.Text = "Coordinates:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(8, 118);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(89, 13);
            this.lblTable.TabIndex = 56;
            this.lblTable.Text = "Encounter Table:";
            this.lblTable.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.worldmapToolStripMenuItem,
            this.scriptingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.copyingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generalToolStripMenuItem.Image")));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // copyingToolStripMenuItem
            // 
            this.copyingToolStripMenuItem.Name = "copyingToolStripMenuItem";
            this.copyingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.copyingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyingToolStripMenuItem.Text = "Cloning";
            this.copyingToolStripMenuItem.Click += new System.EventHandler(this.copyingToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crittersProtoEditorToolStripMenuItem,
            this.encounterToolStripMenuItem,
            this.specialEncounterEditorToolStripMenuItem,
            this.mapdataEditorToolStripMenuItem,
            this.locationEditorToolStripMenuItem,
            this.stringsToolStripMenuItem,
            this.generateDefinesToolStripMenuItem,
            this.scriptlistToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // crittersProtoEditorToolStripMenuItem
            // 
            this.crittersProtoEditorToolStripMenuItem.Name = "crittersProtoEditorToolStripMenuItem";
            this.crittersProtoEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.crittersProtoEditorToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.crittersProtoEditorToolStripMenuItem.Text = "Critters Proto Editor";
            this.crittersProtoEditorToolStripMenuItem.Click += new System.EventHandler(this.crittersProtoEditorToolStripMenuItem_Click);
            // 
            // encounterToolStripMenuItem
            // 
            this.encounterToolStripMenuItem.Name = "encounterToolStripMenuItem";
            this.encounterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.encounterToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.encounterToolStripMenuItem.Text = "Encounter Group Editor";
            this.encounterToolStripMenuItem.Click += new System.EventHandler(this.encounterToolStripMenuItem_Click);
            // 
            // specialEncounterEditorToolStripMenuItem
            // 
            this.specialEncounterEditorToolStripMenuItem.Name = "specialEncounterEditorToolStripMenuItem";
            this.specialEncounterEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.specialEncounterEditorToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.specialEncounterEditorToolStripMenuItem.Text = "Special Encounter Editor";
            this.specialEncounterEditorToolStripMenuItem.Click += new System.EventHandler(this.specialEncounterEditorToolStripMenuItem_Click);
            // 
            // mapdataEditorToolStripMenuItem
            // 
            this.mapdataEditorToolStripMenuItem.Enabled = false;
            this.mapdataEditorToolStripMenuItem.Name = "mapdataEditorToolStripMenuItem";
            this.mapdataEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mapdataEditorToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.mapdataEditorToolStripMenuItem.Text = "Mapdata Editor";
            this.mapdataEditorToolStripMenuItem.Click += new System.EventHandler(this.mapdataEditorToolStripMenuItem_Click);
            // 
            // locationEditorToolStripMenuItem
            // 
            this.locationEditorToolStripMenuItem.Enabled = false;
            this.locationEditorToolStripMenuItem.Name = "locationEditorToolStripMenuItem";
            this.locationEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.locationEditorToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.locationEditorToolStripMenuItem.Text = "Location Editor";
            this.locationEditorToolStripMenuItem.Click += new System.EventHandler(this.locationEditorToolStripMenuItem_Click);
            // 
            // stringsToolStripMenuItem
            // 
            this.stringsToolStripMenuItem.Name = "stringsToolStripMenuItem";
            this.stringsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.stringsToolStripMenuItem.Text = "String Editor";
            this.stringsToolStripMenuItem.Visible = false;
            this.stringsToolStripMenuItem.Click += new System.EventHandler(this.stringsToolStripMenuItem_Click);
            // 
            // generateDefinesToolStripMenuItem
            // 
            this.generateDefinesToolStripMenuItem.Name = "generateDefinesToolStripMenuItem";
            this.generateDefinesToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.generateDefinesToolStripMenuItem.Text = "Generate Defines";
            this.generateDefinesToolStripMenuItem.Click += new System.EventHandler(this.generateDefinesToolStripMenuItem_Click);
            // 
            // scriptlistToolStripMenuItem
            // 
            this.scriptlistToolStripMenuItem.Name = "scriptlistToolStripMenuItem";
            this.scriptlistToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.scriptlistToolStripMenuItem.Text = "Scriptlist";
            this.scriptlistToolStripMenuItem.Click += new System.EventHandler(this.scriptlistToolStripMenuItem_Click);
            // 
            // worldmapToolStripMenuItem
            // 
            this.worldmapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem,
            this.editFlagsToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.setImageToolStripMenuItem});
            this.worldmapToolStripMenuItem.Name = "worldmapToolStripMenuItem";
            this.worldmapToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.worldmapToolStripMenuItem.Text = "Worldmap";
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // editFlagsToolStripMenuItem
            // 
            this.editFlagsToolStripMenuItem.Enabled = false;
            this.editFlagsToolStripMenuItem.Name = "editFlagsToolStripMenuItem";
            this.editFlagsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editFlagsToolStripMenuItem.Text = "Edit Flags";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // setImageToolStripMenuItem
            // 
            this.setImageToolStripMenuItem.Name = "setImageToolStripMenuItem";
            this.setImageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.setImageToolStripMenuItem.Text = "Set Image";
            // 
            // scriptingToolStripMenuItem
            // 
            this.scriptingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadedExtensionsToolStripMenuItem,
            this.configureExtensionsToolStripMenuItem});
            this.scriptingToolStripMenuItem.Name = "scriptingToolStripMenuItem";
            this.scriptingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.scriptingToolStripMenuItem.Text = "Extensions";
            // 
            // loadedExtensionsToolStripMenuItem
            // 
            this.loadedExtensionsToolStripMenuItem.Name = "loadedExtensionsToolStripMenuItem";
            this.loadedExtensionsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.loadedExtensionsToolStripMenuItem.Text = "Loaded Extensions";
            this.loadedExtensionsToolStripMenuItem.Click += new System.EventHandler(this.loadedExtensionsToolStripMenuItem_Click);
            // 
            // configureExtensionsToolStripMenuItem
            // 
            this.configureExtensionsToolStripMenuItem.Name = "configureExtensionsToolStripMenuItem";
            this.configureExtensionsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.configureExtensionsToolStripMenuItem.Text = "Configure";
            this.configureExtensionsToolStripMenuItem.Click += new System.EventHandler(this.configureExtensionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutWorldEditorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutWorldEditorToolStripMenuItem
            // 
            this.aboutWorldEditorToolStripMenuItem.Name = "aboutWorldEditorToolStripMenuItem";
            this.aboutWorldEditorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutWorldEditorToolStripMenuItem.Text = "About WorldEditor";
            this.aboutWorldEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutWorldEditorToolStripMenuItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.AllowMerge = false;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSave,
            this.toolbtnBrush,
            this.toolbtnErase,
            this.toolbtnClone,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolBar.Size = new System.Drawing.Size(1289, 25);
            this.toolBar.TabIndex = 25;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolBtnSave
            // 
            this.toolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSave.Image")));
            this.toolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSave.Name = "toolBtnSave";
            this.toolBtnSave.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSave.Text = "Save WorldMap";
            this.toolBtnSave.Click += new System.EventHandler(this.toolBtnSave_Click);
            // 
            // toolbtnBrush
            // 
            this.toolbtnBrush.CheckOnClick = true;
            this.toolbtnBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnBrush.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnBrush.Image")));
            this.toolbtnBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnBrush.Name = "toolbtnBrush";
            this.toolbtnBrush.Size = new System.Drawing.Size(23, 22);
            this.toolbtnBrush.Text = "Brush Mode";
            this.toolbtnBrush.Click += new System.EventHandler(this.toolbtnBrush_Click);
            // 
            // toolbtnErase
            // 
            this.toolbtnErase.CheckOnClick = true;
            this.toolbtnErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnErase.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnErase.Image")));
            this.toolbtnErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnErase.Name = "toolbtnErase";
            this.toolbtnErase.Size = new System.Drawing.Size(23, 22);
            this.toolbtnErase.Text = "Eraser Mode";
            this.toolbtnErase.Click += new System.EventHandler(this.toolbtnErase_Click);
            // 
            // toolbtnClone
            // 
            this.toolbtnClone.CheckOnClick = true;
            this.toolbtnClone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnClone.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnClone.Image")));
            this.toolbtnClone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnClone.Name = "toolbtnClone";
            this.toolbtnClone.Size = new System.Drawing.Size(23, 22);
            this.toolbtnClone.Text = "Clone mode";
            this.toolbtnClone.Click += new System.EventHandler(this.toolbtnClone_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFilters);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 536);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 285);
            this.tabControl1.TabIndex = 24;
            // 
            // tabFilters
            // 
            this.tabFilters.Controls.Add(this.lblShowChance);
            this.tabFilters.Controls.Add(this.cmbShowChance);
            this.tabFilters.Controls.Add(this.chkShowChance);
            this.tabFilters.Controls.Add(this.lblEncounterTable);
            this.tabFilters.Controls.Add(this.chkShowTable);
            this.tabFilters.Controls.Add(this.cmbShowTable);
            this.tabFilters.Controls.Add(this.chkShowFlag);
            this.tabFilters.Controls.Add(this.cmbShowFlag);
            this.tabFilters.Controls.Add(this.lblFlag);
            this.tabFilters.Controls.Add(this.chkShowNoLocation);
            this.tabFilters.Controls.Add(this.chkShowLocation);
            this.tabFilters.Controls.Add(this.cmbShowLocation);
            this.tabFilters.Controls.Add(this.lblEncounterLocation);
            this.tabFilters.Controls.Add(this.chkShowNoEncounter);
            this.tabFilters.Controls.Add(this.chkShowGroup);
            this.tabFilters.Controls.Add(this.cmbShowGroup);
            this.tabFilters.Controls.Add(this.lblEncounterGroup);
            this.tabFilters.Controls.Add(this.chkShowTerrain);
            this.tabFilters.Controls.Add(this.cmbShowTerrain);
            this.tabFilters.Controls.Add(this.lblTerrain);
            this.tabFilters.Controls.Add(this.chkShowModified);
            this.tabFilters.Controls.Add(this.chkShowImplemented);
            this.tabFilters.Controls.Add(this.chkShowZones);
            this.tabFilters.Location = new System.Drawing.Point(4, 22);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilters.Size = new System.Drawing.Size(318, 259);
            this.tabFilters.TabIndex = 0;
            this.tabFilters.Text = "Filters";
            this.tabFilters.UseVisualStyleBackColor = true;
            // 
            // lblShowChance
            // 
            this.lblShowChance.AutoSize = true;
            this.lblShowChance.Location = new System.Drawing.Point(3, 263);
            this.lblShowChance.Name = "lblShowChance";
            this.lblShowChance.Size = new System.Drawing.Size(47, 13);
            this.lblShowChance.TabIndex = 68;
            this.lblShowChance.Text = "Chance:";
            // 
            // cmbShowChance
            // 
            this.cmbShowChance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowChance.FormattingEnabled = true;
            this.cmbShowChance.Location = new System.Drawing.Point(111, 260);
            this.cmbShowChance.Name = "cmbShowChance";
            this.cmbShowChance.Size = new System.Drawing.Size(93, 21);
            this.cmbShowChance.TabIndex = 69;
            // 
            // chkShowChance
            // 
            this.chkShowChance.AutoSize = true;
            this.chkShowChance.Location = new System.Drawing.Point(220, 263);
            this.chkShowChance.Name = "chkShowChance";
            this.chkShowChance.Size = new System.Drawing.Size(15, 14);
            this.chkShowChance.TabIndex = 70;
            this.chkShowChance.UseVisualStyleBackColor = true;
            this.chkShowChance.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // lblEncounterTable
            // 
            this.lblEncounterTable.AutoSize = true;
            this.lblEncounterTable.Location = new System.Drawing.Point(3, 232);
            this.lblEncounterTable.Name = "lblEncounterTable";
            this.lblEncounterTable.Size = new System.Drawing.Size(89, 13);
            this.lblEncounterTable.TabIndex = 66;
            this.lblEncounterTable.Text = "Encounter Table:";
            this.lblEncounterTable.Visible = false;
            // 
            // chkShowTable
            // 
            this.chkShowTable.AutoSize = true;
            this.chkShowTable.Location = new System.Drawing.Point(291, 233);
            this.chkShowTable.Name = "chkShowTable";
            this.chkShowTable.Size = new System.Drawing.Size(15, 14);
            this.chkShowTable.TabIndex = 65;
            this.chkShowTable.UseVisualStyleBackColor = true;
            this.chkShowTable.Visible = false;
            this.chkShowTable.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // cmbShowTable
            // 
            this.cmbShowTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowTable.DropDownWidth = 200;
            this.cmbShowTable.FormattingEnabled = true;
            this.cmbShowTable.Location = new System.Drawing.Point(111, 230);
            this.cmbShowTable.Name = "cmbShowTable";
            this.cmbShowTable.Size = new System.Drawing.Size(174, 21);
            this.cmbShowTable.TabIndex = 67;
            this.cmbShowTable.Visible = false;
            this.cmbShowTable.SelectedValueChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowFlag
            // 
            this.chkShowFlag.AutoSize = true;
            this.chkShowFlag.Location = new System.Drawing.Point(291, 202);
            this.chkShowFlag.Name = "chkShowFlag";
            this.chkShowFlag.Size = new System.Drawing.Size(15, 14);
            this.chkShowFlag.TabIndex = 54;
            this.chkShowFlag.UseVisualStyleBackColor = true;
            this.chkShowFlag.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // cmbShowFlag
            // 
            this.cmbShowFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowFlag.DropDownWidth = 200;
            this.cmbShowFlag.FormattingEnabled = true;
            this.cmbShowFlag.Location = new System.Drawing.Point(111, 199);
            this.cmbShowFlag.Name = "cmbShowFlag";
            this.cmbShowFlag.Size = new System.Drawing.Size(174, 21);
            this.cmbShowFlag.TabIndex = 53;
            this.cmbShowFlag.SelectedValueChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Location = new System.Drawing.Point(3, 203);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(30, 13);
            this.lblFlag.TabIndex = 52;
            this.lblFlag.Text = "Flag:";
            // 
            // chkShowNoLocation
            // 
            this.chkShowNoLocation.AutoSize = true;
            this.chkShowNoLocation.Location = new System.Drawing.Point(44, 94);
            this.chkShowNoLocation.Name = "chkShowNoLocation";
            this.chkShowNoLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowNoLocation.Size = new System.Drawing.Size(182, 17);
            this.chkShowNoLocation.TabIndex = 48;
            this.chkShowNoLocation.Text = "No Encounter Location Assigned";
            this.chkShowNoLocation.UseVisualStyleBackColor = true;
            this.chkShowNoLocation.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowLocation
            // 
            this.chkShowLocation.AutoSize = true;
            this.chkShowLocation.Location = new System.Drawing.Point(292, 147);
            this.chkShowLocation.Name = "chkShowLocation";
            this.chkShowLocation.Size = new System.Drawing.Size(15, 14);
            this.chkShowLocation.TabIndex = 47;
            this.chkShowLocation.UseVisualStyleBackColor = true;
            this.chkShowLocation.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // cmbShowLocation
            // 
            this.cmbShowLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowLocation.DropDownWidth = 200;
            this.cmbShowLocation.FormattingEnabled = true;
            this.cmbShowLocation.Location = new System.Drawing.Point(111, 144);
            this.cmbShowLocation.Name = "cmbShowLocation";
            this.cmbShowLocation.Size = new System.Drawing.Size(175, 21);
            this.cmbShowLocation.TabIndex = 46;
            this.cmbShowLocation.SelectedValueChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // lblEncounterLocation
            // 
            this.lblEncounterLocation.AutoSize = true;
            this.lblEncounterLocation.Location = new System.Drawing.Point(2, 149);
            this.lblEncounterLocation.Name = "lblEncounterLocation";
            this.lblEncounterLocation.Size = new System.Drawing.Size(103, 13);
            this.lblEncounterLocation.TabIndex = 45;
            this.lblEncounterLocation.Text = "Encounter Location:";
            // 
            // chkShowNoEncounter
            // 
            this.chkShowNoEncounter.AutoSize = true;
            this.chkShowNoEncounter.Location = new System.Drawing.Point(56, 70);
            this.chkShowNoEncounter.Name = "chkShowNoEncounter";
            this.chkShowNoEncounter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShowNoEncounter.Size = new System.Drawing.Size(170, 17);
            this.chkShowNoEncounter.TabIndex = 44;
            this.chkShowNoEncounter.Text = "No Encounter Group Assigned";
            this.chkShowNoEncounter.UseVisualStyleBackColor = true;
            this.chkShowNoEncounter.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowGroup
            // 
            this.chkShowGroup.AutoSize = true;
            this.chkShowGroup.Location = new System.Drawing.Point(292, 120);
            this.chkShowGroup.Name = "chkShowGroup";
            this.chkShowGroup.Size = new System.Drawing.Size(15, 14);
            this.chkShowGroup.TabIndex = 43;
            this.chkShowGroup.UseVisualStyleBackColor = true;
            this.chkShowGroup.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // cmbShowGroup
            // 
            this.cmbShowGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowGroup.DropDownWidth = 200;
            this.cmbShowGroup.FormattingEnabled = true;
            this.cmbShowGroup.Location = new System.Drawing.Point(111, 117);
            this.cmbShowGroup.Name = "cmbShowGroup";
            this.cmbShowGroup.Size = new System.Drawing.Size(175, 21);
            this.cmbShowGroup.TabIndex = 42;
            this.cmbShowGroup.SelectedValueChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // lblEncounterGroup
            // 
            this.lblEncounterGroup.AutoSize = true;
            this.lblEncounterGroup.Location = new System.Drawing.Point(2, 122);
            this.lblEncounterGroup.Name = "lblEncounterGroup";
            this.lblEncounterGroup.Size = new System.Drawing.Size(91, 13);
            this.lblEncounterGroup.TabIndex = 41;
            this.lblEncounterGroup.Text = "Encounter Group:";
            // 
            // chkShowTerrain
            // 
            this.chkShowTerrain.AutoSize = true;
            this.chkShowTerrain.Location = new System.Drawing.Point(291, 175);
            this.chkShowTerrain.Name = "chkShowTerrain";
            this.chkShowTerrain.Size = new System.Drawing.Size(15, 14);
            this.chkShowTerrain.TabIndex = 40;
            this.chkShowTerrain.UseVisualStyleBackColor = true;
            this.chkShowTerrain.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // cmbShowTerrain
            // 
            this.cmbShowTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowTerrain.DropDownWidth = 200;
            this.cmbShowTerrain.FormattingEnabled = true;
            this.cmbShowTerrain.Location = new System.Drawing.Point(111, 172);
            this.cmbShowTerrain.Name = "cmbShowTerrain";
            this.cmbShowTerrain.Size = new System.Drawing.Size(174, 21);
            this.cmbShowTerrain.TabIndex = 39;
            this.cmbShowTerrain.SelectedValueChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // lblTerrain
            // 
            this.lblTerrain.AutoSize = true;
            this.lblTerrain.Location = new System.Drawing.Point(3, 176);
            this.lblTerrain.Name = "lblTerrain";
            this.lblTerrain.Size = new System.Drawing.Size(70, 13);
            this.lblTerrain.TabIndex = 38;
            this.lblTerrain.Text = "Terrain Type:";
            // 
            // chkShowModified
            // 
            this.chkShowModified.AutoSize = true;
            this.chkShowModified.Location = new System.Drawing.Point(6, 25);
            this.chkShowModified.Name = "chkShowModified";
            this.chkShowModified.Size = new System.Drawing.Size(129, 17);
            this.chkShowModified.TabIndex = 36;
            this.chkShowModified.Text = "Show Modified Zones";
            this.chkShowModified.UseVisualStyleBackColor = true;
            this.chkShowModified.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowImplemented
            // 
            this.chkShowImplemented.AutoSize = true;
            this.chkShowImplemented.Checked = true;
            this.chkShowImplemented.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowImplemented.Location = new System.Drawing.Point(6, 8);
            this.chkShowImplemented.Name = "chkShowImplemented";
            this.chkShowImplemented.Size = new System.Drawing.Size(149, 17);
            this.chkShowImplemented.TabIndex = 37;
            this.chkShowImplemented.Text = "Show Implemented Zones";
            this.chkShowImplemented.UseVisualStyleBackColor = true;
            this.chkShowImplemented.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowZones
            // 
            this.chkShowZones.AutoSize = true;
            this.chkShowZones.Checked = true;
            this.chkShowZones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowZones.Location = new System.Drawing.Point(7, 48);
            this.chkShowZones.Name = "chkShowZones";
            this.chkShowZones.Size = new System.Drawing.Size(212, 17);
            this.chkShowZones.TabIndex = 35;
            this.chkShowZones.Text = "Show Zones Meeting Following Criteria:";
            this.chkShowZones.UseVisualStyleBackColor = true;
            this.chkShowZones.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkShowNumbersDiff);
            this.tabPage2.Controls.Add(this.cmbDifficultyMode);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.numDifficultyOnlyAbove);
            this.tabPage2.Controls.Add(this.chkShowDifficultyMap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Difficulty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkShowNumbersDiff
            // 
            this.chkShowNumbersDiff.AutoSize = true;
            this.chkShowNumbersDiff.Location = new System.Drawing.Point(37, 64);
            this.chkShowNumbersDiff.Name = "chkShowNumbersDiff";
            this.chkShowNumbersDiff.Size = new System.Drawing.Size(98, 17);
            this.chkShowNumbersDiff.TabIndex = 53;
            this.chkShowNumbersDiff.Text = "Show Numbers";
            this.chkShowNumbersDiff.UseVisualStyleBackColor = true;
            this.chkShowNumbersDiff.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // cmbDifficultyMode
            // 
            this.cmbDifficultyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficultyMode.FormattingEnabled = true;
            this.cmbDifficultyMode.Items.AddRange(new object[] {
            "Above",
            "Below"});
            this.cmbDifficultyMode.Location = new System.Drawing.Point(37, 37);
            this.cmbDifficultyMode.Name = "cmbDifficultyMode";
            this.cmbDifficultyMode.Size = new System.Drawing.Size(70, 21);
            this.cmbDifficultyMode.TabIndex = 24;
            this.cmbDifficultyMode.SelectedIndexChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Only";
            // 
            // numDifficultyOnlyAbove
            // 
            this.numDifficultyOnlyAbove.Location = new System.Drawing.Point(113, 38);
            this.numDifficultyOnlyAbove.Name = "numDifficultyOnlyAbove";
            this.numDifficultyOnlyAbove.Size = new System.Drawing.Size(75, 20);
            this.numDifficultyOnlyAbove.TabIndex = 24;
            this.numDifficultyOnlyAbove.ValueChanged += new System.EventHandler(this.RefreshZoneFilter);
            this.numDifficultyOnlyAbove.Leave += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowDifficultyMap
            // 
            this.chkShowDifficultyMap.AutoSize = true;
            this.chkShowDifficultyMap.Location = new System.Drawing.Point(10, 15);
            this.chkShowDifficultyMap.Name = "chkShowDifficultyMap";
            this.chkShowDifficultyMap.Size = new System.Drawing.Size(96, 17);
            this.chkShowDifficultyMap.TabIndex = 24;
            this.chkShowDifficultyMap.Text = "Show Difficulty";
            this.chkShowDifficultyMap.UseVisualStyleBackColor = true;
            this.chkShowDifficultyMap.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.chkShowGroupDensity);
            this.tabPage3.Controls.Add(this.chkShowNumbers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(318, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnGroupQuantityNight);
            this.groupBox2.Controls.Add(this.rbtnGroupQuantityDay);
            this.groupBox2.Controls.Add(this.rbtnGroupQuantityAnyTime);
            this.groupBox2.Controls.Add(this.chkShowGroupQuantities);
            this.groupBox2.Location = new System.Drawing.Point(9, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 116);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Quantities";
            // 
            // rbtnGroupQuantityNight
            // 
            this.rbtnGroupQuantityNight.AutoSize = true;
            this.rbtnGroupQuantityNight.Location = new System.Drawing.Point(19, 88);
            this.rbtnGroupQuantityNight.Name = "rbtnGroupQuantityNight";
            this.rbtnGroupQuantityNight.Size = new System.Drawing.Size(72, 17);
            this.rbtnGroupQuantityNight.TabIndex = 58;
            this.rbtnGroupQuantityNight.Text = "Night time";
            this.rbtnGroupQuantityNight.UseVisualStyleBackColor = true;
            this.rbtnGroupQuantityNight.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // rbtnGroupQuantityDay
            // 
            this.rbtnGroupQuantityDay.AutoSize = true;
            this.rbtnGroupQuantityDay.Location = new System.Drawing.Point(19, 65);
            this.rbtnGroupQuantityDay.Name = "rbtnGroupQuantityDay";
            this.rbtnGroupQuantityDay.Size = new System.Drawing.Size(66, 17);
            this.rbtnGroupQuantityDay.TabIndex = 57;
            this.rbtnGroupQuantityDay.Text = "Day time";
            this.rbtnGroupQuantityDay.UseVisualStyleBackColor = true;
            this.rbtnGroupQuantityDay.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // rbtnGroupQuantityAnyTime
            // 
            this.rbtnGroupQuantityAnyTime.AutoSize = true;
            this.rbtnGroupQuantityAnyTime.Checked = true;
            this.rbtnGroupQuantityAnyTime.Location = new System.Drawing.Point(19, 42);
            this.rbtnGroupQuantityAnyTime.Name = "rbtnGroupQuantityAnyTime";
            this.rbtnGroupQuantityAnyTime.Size = new System.Drawing.Size(78, 17);
            this.rbtnGroupQuantityAnyTime.TabIndex = 56;
            this.rbtnGroupQuantityAnyTime.TabStop = true;
            this.rbtnGroupQuantityAnyTime.Text = "No modifier";
            this.rbtnGroupQuantityAnyTime.UseVisualStyleBackColor = true;
            this.rbtnGroupQuantityAnyTime.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowGroupQuantities
            // 
            this.chkShowGroupQuantities.AutoSize = true;
            this.chkShowGroupQuantities.Location = new System.Drawing.Point(6, 19);
            this.chkShowGroupQuantities.Name = "chkShowGroupQuantities";
            this.chkShowGroupQuantities.Size = new System.Drawing.Size(135, 17);
            this.chkShowGroupQuantities.TabIndex = 54;
            this.chkShowGroupQuantities.Text = "Show Group Quantities";
            this.chkShowGroupQuantities.UseVisualStyleBackColor = true;
            this.chkShowGroupQuantities.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowGroupDensity
            // 
            this.chkShowGroupDensity.AutoSize = true;
            this.chkShowGroupDensity.Location = new System.Drawing.Point(10, 15);
            this.chkShowGroupDensity.Name = "chkShowGroupDensity";
            this.chkShowGroupDensity.Size = new System.Drawing.Size(123, 17);
            this.chkShowGroupDensity.TabIndex = 24;
            this.chkShowGroupDensity.Text = "Show Group Density";
            this.chkShowGroupDensity.UseVisualStyleBackColor = true;
            this.chkShowGroupDensity.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowNumbers
            // 
            this.chkShowNumbers.AutoSize = true;
            this.chkShowNumbers.Location = new System.Drawing.Point(10, 160);
            this.chkShowNumbers.Name = "chkShowNumbers";
            this.chkShowNumbers.Size = new System.Drawing.Size(98, 17);
            this.chkShowNumbers.TabIndex = 55;
            this.chkShowNumbers.Text = "Show Numbers";
            this.chkShowNumbers.UseVisualStyleBackColor = true;
            this.chkShowNumbers.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkShowItemZonesAmount);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.cmbShowItemZones);
            this.tabPage4.Controls.Add(this.chkShowItemZones);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(318, 259);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NPCs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkShowItemZonesAmount
            // 
            this.chkShowItemZonesAmount.AutoSize = true;
            this.chkShowItemZonesAmount.Location = new System.Drawing.Point(28, 62);
            this.chkShowItemZonesAmount.Name = "chkShowItemZonesAmount";
            this.chkShowItemZonesAmount.Size = new System.Drawing.Size(92, 17);
            this.chkShowItemZonesAmount.TabIndex = 52;
            this.chkShowItemZonesAmount.Text = "Show Amount";
            this.chkShowItemZonesAmount.UseVisualStyleBackColor = true;
            this.chkShowItemZonesAmount.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "PID";
            // 
            // cmbShowItemZones
            // 
            this.cmbShowItemZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowItemZones.DropDownWidth = 300;
            this.cmbShowItemZones.FormattingEnabled = true;
            this.cmbShowItemZones.Location = new System.Drawing.Point(56, 35);
            this.cmbShowItemZones.Name = "cmbShowItemZones";
            this.cmbShowItemZones.Size = new System.Drawing.Size(173, 21);
            this.cmbShowItemZones.TabIndex = 52;
            this.cmbShowItemZones.SelectedIndexChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // chkShowItemZones
            // 
            this.chkShowItemZones.AutoSize = true;
            this.chkShowItemZones.Location = new System.Drawing.Point(10, 12);
            this.chkShowItemZones.Name = "chkShowItemZones";
            this.chkShowItemZones.Size = new System.Drawing.Size(162, 17);
            this.chkShowItemZones.TabIndex = 52;
            this.chkShowItemZones.Text = "Show Zones Containing Item";
            this.chkShowItemZones.UseVisualStyleBackColor = true;
            this.chkShowItemZones.CheckedChanged += new System.EventHandler(this.RefreshZoneFilter);
            // 
            // bwMaps
            // 
            this.bwMaps.WorkerReportsProgress = true;
            this.bwMaps.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMaps_DoWork);
            this.bwMaps.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMaps_ProgressChanged);
            this.bwMaps.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMaps_RunWorkerCompleted);
            // 
            // bwMisc
            // 
            this.bwMisc.WorkerReportsProgress = true;
            this.bwMisc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMisc_DoWork);
            this.bwMisc.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMisc_ProgressChanged);
            this.bwMisc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMisc_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslblMouseCoords,
            this.toolStripStatusLabelStatus,
            this.toolStripProgressBarLoading,
            this.toolStripStatusLabelMode,
            this.toolStripStatusLabelMouseCoords,
            this.toolStripStatusLabelGameCoords,
            this.toolStripStatusLabelZoneCoords});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1289, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslblMouseCoords
            // 
            this.toolStripStatuslblMouseCoords.Name = "toolStripStatuslblMouseCoords";
            this.toolStripStatuslblMouseCoords.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabelStatus.Text = "STATUS";
            // 
            // toolStripProgressBarLoading
            // 
            this.toolStripProgressBarLoading.MarqueeAnimationSpeed = 10;
            this.toolStripProgressBarLoading.Name = "toolStripProgressBarLoading";
            this.toolStripProgressBarLoading.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabelMode
            // 
            this.toolStripStatusLabelMode.Name = "toolStripStatusLabelMode";
            this.toolStripStatusLabelMode.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabelMode.Text = "EDIT_MODE";
            // 
            // toolStripStatusLabelMouseCoords
            // 
            this.toolStripStatusLabelMouseCoords.Name = "toolStripStatusLabelMouseCoords";
            this.toolStripStatusLabelMouseCoords.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabelMouseCoords.Text = "MOUSE_COORDS";
            // 
            // toolStripStatusLabelGameCoords
            // 
            this.toolStripStatusLabelGameCoords.Name = "toolStripStatusLabelGameCoords";
            this.toolStripStatusLabelGameCoords.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabelGameCoords.Text = "GAME_COORDS";
            // 
            // toolStripStatusLabelZoneCoords
            // 
            this.toolStripStatusLabelZoneCoords.Name = "toolStripStatusLabelZoneCoords";
            this.toolStripStatusLabelZoneCoords.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabelZoneCoords.Text = "ZONE_COORDS";
            // 
            // bwUI
            // 
            this.bwUI.WorkerReportsProgress = true;
            this.bwUI.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUI_DoWork);
            this.bwUI.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUI_RunWorkerCompleted);
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "NpcCount";
            this.olvColumn7.DisplayIndex = 2;
            this.olvColumn7.IsVisible = false;
            this.olvColumn7.Text = "NPC Count";
            this.olvColumn7.ToolTipText = "Number of NPCs in group";
            this.olvColumn7.Width = 80;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "FactionId";
            this.olvColumn15.DisplayIndex = 3;
            this.olvColumn15.IsVisible = false;
            this.olvColumn15.Text = "Faction Id";
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "FactionName";
            this.olvColumn16.DisplayIndex = 4;
            this.olvColumn16.IsVisible = false;
            this.olvColumn16.Text = "Faction Name";
            this.olvColumn16.Width = 140;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.grpSelectedZone);
            this.Controls.Add(this.pnlWorldMap);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "WorldEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.pnlWorldMap.ResumeLayout(false);
            this.pnlWorldMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWorldMap)).EndInit();
            this.grpSelectedZone.ResumeLayout(false);
            this.grpSelectedZone.PerformLayout();
            this.tabZoneProperties.ResumeLayout(false);
            this.tabPageEncounters.ResumeLayout(false);
            this.tabPageEncounters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstGroups)).EndInit();
            this.tabPageFlags.ResumeLayout(false);
            this.tabPageFlags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDifficulty)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabFilters.ResumeLayout(false);
            this.tabFilters.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficultyOnlyAbove)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorldMap;
        private System.Windows.Forms.PictureBox pctWorldMap;
        private System.Windows.Forms.GroupBox grpSelectedZone;
        private System.Windows.Forms.Label lblSelectedZoneCoords;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTerrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.NumericUpDown numericDifficulty;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyingToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolBtnSave;
        private System.Windows.Forms.ToolStripButton toolbtnClone;
        private System.Windows.Forms.ToolStripButton toolbtnErase;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolbtnBrush;
        private System.Windows.Forms.ToolStripMenuItem mapdataEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.TabControl tabZoneProperties;
        private System.Windows.Forms.TabPage tabPageEncounters;
        private System.Windows.Forms.Button btnRemoveLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageFlags;
        private System.Windows.Forms.Button btnRemoveFlag;
        private System.Windows.Forms.Button btnAddFlag;
        private System.Windows.Forms.ListBox lstFlags;
        private System.Windows.Forms.Label lblZoneFlags;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptlistToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.CheckBox chkShowFlag;
        private System.Windows.Forms.ComboBox cmbShowFlag;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.CheckBox chkShowNoLocation;
        private System.Windows.Forms.CheckBox chkShowLocation;
        private System.Windows.Forms.ComboBox cmbShowLocation;
        private System.Windows.Forms.Label lblEncounterLocation;
        private System.Windows.Forms.CheckBox chkShowNoEncounter;
        private System.Windows.Forms.CheckBox chkShowGroup;
        private System.Windows.Forms.ComboBox cmbShowGroup;
        private System.Windows.Forms.Label lblEncounterGroup;
        private System.Windows.Forms.CheckBox chkShowTerrain;
        private System.Windows.Forms.ComboBox cmbShowTerrain;
        private System.Windows.Forms.Label lblTerrain;
        private System.Windows.Forms.CheckBox chkShowModified;
        private System.Windows.Forms.CheckBox chkShowImplemented;
        private System.Windows.Forms.CheckBox chkShowZones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numDifficultyOnlyAbove;
        private System.Windows.Forms.CheckBox chkShowDifficultyMap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDifficultyMode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkShowGroupDensity;
        private BrightIdeasSoftware.FastObjectListView lstGroups;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.FastObjectListView lstLocations;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.CheckBox chkShowNumbersDiff;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbShowItemZones;
        private System.Windows.Forms.CheckBox chkShowItemZones;
        private System.Windows.Forms.CheckBox chkHideZoneProperties;
        private System.Windows.Forms.CheckBox chkShowItemZonesAmount;
        private System.Windows.Forms.ToolStripMenuItem crittersProtoEditorToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnGroupQuantityNight;
        private System.Windows.Forms.RadioButton rbtnGroupQuantityDay;
        private System.Windows.Forms.RadioButton rbtnGroupQuantityAnyTime;
        private System.Windows.Forms.CheckBox chkShowGroupQuantities;
        private System.Windows.Forms.CheckBox chkShowNumbers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem specialEncounterEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWorldEditorToolStripMenuItem;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblShowChance;
        private System.Windows.Forms.ComboBox cmbShowChance;
        private System.Windows.Forms.CheckBox chkShowChance;
        private System.Windows.Forms.Label lblEncounterTable;
        private System.Windows.Forms.CheckBox chkShowTable;
        private System.Windows.Forms.ComboBox cmbShowTable;
        private System.ComponentModel.BackgroundWorker bwMaps;
        private System.ComponentModel.BackgroundWorker bwMisc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblMouseCoords;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMouseCoords;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZoneCoords;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarLoading;
        private System.ComponentModel.BackgroundWorker bwUI;
        private System.Windows.Forms.ToolStripMenuItem generateDefinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFlagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadedExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMode;
        private System.Windows.Forms.ToolStripMenuItem setImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGameCoords;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

