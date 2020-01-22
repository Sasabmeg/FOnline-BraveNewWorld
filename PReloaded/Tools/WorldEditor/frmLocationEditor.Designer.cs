namespace WorldEditor
{
    partial class frmLocationEditor
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
            this.lstLocations = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewLocation = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLocations
            // 
            this.lstLocations.AllColumns.Add(this.olvColumn1);
            this.lstLocations.AllColumns.Add(this.olvColumn2);
            this.lstLocations.AllColumns.Add(this.olvColumn3);
            this.lstLocations.AllColumns.Add(this.olvColumn5);
            this.lstLocations.AllColumns.Add(this.olvColumn4);
            this.lstLocations.AllColumns.Add(this.olvColumn6);
            this.lstLocations.AllColumns.Add(this.olvColumn7);
            this.lstLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn5,
            this.olvColumn4,
            this.olvColumn6,
            this.olvColumn7});
            this.lstLocations.FullRowSelect = true;
            this.lstLocations.Location = new System.Drawing.Point(12, 23);
            this.lstLocations.MultiSelect = false;
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.ShowGroups = false;
            this.lstLocations.Size = new System.Drawing.Size(999, 539);
            this.lstLocations.TabIndex = 0;
            this.lstLocations.UseCompatibleStateImageBehavior = false;
            this.lstLocations.View = System.Windows.Forms.View.Details;
            this.lstLocations.VirtualMode = true;
            this.lstLocations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLocations_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Pid";
            this.olvColumn1.Text = "PID";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 150;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "WorldMapDescription";
            this.olvColumn3.Text = "Description";
            this.olvColumn3.Width = 500;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Maps.Count";
            this.olvColumn5.Text = "Map Count";
            this.olvColumn5.Width = 90;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "EntryPoints.Count";
            this.olvColumn4.Text = "Entry Point Count";
            this.olvColumn4.Width = 90;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Visible";
            this.olvColumn6.Text = "Visible";
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "OnWorldmap";
            this.olvColumn7.Text = "On Worldmap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double-click on a location to edit it";
            // 
            // btnAddNewLocation
            // 
            this.btnAddNewLocation.Location = new System.Drawing.Point(306, 568);
            this.btnAddNewLocation.Name = "btnAddNewLocation";
            this.btnAddNewLocation.Size = new System.Drawing.Size(173, 26);
            this.btnAddNewLocation.TabIndex = 2;
            this.btnAddNewLocation.Text = "Add New Location";
            this.btnAddNewLocation.UseVisualStyleBackColor = true;
            this.btnAddNewLocation.Click += new System.EventHandler(this.btnAddNewLocation_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(485, 568);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(173, 26);
            this.btnRemoveSelected.TabIndex = 3;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(396, 600);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(173, 26);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmLocationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 628);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAddNewLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLocations);
            this.Name = "frmLocationEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Location Editor";
            this.Load += new System.EventHandler(this.frmLocationEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lstLocations;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private System.Windows.Forms.Button btnAddNewLocation;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnDone;
    }
}