namespace WorldEditor
{
    partial class frmMapEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAddNewMap = new System.Windows.Forms.Button();
            this.lstMaps = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvMusic = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnRemoveMap = new System.Windows.Forms.Button();
            this.btnEditInMapper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double-click on a map to edit its data.";
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDone.Location = new System.Drawing.Point(341, 504);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(178, 27);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAddNewMap
            // 
            this.btnAddNewMap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddNewMap.Location = new System.Drawing.Point(239, 468);
            this.btnAddNewMap.Name = "btnAddNewMap";
            this.btnAddNewMap.Size = new System.Drawing.Size(135, 26);
            this.btnAddNewMap.TabIndex = 3;
            this.btnAddNewMap.Text = "Add New Map";
            this.btnAddNewMap.UseVisualStyleBackColor = true;
            this.btnAddNewMap.Click += new System.EventHandler(this.btnAddNewMap_Click);
            // 
            // lstMaps
            // 
            this.lstMaps.AllColumns.Add(this.olvColumn1);
            this.lstMaps.AllColumns.Add(this.olvColumn7);
            this.lstMaps.AllColumns.Add(this.olvColumn2);
            this.lstMaps.AllColumns.Add(this.olvMusic);
            this.lstMaps.AllColumns.Add(this.olvColumn4);
            this.lstMaps.AllColumns.Add(this.olvColumn5);
            this.lstMaps.AllColumns.Add(this.olvColumn6);
            this.lstMaps.AllColumns.Add(this.olvColumn8);
            this.lstMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn7,
            this.olvColumn2,
            this.olvMusic,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn8});
            this.lstMaps.FullRowSelect = true;
            this.lstMaps.Location = new System.Drawing.Point(12, 25);
            this.lstMaps.MultiSelect = false;
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.ShowGroups = false;
            this.lstMaps.Size = new System.Drawing.Size(817, 437);
            this.lstMaps.TabIndex = 4;
            this.lstMaps.UseCompatibleStateImageBehavior = false;
            this.lstMaps.View = System.Windows.Forms.View.Details;
            this.lstMaps.VirtualMode = true;
            this.lstMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMaps_KeyDown);
            this.lstMaps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMaps_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Pid";
            this.olvColumn1.Text = "PID";
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Name";
            this.olvColumn7.Text = "Name";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "FileName";
            this.olvColumn2.Text = "Filename";
            // 
            // olvMusic
            // 
            this.olvMusic.AspectName = "Music";
            this.olvMusic.Text = "Music";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "SoundString";
            this.olvColumn4.Text = "Sound";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ScriptName";
            this.olvColumn5.Text = "Script";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "NoLogout";
            this.olvColumn6.Text = "NoLogout";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Time";
            this.olvColumn8.Text = "Time";
            // 
            // btnRemoveMap
            // 
            this.btnRemoveMap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveMap.Location = new System.Drawing.Point(491, 468);
            this.btnRemoveMap.Name = "btnRemoveMap";
            this.btnRemoveMap.Size = new System.Drawing.Size(140, 26);
            this.btnRemoveMap.TabIndex = 5;
            this.btnRemoveMap.Text = "Remove Selected";
            this.btnRemoveMap.UseVisualStyleBackColor = true;
            this.btnRemoveMap.Click += new System.EventHandler(this.btnRemoveMap_Click);
            // 
            // btnEditInMapper
            // 
            this.btnEditInMapper.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditInMapper.Location = new System.Drawing.Point(382, 468);
            this.btnEditInMapper.Name = "btnEditInMapper";
            this.btnEditInMapper.Size = new System.Drawing.Size(103, 25);
            this.btnEditInMapper.TabIndex = 6;
            this.btnEditInMapper.Text = "Open In Mapper";
            this.btnEditInMapper.UseVisualStyleBackColor = true;
            this.btnEditInMapper.Click += new System.EventHandler(this.btnEditInMapper_Click);
            // 
            // frmMapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 543);
            this.Controls.Add(this.btnEditInMapper);
            this.Controls.Add(this.btnRemoveMap);
            this.Controls.Add(this.lstMaps);
            this.Controls.Add(this.btnAddNewMap);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(849, 570);
            this.Name = "frmMapEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mapdata Editor";
            this.Load += new System.EventHandler(this.frmEditMaps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstMaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAddNewMap;
        private BrightIdeasSoftware.FastObjectListView lstMaps;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.Button btnRemoveMap;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvMusic;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.Button btnEditInMapper;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
    }
}