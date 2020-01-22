namespace FOMonitor
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
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.chkRemove = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstPlayers = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn19 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lstFiltered = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn18 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnWhitelist = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBlacklistColor = new System.Windows.Forms.ComboBox();
            this.chkSingleTable = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkOneHitPerPlayer = new System.Windows.Forms.CheckBox();
            this.btnSelectSources = new System.Windows.Forms.Button();
            this.cmbSources = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnLogMovePath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogMovePath = new System.Windows.Forms.TextBox();
            this.chkMoveLogs = new System.Windows.Forms.CheckBox();
            this.chkLogDeletionKeepLatest = new System.Windows.Forms.CheckBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.chkLoadOnUpdate = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkInTent = new System.Windows.Forms.CheckBox();
            this.chkRawId = new System.Windows.Forms.CheckBox();
            this.cmbMapFilterRaw = new System.Windows.Forms.ComboBox();
            this.numMapFilter = new System.Windows.Forms.NumericUpDown();
            this.chkInBase = new System.Windows.Forms.CheckBox();
            this.chkInTown = new System.Windows.Forms.CheckBox();
            this.chkInEncounter = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkAltBasedOnName = new System.Windows.Forms.CheckBox();
            this.chkAggressiveIpMatching = new System.Windows.Forms.CheckBox();
            this.chkAlts = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmbCond = new System.Windows.Forms.ComboBox();
            this.chkFilterCond = new System.Windows.Forms.CheckBox();
            this.cmbNetState = new System.Windows.Forms.ComboBox();
            this.chkFilterNetstate = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.chkFilterIp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.chkBlacklist = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrReadMem = new System.Windows.Forms.Timer(this.components);
            this.lblLogsPath = new System.Windows.Forms.Label();
            this.cmbMatchMode = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstFiltered)).BeginInit();
            this.tabOptions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMapFilter)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 25);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(17, 135);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(0, 13);
            this.lblPlayers.TabIndex = 3;
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(12, 43);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(175, 25);
            this.btnFilters.TabIndex = 6;
            this.btnFilters.Text = "Apply Filters";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "FOMonitor by Ghosthack. Thanks to Cubik for the idea.";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(193, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(10, 13);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = ".";
            // 
            // chkRemove
            // 
            this.chkRemove.AutoSize = true;
            this.chkRemove.Location = new System.Drawing.Point(12, 74);
            this.chkRemove.Name = "chkRemove";
            this.chkRemove.Size = new System.Drawing.Size(160, 17);
            this.chkRemove.TabIndex = 11;
            this.chkRemove.Text = "(Re)move log(s) after update";
            this.chkRemove.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(15, 154);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstPlayers);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstFiltered);
            this.splitContainer1.Size = new System.Drawing.Size(945, 456);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 19;
            // 
            // lstPlayers
            // 
            this.lstPlayers.AllColumns.Add(this.olvColumn1);
            this.lstPlayers.AllColumns.Add(this.olvColumn3);
            this.lstPlayers.AllColumns.Add(this.olvColumn2);
            this.lstPlayers.AllColumns.Add(this.olvColumn9);
            this.lstPlayers.AllColumns.Add(this.olvColumn19);
            this.lstPlayers.AllColumns.Add(this.olvColumn4);
            this.lstPlayers.AllColumns.Add(this.olvColumn12);
            this.lstPlayers.AllColumns.Add(this.olvColumn10);
            this.lstPlayers.AllColumns.Add(this.olvColumn15);
            this.lstPlayers.AllColumns.Add(this.olvColumn16);
            this.lstPlayers.AllowColumnReorder = true;
            this.lstPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn2,
            this.olvColumn9,
            this.olvColumn19,
            this.olvColumn4,
            this.olvColumn12,
            this.olvColumn10,
            this.olvColumn15,
            this.olvColumn16});
            this.lstPlayers.CopySelectionOnControlC = false;
            this.lstPlayers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstPlayers.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lstPlayers.FullRowSelect = true;
            this.lstPlayers.GridLines = true;
            this.lstPlayers.Location = new System.Drawing.Point(3, 3);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.ShowGroups = false;
            this.lstPlayers.Size = new System.Drawing.Size(515, 446);
            this.lstPlayers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstPlayers.TabIndex = 19;
            this.lstPlayers.UseCompatibleStateImageBehavior = false;
            this.lstPlayers.View = System.Windows.Forms.View.Details;
            this.lstPlayers.VirtualMode = true;
            this.lstPlayers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPlayers_KeyDown);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.Text = "Player Name";
            this.olvColumn1.Width = 100;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Id";
            this.olvColumn3.IsTileViewColumn = true;
            this.olvColumn3.Text = "Player Id";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Ip";
            this.olvColumn2.Text = "IP";
            this.olvColumn2.Width = 90;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "NetState";
            this.olvColumn9.Text = "Connected";
            this.olvColumn9.Width = 70;
            // 
            // olvColumn19
            // 
            this.olvColumn19.AspectName = "Cond";
            this.olvColumn19.Text = "Cond";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Map";
            this.olvColumn4.Text = "Map (Id, Pid)";
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "Location";
            this.olvColumn12.Text = "Location (Id, Pid)";
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "Level";
            this.olvColumn10.Text = "Level";
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "TimeStamp";
            this.olvColumn15.Text = "Time";
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "FromFile";
            this.olvColumn16.Text = "Logfile";
            // 
            // lstFiltered
            // 
            this.lstFiltered.AllColumns.Add(this.olvColumn5);
            this.lstFiltered.AllColumns.Add(this.olvColumn6);
            this.lstFiltered.AllColumns.Add(this.olvColumn7);
            this.lstFiltered.AllColumns.Add(this.olvColumn8);
            this.lstFiltered.AllColumns.Add(this.olvColumn20);
            this.lstFiltered.AllColumns.Add(this.olvColumn11);
            this.lstFiltered.AllColumns.Add(this.olvColumn13);
            this.lstFiltered.AllColumns.Add(this.olvColumn14);
            this.lstFiltered.AllColumns.Add(this.olvColumn17);
            this.lstFiltered.AllColumns.Add(this.olvColumn18);
            this.lstFiltered.AllowColumnReorder = true;
            this.lstFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiltered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn20,
            this.olvColumn11,
            this.olvColumn13,
            this.olvColumn14,
            this.olvColumn17,
            this.olvColumn18});
            this.lstFiltered.CopySelectionOnControlC = false;
            this.lstFiltered.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstFiltered.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lstFiltered.FullRowSelect = true;
            this.lstFiltered.GridLines = true;
            this.lstFiltered.Location = new System.Drawing.Point(3, 3);
            this.lstFiltered.Name = "lstFiltered";
            this.lstFiltered.ShowGroups = false;
            this.lstFiltered.Size = new System.Drawing.Size(406, 446);
            this.lstFiltered.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstFiltered.TabIndex = 19;
            this.lstFiltered.UseCompatibleStateImageBehavior = false;
            this.lstFiltered.View = System.Windows.Forms.View.Details;
            this.lstFiltered.VirtualMode = true;
            this.lstFiltered.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.lstFiltered_FormatRow);
            this.lstFiltered.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFiltered_KeyDown);
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Name";
            this.olvColumn5.Text = "Player Name";
            this.olvColumn5.Width = 100;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Id";
            this.olvColumn6.IsTileViewColumn = true;
            this.olvColumn6.Text = "Player Id";
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Ip";
            this.olvColumn7.Text = "IP";
            this.olvColumn7.Width = 90;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "NetState";
            this.olvColumn8.Text = "Connected";
            this.olvColumn8.Width = 70;
            // 
            // olvColumn20
            // 
            this.olvColumn20.AspectName = "Cond";
            this.olvColumn20.Text = "Cond";
            // 
            // olvColumn11
            // 
            this.olvColumn11.AspectName = "Map";
            this.olvColumn11.Text = "Map (Id, Pid)";
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "Location";
            this.olvColumn13.Text = "Location (Id, Pid)";
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "Level";
            this.olvColumn14.Text = "Level";
            // 
            // olvColumn17
            // 
            this.olvColumn17.AspectName = "TimeStamp";
            this.olvColumn17.Text = "Time";
            // 
            // olvColumn18
            // 
            this.olvColumn18.AspectName = "FromFile";
            this.olvColumn18.Text = "Logfile";
            // 
            // btnWhitelist
            // 
            this.btnWhitelist.Location = new System.Drawing.Point(193, 43);
            this.btnWhitelist.Name = "btnWhitelist";
            this.btnWhitelist.Size = new System.Drawing.Size(108, 25);
            this.btnWhitelist.TabIndex = 21;
            this.btnWhitelist.Text = "Whitelist";
            this.btnWhitelist.UseVisualStyleBackColor = true;
            this.btnWhitelist.Click += new System.EventHandler(this.btnWhitelist_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabPage1);
            this.tabOptions.Controls.Add(this.tabPage2);
            this.tabOptions.Controls.Add(this.tabPage7);
            this.tabOptions.Location = new System.Drawing.Point(686, 34);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(269, 114);
            this.tabOptions.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbFont);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbBlacklistColor);
            this.tabPage1.Controls.Add(this.chkSingleTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Layout";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(87, 59);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(111, 21);
            this.cmbFont.TabIndex = 6;
            this.cmbFont.SelectedValueChanged += new System.EventHandler(this.cmbFont_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Table font";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blacklist colour";
            // 
            // cmbBlacklistColor
            // 
            this.cmbBlacklistColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlacklistColor.FormattingEnabled = true;
            this.cmbBlacklistColor.Location = new System.Drawing.Point(87, 30);
            this.cmbBlacklistColor.Name = "cmbBlacklistColor";
            this.cmbBlacklistColor.Size = new System.Drawing.Size(111, 21);
            this.cmbBlacklistColor.TabIndex = 3;
            // 
            // chkSingleTable
            // 
            this.chkSingleTable.AutoSize = true;
            this.chkSingleTable.Location = new System.Drawing.Point(6, 8);
            this.chkSingleTable.Name = "chkSingleTable";
            this.chkSingleTable.Size = new System.Drawing.Size(112, 17);
            this.chkSingleTable.TabIndex = 2;
            this.chkSingleTable.Text = "Single table layout";
            this.chkSingleTable.UseVisualStyleBackColor = true;
            this.chkSingleTable.CheckedChanged += new System.EventHandler(this.chkSingleTable_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbMatchMode);
            this.tabPage2.Controls.Add(this.chkOneHitPerPlayer);
            this.tabPage2.Controls.Add(this.btnSelectSources);
            this.tabPage2.Controls.Add(this.cmbSources);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 88);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sources";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkOneHitPerPlayer
            // 
            this.chkOneHitPerPlayer.AutoSize = true;
            this.chkOneHitPerPlayer.Location = new System.Drawing.Point(6, 33);
            this.chkOneHitPerPlayer.Name = "chkOneHitPerPlayer";
            this.chkOneHitPerPlayer.Size = new System.Drawing.Size(109, 17);
            this.chkOneHitPerPlayer.TabIndex = 2;
            this.chkOneHitPerPlayer.Text = "One hit per player";
            this.chkOneHitPerPlayer.UseVisualStyleBackColor = true;
            // 
            // btnSelectSources
            // 
            this.btnSelectSources.Location = new System.Drawing.Point(6, 53);
            this.btnSelectSources.Name = "btnSelectSources";
            this.btnSelectSources.Size = new System.Drawing.Size(107, 21);
            this.btnSelectSources.TabIndex = 1;
            this.btnSelectSources.Text = "Select Sources";
            this.btnSelectSources.UseVisualStyleBackColor = true;
            this.btnSelectSources.Visible = false;
            // 
            // cmbSources
            // 
            this.cmbSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSources.FormattingEnabled = true;
            this.cmbSources.Items.AddRange(new object[] {
            "Latest instance in last log",
            "All instances in last log",
            "All instances from all logs"});
            this.cmbSources.Location = new System.Drawing.Point(6, 6);
            this.cmbSources.Name = "cmbSources";
            this.cmbSources.Size = new System.Drawing.Size(164, 21);
            this.cmbSources.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnLogMovePath);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.txtLogMovePath);
            this.tabPage7.Controls.Add(this.chkMoveLogs);
            this.tabPage7.Controls.Add(this.chkLogDeletionKeepLatest);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(261, 88);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Log Deletion";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnLogMovePath
            // 
            this.btnLogMovePath.Location = new System.Drawing.Point(162, 57);
            this.btnLogMovePath.Name = "btnLogMovePath";
            this.btnLogMovePath.Size = new System.Drawing.Size(25, 24);
            this.btnLogMovePath.TabIndex = 4;
            this.btnLogMovePath.Text = "...";
            this.btnLogMovePath.UseVisualStyleBackColor = true;
            this.btnLogMovePath.Click += new System.EventHandler(this.btnLogMovePath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Path";
            // 
            // txtLogMovePath
            // 
            this.txtLogMovePath.Location = new System.Drawing.Point(40, 60);
            this.txtLogMovePath.Name = "txtLogMovePath";
            this.txtLogMovePath.ReadOnly = true;
            this.txtLogMovePath.Size = new System.Drawing.Size(116, 20);
            this.txtLogMovePath.TabIndex = 2;
            // 
            // chkMoveLogs
            // 
            this.chkMoveLogs.AutoSize = true;
            this.chkMoveLogs.Location = new System.Drawing.Point(6, 32);
            this.chkMoveLogs.Name = "chkMoveLogs";
            this.chkMoveLogs.Size = new System.Drawing.Size(164, 17);
            this.chkMoveLogs.TabIndex = 1;
            this.chkMoveLogs.Text = "Move logs instead of deleting";
            this.chkMoveLogs.UseVisualStyleBackColor = true;
            // 
            // chkLogDeletionKeepLatest
            // 
            this.chkLogDeletionKeepLatest.AutoSize = true;
            this.chkLogDeletionKeepLatest.Location = new System.Drawing.Point(6, 9);
            this.chkLogDeletionKeepLatest.Name = "chkLogDeletionKeepLatest";
            this.chkLogDeletionKeepLatest.Size = new System.Drawing.Size(96, 17);
            this.chkLogDeletionKeepLatest.TabIndex = 0;
            this.chkLogDeletionKeepLatest.Text = "Keep latest log";
            this.chkLogDeletionKeepLatest.UseVisualStyleBackColor = true;
            // 
            // chkLoadOnUpdate
            // 
            this.chkLoadOnUpdate.AutoSize = true;
            this.chkLoadOnUpdate.Location = new System.Drawing.Point(12, 97);
            this.chkLoadOnUpdate.Name = "chkLoadOnUpdate";
            this.chkLoadOnUpdate.Size = new System.Drawing.Size(307, 17);
            this.chkLoadOnUpdate.TabIndex = 23;
            this.chkLoadOnUpdate.Text = "Load table on update (might be slow when using many logs)";
            this.chkLoadOnUpdate.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(413, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 114);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkInTent);
            this.tabPage3.Controls.Add(this.chkRawId);
            this.tabPage3.Controls.Add(this.cmbMapFilterRaw);
            this.tabPage3.Controls.Add(this.numMapFilter);
            this.tabPage3.Controls.Add(this.chkInBase);
            this.tabPage3.Controls.Add(this.chkInTown);
            this.tabPage3.Controls.Add(this.chkInEncounter);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(259, 88);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Location";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkInTent
            // 
            this.chkInTent.AutoSize = true;
            this.chkInTent.Location = new System.Drawing.Point(9, 9);
            this.chkInTent.Name = "chkInTent";
            this.chkInTent.Size = new System.Drawing.Size(60, 17);
            this.chkInTent.TabIndex = 29;
            this.chkInTent.Text = "In Tent";
            this.chkInTent.UseVisualStyleBackColor = true;
            // 
            // chkRawId
            // 
            this.chkRawId.AutoSize = true;
            this.chkRawId.Location = new System.Drawing.Point(9, 60);
            this.chkRawId.Name = "chkRawId";
            this.chkRawId.Size = new System.Drawing.Size(15, 14);
            this.chkRawId.TabIndex = 28;
            this.chkRawId.UseVisualStyleBackColor = true;
            // 
            // cmbMapFilterRaw
            // 
            this.cmbMapFilterRaw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapFilterRaw.FormattingEnabled = true;
            this.cmbMapFilterRaw.Items.AddRange(new object[] {
            "Map PID",
            "Map ID",
            "Location PID",
            "Location ID"});
            this.cmbMapFilterRaw.Location = new System.Drawing.Point(29, 56);
            this.cmbMapFilterRaw.Name = "cmbMapFilterRaw";
            this.cmbMapFilterRaw.Size = new System.Drawing.Size(90, 21);
            this.cmbMapFilterRaw.TabIndex = 27;
            // 
            // numMapFilter
            // 
            this.numMapFilter.Location = new System.Drawing.Point(125, 57);
            this.numMapFilter.Name = "numMapFilter";
            this.numMapFilter.Size = new System.Drawing.Size(101, 20);
            this.numMapFilter.TabIndex = 26;
            // 
            // chkInBase
            // 
            this.chkInBase.AutoSize = true;
            this.chkInBase.Location = new System.Drawing.Point(102, 9);
            this.chkInBase.Name = "chkInBase";
            this.chkInBase.Size = new System.Drawing.Size(62, 17);
            this.chkInBase.TabIndex = 25;
            this.chkInBase.Text = "In Base";
            this.chkInBase.UseVisualStyleBackColor = true;
            // 
            // chkInTown
            // 
            this.chkInTown.AutoSize = true;
            this.chkInTown.Location = new System.Drawing.Point(102, 32);
            this.chkInTown.Name = "chkInTown";
            this.chkInTown.Size = new System.Drawing.Size(65, 17);
            this.chkInTown.TabIndex = 24;
            this.chkInTown.Text = "In Town";
            this.chkInTown.UseVisualStyleBackColor = true;
            // 
            // chkInEncounter
            // 
            this.chkInEncounter.AutoSize = true;
            this.chkInEncounter.Location = new System.Drawing.Point(9, 32);
            this.chkInEncounter.Name = "chkInEncounter";
            this.chkInEncounter.Size = new System.Drawing.Size(87, 17);
            this.chkInEncounter.TabIndex = 23;
            this.chkInEncounter.Text = "In Encounter";
            this.chkInEncounter.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkAltBasedOnName);
            this.tabPage4.Controls.Add(this.chkAggressiveIpMatching);
            this.tabPage4.Controls.Add(this.chkAlts);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(259, 88);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Alts";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkAltBasedOnName
            // 
            this.chkAltBasedOnName.AutoSize = true;
            this.chkAltBasedOnName.Location = new System.Drawing.Point(6, 52);
            this.chkAltBasedOnName.Name = "chkAltBasedOnName";
            this.chkAltBasedOnName.Size = new System.Drawing.Size(167, 17);
            this.chkAltBasedOnName.TabIndex = 26;
            this.chkAltBasedOnName.Text = "Detect based on similiar name";
            this.chkAltBasedOnName.UseVisualStyleBackColor = true;
            // 
            // chkAggressiveIpMatching
            // 
            this.chkAggressiveIpMatching.AutoSize = true;
            this.chkAggressiveIpMatching.Location = new System.Drawing.Point(6, 29);
            this.chkAggressiveIpMatching.Name = "chkAggressiveIpMatching";
            this.chkAggressiveIpMatching.Size = new System.Drawing.Size(237, 17);
            this.chkAggressiveIpMatching.TabIndex = 25;
            this.chkAggressiveIpMatching.Text = "More aggressive IP matching (check subnet)";
            this.chkAggressiveIpMatching.UseVisualStyleBackColor = true;
            // 
            // chkAlts
            // 
            this.chkAlts.AutoSize = true;
            this.chkAlts.Location = new System.Drawing.Point(6, 6);
            this.chkAlts.Name = "chkAlts";
            this.chkAlts.Size = new System.Drawing.Size(132, 17);
            this.chkAlts.TabIndex = 23;
            this.chkAlts.Text = "Check for possible alts";
            this.chkAlts.UseVisualStyleBackColor = true;
            this.chkAlts.CheckedChanged += new System.EventHandler(this.chkAlts_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmbCond);
            this.tabPage5.Controls.Add(this.chkFilterCond);
            this.tabPage5.Controls.Add(this.cmbNetState);
            this.tabPage5.Controls.Add(this.chkFilterNetstate);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(259, 88);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Condition";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmbCond
            // 
            this.cmbCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCond.FormattingEnabled = true;
            this.cmbCond.Items.AddRange(new object[] {
            "Life",
            "Knockout",
            "Dead"});
            this.cmbCond.Location = new System.Drawing.Point(81, 31);
            this.cmbCond.Name = "cmbCond";
            this.cmbCond.Size = new System.Drawing.Size(108, 21);
            this.cmbCond.TabIndex = 3;
            // 
            // chkFilterCond
            // 
            this.chkFilterCond.AutoSize = true;
            this.chkFilterCond.Location = new System.Drawing.Point(7, 33);
            this.chkFilterCond.Name = "chkFilterCond";
            this.chkFilterCond.Size = new System.Drawing.Size(51, 17);
            this.chkFilterCond.TabIndex = 2;
            this.chkFilterCond.Text = "Cond";
            this.chkFilterCond.UseVisualStyleBackColor = true;
            this.chkFilterCond.CheckedChanged += new System.EventHandler(this.chkFilterCond_CheckedChanged);
            // 
            // cmbNetState
            // 
            this.cmbNetState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetState.FormattingEnabled = true;
            this.cmbNetState.Items.AddRange(new object[] {
            "Yes",
            "Disconnect"});
            this.cmbNetState.Location = new System.Drawing.Point(81, 4);
            this.cmbNetState.Name = "cmbNetState";
            this.cmbNetState.Size = new System.Drawing.Size(108, 21);
            this.cmbNetState.TabIndex = 1;
            // 
            // chkFilterNetstate
            // 
            this.chkFilterNetstate.AutoSize = true;
            this.chkFilterNetstate.Location = new System.Drawing.Point(7, 7);
            this.chkFilterNetstate.Name = "chkFilterNetstate";
            this.chkFilterNetstate.Size = new System.Drawing.Size(68, 17);
            this.chkFilterNetstate.TabIndex = 0;
            this.chkFilterNetstate.Text = "NetState";
            this.chkFilterNetstate.UseVisualStyleBackColor = true;
            this.chkFilterNetstate.CheckedChanged += new System.EventHandler(this.chkFilterNetstate_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtIp);
            this.tabPage6.Controls.Add(this.chkFilterIp);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(259, 88);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "IP";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(82, 4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(114, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "*.*.*.*";
            // 
            // chkFilterIp
            // 
            this.chkFilterIp.AutoSize = true;
            this.chkFilterIp.Location = new System.Drawing.Point(7, 7);
            this.chkFilterIp.Name = "chkFilterIp";
            this.chkFilterIp.Size = new System.Drawing.Size(69, 17);
            this.chkFilterIp.TabIndex = 0;
            this.chkFilterIp.Text = "Match IP";
            this.chkFilterIp.UseVisualStyleBackColor = true;
            this.chkFilterIp.CheckedChanged += new System.EventHandler(this.chkFilterIp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filter Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Options:";
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.Location = new System.Drawing.Point(303, 43);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(104, 25);
            this.btnBlacklist.TabIndex = 28;
            this.btnBlacklist.Text = "Blacklist";
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // chkBlacklist
            // 
            this.chkBlacklist.AutoSize = true;
            this.chkBlacklist.Location = new System.Drawing.Point(12, 120);
            this.chkBlacklist.Name = "chkBlacklist";
            this.chkBlacklist.Size = new System.Drawing.Size(86, 17);
            this.chkBlacklist.TabIndex = 29;
            this.chkBlacklist.Text = "Use blacklist";
            this.chkBlacklist.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblLogsPath
            // 
            this.lblLogsPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogsPath.AutoSize = true;
            this.lblLogsPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.lblLogsPath.Location = new System.Drawing.Point(300, 621);
            this.lblLogsPath.Name = "lblLogsPath";
            this.lblLogsPath.Size = new System.Drawing.Size(249, 12);
            this.lblLogsPath.TabIndex = 30;
            this.lblLogsPath.Text = "Reading logs from:  (defined in FOnline2238.cfg)";
            // 
            // cmbMatchMode
            // 
            this.cmbMatchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatchMode.FormattingEnabled = true;
            this.cmbMatchMode.Items.AddRange(new object[] {
            "First Found",
            "Last Found"});
            this.cmbMatchMode.Location = new System.Drawing.Point(121, 31);
            this.cmbMatchMode.Name = "cmbMatchMode";
            this.cmbMatchMode.Size = new System.Drawing.Size(88, 21);
            this.cmbMatchMode.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 641);
            this.Controls.Add(this.lblLogsPath);
            this.Controls.Add(this.chkBlacklist);
            this.Controls.Add(this.btnBlacklist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chkLoadOnUpdate);
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.btnWhitelist);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.chkRemove);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.btnUpdate);
            this.MinimumSize = new System.Drawing.Size(985, 679);
            this.Name = "frmMain";
            this.Text = "FOMonitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstFiltered)).EndInit();
            this.tabOptions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMapFilter)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.CheckBox chkRemove;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BrightIdeasSoftware.FastObjectListView lstFiltered;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn11;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.OLVColumn olvColumn14;
        private BrightIdeasSoftware.FastObjectListView lstPlayers;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private System.Windows.Forms.Button btnWhitelist;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkSingleTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelectSources;
        private System.Windows.Forms.ComboBox cmbSources;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
        private BrightIdeasSoftware.OLVColumn olvColumn17;
        private BrightIdeasSoftware.OLVColumn olvColumn18;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.CheckBox chkOneHitPerPlayer;
        private System.Windows.Forms.CheckBox chkLoadOnUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkRawId;
        private System.Windows.Forms.ComboBox cmbMapFilterRaw;
        private System.Windows.Forms.NumericUpDown numMapFilter;
        private System.Windows.Forms.CheckBox chkInBase;
        private System.Windows.Forms.CheckBox chkInTown;
        private System.Windows.Forms.CheckBox chkInEncounter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkInTent;
        private System.Windows.Forms.CheckBox chkAggressiveIpMatching;
        private System.Windows.Forms.CheckBox chkAlts;
        private System.Windows.Forms.CheckBox chkAltBasedOnName;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cmbNetState;
        private System.Windows.Forms.CheckBox chkFilterNetstate;
        private BrightIdeasSoftware.OLVColumn olvColumn19;
        private BrightIdeasSoftware.OLVColumn olvColumn20;
        private System.Windows.Forms.ComboBox cmbCond;
        private System.Windows.Forms.CheckBox chkFilterCond;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.CheckBox chkFilterIp;
        private System.Windows.Forms.Button btnBlacklist;
        private System.Windows.Forms.CheckBox chkBlacklist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBlacklistColor;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnLogMovePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogMovePath;
        private System.Windows.Forms.CheckBox chkMoveLogs;
        private System.Windows.Forms.CheckBox chkLogDeletionKeepLatest;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrReadMem;
        private System.Windows.Forms.Label lblLogsPath;
        private System.Windows.Forms.ComboBox cmbMatchMode;
    }
}

