namespace WorldEditor
{
    partial class frmAddGroup
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numEncounterQuantity = new System.Windows.Forms.NumericUpDown();
            this.lstGroups = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.numEncounterQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 22);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 22);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encounter Quantity:";
            // 
            // numEncounterQuantity
            // 
            this.numEncounterQuantity.Location = new System.Drawing.Point(117, 7);
            this.numEncounterQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEncounterQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEncounterQuantity.Name = "numEncounterQuantity";
            this.numEncounterQuantity.Size = new System.Drawing.Size(80, 20);
            this.numEncounterQuantity.TabIndex = 7;
            this.numEncounterQuantity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lstGroups
            // 
            this.lstGroups.AllColumns.Add(this.olvColumn1);
            this.lstGroups.AllColumns.Add(this.olvColumn12);
            this.lstGroups.AllColumns.Add(this.olvColumn2);
            this.lstGroups.AllColumns.Add(this.olvColumn15);
            this.lstGroups.AllColumns.Add(this.olvColumn16);
            this.lstGroups.AllowColumnReorder = true;
            this.lstGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn12,
            this.olvColumn2,
            this.olvColumn15,
            this.olvColumn16});
            this.lstGroups.FullRowSelect = true;
            this.lstGroups.Location = new System.Drawing.Point(15, 40);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.SelectAllOnControlA = false;
            this.lstGroups.ShowGroups = false;
            this.lstGroups.Size = new System.Drawing.Size(637, 630);
            this.lstGroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstGroups.TabIndex = 8;
            this.lstGroups.TintSortColumn = true;
            this.lstGroups.UseCompatibleStateImageBehavior = false;
            this.lstGroups.View = System.Windows.Forms.View.Details;
            this.lstGroups.VirtualMode = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 175;
            // 
            // olvColumn12
            // 
            this.olvColumn12.AspectName = "GMName";
            this.olvColumn12.Text = "Game Name";
            this.olvColumn12.Width = 150;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "NpcCount";
            this.olvColumn2.Text = "NPC Count";
            this.olvColumn2.ToolTipText = "Number of NPCs in group";
            this.olvColumn2.Width = 80;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "FactionId";
            this.olvColumn15.Text = "Faction Id";
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "FactionName";
            this.olvColumn16.Text = "Faction Name";
            this.olvColumn16.Width = 140;
            // 
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 682);
            this.Controls.Add(this.lstGroups);
            this.Controls.Add(this.numEncounterQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Location = new System.Drawing.Point(685, 0);
            this.Name = "frmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add New Group(s)";
            ((System.ComponentModel.ISupportInitialize)(this.numEncounterQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEncounterQuantity;
        private BrightIdeasSoftware.FastObjectListView lstGroups;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn12;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
    }
}