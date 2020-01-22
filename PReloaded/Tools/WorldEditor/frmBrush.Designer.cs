namespace WorldEditor
{
    partial class frmBrush
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
            this.btnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.numEncounterQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblChance = new System.Windows.Forms.Label();
            this.tabBrushes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstFlags = new System.Windows.Forms.ListBox();
            this.chkOverwriteChance = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEncounterQuantity)).BeginInit();
            this.tabBrushes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select which encounter locations/groups you want to target with brush:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(5, 463);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 27);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(569, 463);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 27);
            this.BtnCancel.TabIndex = 36;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // numEncounterQuantity
            // 
            this.numEncounterQuantity.Location = new System.Drawing.Point(107, 28);
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
            this.numEncounterQuantity.TabIndex = 39;
            this.numEncounterQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChance
            // 
            this.lblChance.AutoSize = true;
            this.lblChance.Location = new System.Drawing.Point(2, 30);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(101, 13);
            this.lblChance.TabIndex = 38;
            this.lblChance.Text = "Encounter Quantity:";
            // 
            // tabBrushes
            // 
            this.tabBrushes.Controls.Add(this.tabPage1);
            this.tabBrushes.Controls.Add(this.tabPage2);
            this.tabBrushes.Location = new System.Drawing.Point(5, 46);
            this.tabBrushes.Name = "tabBrushes";
            this.tabBrushes.SelectedIndex = 0;
            this.tabBrushes.Size = new System.Drawing.Size(692, 411);
            this.tabBrushes.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstGroups);
            this.tabPage1.Controls.Add(this.lstLocations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encounters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstGroups
            // 
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.Location = new System.Drawing.Point(3, 3);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGroups.Size = new System.Drawing.Size(675, 186);
            this.lstGroups.TabIndex = 39;
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(3, 193);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLocations.Size = new System.Drawing.Size(675, 186);
            this.lstLocations.TabIndex = 38;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstFlags);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(684, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flags";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstFlags
            // 
            this.lstFlags.FormattingEnabled = true;
            this.lstFlags.Location = new System.Drawing.Point(3, 6);
            this.lstFlags.Name = "lstFlags";
            this.lstFlags.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFlags.Size = new System.Drawing.Size(675, 368);
            this.lstFlags.TabIndex = 40;
            // 
            // chkOverwriteChance
            // 
            this.chkOverwriteChance.AutoSize = true;
            this.chkOverwriteChance.Location = new System.Drawing.Point(202, 31);
            this.chkOverwriteChance.Name = "chkOverwriteChance";
            this.chkOverwriteChance.Size = new System.Drawing.Size(218, 17);
            this.chkOverwriteChance.TabIndex = 41;
            this.chkOverwriteChance.Text = "Overwrite quantity, if group already exists";
            this.chkOverwriteChance.UseVisualStyleBackColor = true;
            // 
            // frmBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.chkOverwriteChance);
            this.Controls.Add(this.tabBrushes);
            this.Controls.Add(this.numEncounterQuantity);
            this.Controls.Add(this.lblChance);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(370, 381);
            this.Name = "frmBrush";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brush - Select targets";
            this.Load += new System.EventHandler(this.frmErase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEncounterQuantity)).EndInit();
            this.tabBrushes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.NumericUpDown numEncounterQuantity;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.TabControl tabBrushes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstFlags;
        private System.Windows.Forms.CheckBox chkOverwriteChance;
    }
}