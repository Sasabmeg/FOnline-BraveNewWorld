namespace WorldEditor
{
    partial class frmAddMaps
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
            this.lstMaps = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAddMaps = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMaps
            // 
            this.lstMaps.AllColumns.Add(this.olvColumn1);
            this.lstMaps.AllColumns.Add(this.olvColumn7);
            this.lstMaps.AllColumns.Add(this.olvColumn2);
            this.lstMaps.AllColumns.Add(this.olvColumn3);
            this.lstMaps.AllColumns.Add(this.olvColumn4);
            this.lstMaps.AllColumns.Add(this.olvColumn5);
            this.lstMaps.AllColumns.Add(this.olvColumn6);
            this.lstMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn7,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.lstMaps.FullRowSelect = true;
            this.lstMaps.Location = new System.Drawing.Point(12, 12);
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.ShowGroups = false;
            this.lstMaps.Size = new System.Drawing.Size(809, 540);
            this.lstMaps.TabIndex = 5;
            this.lstMaps.UseCompatibleStateImageBehavior = false;
            this.lstMaps.View = System.Windows.Forms.View.Details;
            this.lstMaps.VirtualMode = true;
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
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Music";
            this.olvColumn3.Text = "Music";
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
            // btnAddMaps
            // 
            this.btnAddMaps.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddMaps.Location = new System.Drawing.Point(225, 558);
            this.btnAddMaps.Name = "btnAddMaps";
            this.btnAddMaps.Size = new System.Drawing.Size(168, 26);
            this.btnAddMaps.TabIndex = 6;
            this.btnAddMaps.Text = "Add Map(s)";
            this.btnAddMaps.UseVisualStyleBackColor = true;
            this.btnAddMaps.Click += new System.EventHandler(this.btnAddMaps_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(399, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 596);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMaps);
            this.Controls.Add(this.lstMaps);
            this.Name = "frmAddMaps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add map(s) to location";
            this.Load += new System.EventHandler(this.frmAddMaps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstMaps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lstMaps;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.Button btnAddMaps;
        private System.Windows.Forms.Button btnCancel;
    }
}