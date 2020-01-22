namespace WorldEditor
{
    partial class frmEditLocation
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
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEntranceHelp = new System.Windows.Forms.Button();
            this.txtEntranceScript = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.btnFlagsHelp = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.chkGeck = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditTownMap = new System.Windows.Forms.Button();
            this.txtSignImagePath = new System.Windows.Forms.TextBox();
            this.txtTownImagePath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkEncounter = new System.Windows.Forms.CheckBox();
            this.txtEntrance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numMaxCopies = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAssignPID = new System.Windows.Forms.Button();
            this.numPID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numYPos = new System.Windows.Forms.NumericUpDown();
            this.numXPos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveFromWM = new System.Windows.Forms.Button();
            this.lstMaps = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvMusic = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn13 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAddMap = new System.Windows.Forms.Button();
            this.btnRemoveMap = new System.Windows.Forms.Button();
            this.txtWMName = new System.Windows.Forms.TextBox();
            this.lblWmName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(185, 517);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(122, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWMName);
            this.groupBox1.Controls.Add(this.lblWmName);
            this.groupBox1.Controls.Add(this.btnEntranceHelp);
            this.groupBox1.Controls.Add(this.txtEntranceScript);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtFlags);
            this.groupBox1.Controls.Add(this.btnFlagsHelp);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.chkGeck);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnEditTownMap);
            this.groupBox1.Controls.Add(this.txtSignImagePath);
            this.groupBox1.Controls.Add(this.txtTownImagePath);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.chkEncounter);
            this.groupBox1.Controls.Add(this.txtEntrance);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numMaxCopies);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAssignPID);
            this.groupBox1.Controls.Add(this.numPID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numYPos);
            this.groupBox1.Controls.Add(this.numXPos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkVisible);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numSize);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Properties";
            // 
            // btnEntranceHelp
            // 
            this.btnEntranceHelp.Location = new System.Drawing.Point(371, 75);
            this.btnEntranceHelp.Name = "btnEntranceHelp";
            this.btnEntranceHelp.Size = new System.Drawing.Size(25, 21);
            this.btnEntranceHelp.TabIndex = 31;
            this.btnEntranceHelp.Text = "?";
            this.btnEntranceHelp.UseVisualStyleBackColor = true;
            this.btnEntranceHelp.Click += new System.EventHandler(this.btnEntranceHelp_Click);
            // 
            // txtEntranceScript
            // 
            this.txtEntranceScript.Location = new System.Drawing.Point(453, 101);
            this.txtEntranceScript.Name = "txtEntranceScript";
            this.txtEntranceScript.Size = new System.Drawing.Size(72, 20);
            this.txtEntranceScript.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(368, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Entrance Script:";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(333, 227);
            this.txtFlags.Multiline = true;
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFlags.Size = new System.Drawing.Size(192, 47);
            this.txtFlags.TabIndex = 28;
            this.txtFlags.WordWrap = false;
            // 
            // btnFlagsHelp
            // 
            this.btnFlagsHelp.Location = new System.Drawing.Point(371, 204);
            this.btnFlagsHelp.Name = "btnFlagsHelp";
            this.btnFlagsHelp.Size = new System.Drawing.Size(25, 21);
            this.btnFlagsHelp.TabIndex = 27;
            this.btnFlagsHelp.Text = "?";
            this.btnFlagsHelp.UseVisualStyleBackColor = true;
            this.btnFlagsHelp.Click += new System.EventHandler(this.btnFlagsHelp_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Flags:";
            // 
            // chkGeck
            // 
            this.chkGeck.AutoSize = true;
            this.chkGeck.Location = new System.Drawing.Point(304, 55);
            this.chkGeck.Name = "chkGeck";
            this.chkGeck.Size = new System.Drawing.Size(52, 17);
            this.chkGeck.TabIndex = 24;
            this.chkGeck.Text = "Geck";
            this.chkGeck.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Edit/add entry points to the current townmap";
            // 
            // btnEditTownMap
            // 
            this.btnEditTownMap.Location = new System.Drawing.Point(6, 280);
            this.btnEditTownMap.Name = "btnEditTownMap";
            this.btnEditTownMap.Size = new System.Drawing.Size(96, 21);
            this.btnEditTownMap.TabIndex = 22;
            this.btnEditTownMap.Text = "Edit Townmap";
            this.btnEditTownMap.UseVisualStyleBackColor = true;
            this.btnEditTownMap.Click += new System.EventHandler(this.btnEditTownMap_Click);
            // 
            // txtSignImagePath
            // 
            this.txtSignImagePath.Location = new System.Drawing.Point(108, 254);
            this.txtSignImagePath.Name = "txtSignImagePath";
            this.txtSignImagePath.Size = new System.Drawing.Size(219, 20);
            this.txtSignImagePath.TabIndex = 21;
            // 
            // txtTownImagePath
            // 
            this.txtTownImagePath.Location = new System.Drawing.Point(108, 228);
            this.txtTownImagePath.Name = "txtTownImagePath";
            this.txtTownImagePath.Size = new System.Drawing.Size(219, 20);
            this.txtTownImagePath.TabIndex = 20;
            this.txtTownImagePath.TextChanged += new System.EventHandler(this.txtTownImagePath_TextChanged);
            this.txtTownImagePath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTownImagePath_KeyUp);
            this.txtTownImagePath.Move += new System.EventHandler(this.txtTownImagePath_Move);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Sign Image Path:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Town Image Path:";
            // 
            // chkEncounter
            // 
            this.chkEncounter.AutoSize = true;
            this.chkEncounter.Location = new System.Drawing.Point(223, 54);
            this.chkEncounter.Name = "chkEncounter";
            this.chkEncounter.Size = new System.Drawing.Size(75, 17);
            this.chkEncounter.TabIndex = 17;
            this.chkEncounter.Text = "Encounter";
            this.chkEncounter.UseVisualStyleBackColor = true;
            this.chkEncounter.CheckedChanged += new System.EventHandler(this.chkEncounter_CheckedChanged);
            // 
            // txtEntrance
            // 
            this.txtEntrance.Enabled = false;
            this.txtEntrance.Location = new System.Drawing.Point(254, 100);
            this.txtEntrance.Name = "txtEntrance";
            this.txtEntrance.Size = new System.Drawing.Size(102, 20);
            this.txtEntrance.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "0=Unlimited";
            // 
            // numMaxCopies
            // 
            this.numMaxCopies.Location = new System.Drawing.Point(254, 133);
            this.numMaxCopies.Name = "numMaxCopies";
            this.numMaxCopies.Size = new System.Drawing.Size(73, 20);
            this.numMaxCopies.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Max players:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Entrance:";
            // 
            // btnAssignPID
            // 
            this.btnAssignPID.Location = new System.Drawing.Point(333, 28);
            this.btnAssignPID.Name = "btnAssignPID";
            this.btnAssignPID.Size = new System.Drawing.Size(110, 21);
            this.btnAssignPID.TabIndex = 11;
            this.btnAssignPID.Text = "Assign Free PID";
            this.btnAssignPID.UseVisualStyleBackColor = true;
            this.btnAssignPID.Click += new System.EventHandler(this.btnAssignPID_Click);
            // 
            // numPID
            // 
            this.numPID.Location = new System.Drawing.Point(254, 28);
            this.numPID.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPID.Name = "numPID";
            this.numPID.Size = new System.Drawing.Size(73, 20);
            this.numPID.TabIndex = 10;
            this.numPID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "PID:";
            // 
            // numYPos
            // 
            this.numYPos.Location = new System.Drawing.Point(77, 127);
            this.numYPos.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.numYPos.Name = "numYPos";
            this.numYPos.Size = new System.Drawing.Size(65, 20);
            this.numYPos.TabIndex = 8;
            // 
            // numXPos
            // 
            this.numXPos.Location = new System.Drawing.Point(77, 101);
            this.numXPos.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numXPos.Name = "numXPos";
            this.numXPos.Size = new System.Drawing.Size(65, 20);
            this.numXPos.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Y Pos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "X Pos:";
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(77, 204);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(15, 14);
            this.chkVisible.TabIndex = 0;
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visible:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(77, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(452, 39);
            this.txtDescription.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description:";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(77, 77);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(137, 20);
            this.numSize.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maps:";
            // 
            // btnRemoveFromWM
            // 
            this.btnRemoveFromWM.Location = new System.Drawing.Point(338, 517);
            this.btnRemoveFromWM.Name = "btnRemoveFromWM";
            this.btnRemoveFromWM.Size = new System.Drawing.Size(136, 27);
            this.btnRemoveFromWM.TabIndex = 5;
            this.btnRemoveFromWM.Text = "Remove from Worldmap";
            this.btnRemoveFromWM.UseVisualStyleBackColor = true;
            this.btnRemoveFromWM.Click += new System.EventHandler(this.btnRemoveFromWM_Click);
            // 
            // lstMaps
            // 
            this.lstMaps.AllColumns.Add(this.olvColumn8);
            this.lstMaps.AllColumns.Add(this.olvColumn9);
            this.lstMaps.AllColumns.Add(this.olvColumn10);
            this.lstMaps.AllColumns.Add(this.olvMusic);
            this.lstMaps.AllColumns.Add(this.olvColumn12);
            this.lstMaps.AllColumns.Add(this.olvColumn13);
            this.lstMaps.AllColumns.Add(this.olvColumn14);
            this.lstMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn8,
            this.olvColumn9,
            this.olvColumn10,
            this.olvMusic,
            this.olvColumn12,
            this.olvColumn13,
            this.olvColumn14});
            this.lstMaps.FullRowSelect = true;
            this.lstMaps.Location = new System.Drawing.Point(12, 340);
            this.lstMaps.MultiSelect = false;
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.ShowGroups = false;
            this.lstMaps.Size = new System.Drawing.Size(534, 138);
            this.lstMaps.TabIndex = 6;
            this.lstMaps.UseCompatibleStateImageBehavior = false;
            this.lstMaps.View = System.Windows.Forms.View.Details;
            this.lstMaps.VirtualMode = true;
            this.lstMaps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMaps_MouseDoubleClick_1);
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Pid";
            this.olvColumn8.Text = "PID";
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Name";
            this.olvColumn9.Text = "Name";
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "FileName";
            this.olvColumn10.Text = "Filename";
            // 
            // olvMusic
            // 
            this.olvMusic.AspectName = "Music";
            this.olvMusic.Text = "Music";
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "SoundString";
            this.olvColumn12.Text = "Sound";
            // 
            // olvColumn13
            // 
            this.olvColumn13.AspectName = "ScriptName";
            this.olvColumn13.Text = "Script";
            // 
            // olvColumn14
            // 
            this.olvColumn14.AspectName = "NoLogout";
            this.olvColumn14.Text = "NoLogout";
            // 
            // btnAddMap
            // 
            this.btnAddMap.Location = new System.Drawing.Point(120, 484);
            this.btnAddMap.Name = "btnAddMap";
            this.btnAddMap.Size = new System.Drawing.Size(122, 27);
            this.btnAddMap.TabIndex = 7;
            this.btnAddMap.Text = "Add Map(s)";
            this.btnAddMap.UseVisualStyleBackColor = true;
            this.btnAddMap.Click += new System.EventHandler(this.btnAddMap_Click);
            // 
            // btnRemoveMap
            // 
            this.btnRemoveMap.Location = new System.Drawing.Point(248, 484);
            this.btnRemoveMap.Name = "btnRemoveMap";
            this.btnRemoveMap.Size = new System.Drawing.Size(132, 27);
            this.btnRemoveMap.TabIndex = 8;
            this.btnRemoveMap.Text = "Remove Map";
            this.btnRemoveMap.UseVisualStyleBackColor = true;
            this.btnRemoveMap.Click += new System.EventHandler(this.btnRemoveMap_Click);
            // 
            // txtWMName
            // 
            this.txtWMName.Location = new System.Drawing.Point(75, 51);
            this.txtWMName.Name = "txtWMName";
            this.txtWMName.Size = new System.Drawing.Size(139, 20);
            this.txtWMName.TabIndex = 33;
            // 
            // lblWmName
            // 
            this.lblWmName.AutoSize = true;
            this.lblWmName.Location = new System.Drawing.Point(6, 54);
            this.lblWmName.Name = "lblWmName";
            this.lblWmName.Size = new System.Drawing.Size(61, 13);
            this.lblWmName.TabIndex = 32;
            this.lblWmName.Text = "WM Name:";
            // 
            // frmEditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 559);
            this.Controls.Add(this.btnRemoveMap);
            this.Controls.Add(this.btnAddMap);
            this.Controls.Add(this.lstMaps);
            this.Controls.Add(this.btnRemoveFromWM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Location - <Location Name>";
            this.Load += new System.EventHandler(this.frmEditLocation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstMaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numYPos;
        private System.Windows.Forms.NumericUpDown numXPos;
        private System.Windows.Forms.Button btnRemoveFromWM;
        private BrightIdeasSoftware.FastObjectListView lstMaps;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private BrightIdeasSoftware.OLVColumn olvMusic;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.OLVColumn olvColumn13;
        private BrightIdeasSoftware.OLVColumn olvColumn14;
        private System.Windows.Forms.Button btnAssignPID;
        private System.Windows.Forms.NumericUpDown numPID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddMap;
        private System.Windows.Forms.Button btnRemoveMap;
        private System.Windows.Forms.TextBox txtEntrance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numMaxCopies;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEncounter;
        private System.Windows.Forms.TextBox txtSignImagePath;
        private System.Windows.Forms.TextBox txtTownImagePath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditTownMap;
        private System.Windows.Forms.CheckBox chkGeck;
        private System.Windows.Forms.Button btnFlagsHelp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.Button btnEntranceHelp;
        private System.Windows.Forms.TextBox txtEntranceScript;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtWMName;
        private System.Windows.Forms.Label lblWmName;
        private System.Windows.Forms.ToolTip toolTip;
    }
}