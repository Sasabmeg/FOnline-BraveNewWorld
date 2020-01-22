namespace WorldEditor
{
    partial class frmSettingsCopying
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
            this.btnOk = new System.Windows.Forms.Button();
            this.chkGroups = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLocations = new System.Windows.Forms.CheckBox();
            this.chkTerrain = new System.Windows.Forms.CheckBox();
            this.chkDifficulty = new System.Windows.Forms.CheckBox();
            this.chkChance = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.chkFlags = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(102, 171);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(66, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkGroups
            // 
            this.chkGroups.AutoSize = true;
            this.chkGroups.Checked = true;
            this.chkGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroups.Location = new System.Drawing.Point(12, 46);
            this.chkGroups.Name = "chkGroups";
            this.chkGroups.Size = new System.Drawing.Size(112, 17);
            this.chkGroups.TabIndex = 1;
            this.chkGroups.Text = "Encounter Groups";
            this.chkGroups.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // chkLocations
            // 
            this.chkLocations.AutoSize = true;
            this.chkLocations.Checked = true;
            this.chkLocations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLocations.Location = new System.Drawing.Point(12, 69);
            this.chkLocations.Name = "chkLocations";
            this.chkLocations.Size = new System.Drawing.Size(124, 17);
            this.chkLocations.TabIndex = 3;
            this.chkLocations.Text = "Encounter Locations";
            this.chkLocations.UseVisualStyleBackColor = true;
            // 
            // chkTerrain
            // 
            this.chkTerrain.AutoSize = true;
            this.chkTerrain.Checked = true;
            this.chkTerrain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTerrain.Location = new System.Drawing.Point(144, 92);
            this.chkTerrain.Name = "chkTerrain";
            this.chkTerrain.Size = new System.Drawing.Size(86, 17);
            this.chkTerrain.TabIndex = 4;
            this.chkTerrain.Text = "Terrain Type";
            this.chkTerrain.UseVisualStyleBackColor = true;
            // 
            // chkDifficulty
            // 
            this.chkDifficulty.AutoSize = true;
            this.chkDifficulty.Checked = true;
            this.chkDifficulty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDifficulty.Location = new System.Drawing.Point(144, 46);
            this.chkDifficulty.Name = "chkDifficulty";
            this.chkDifficulty.Size = new System.Drawing.Size(66, 17);
            this.chkDifficulty.TabIndex = 5;
            this.chkDifficulty.Text = "Difficulty";
            this.chkDifficulty.UseVisualStyleBackColor = true;
            // 
            // chkChance
            // 
            this.chkChance.AutoSize = true;
            this.chkChance.Checked = true;
            this.chkChance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChance.Location = new System.Drawing.Point(144, 69);
            this.chkChance.Name = "chkChance";
            this.chkChance.Size = new System.Drawing.Size(63, 17);
            this.chkChance.TabIndex = 6;
            this.chkChance.Text = "Chance";
            this.chkChance.UseVisualStyleBackColor = true;
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Checked = true;
            this.chkOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwrite.Location = new System.Drawing.Point(12, 130);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(189, 17);
            this.chkOverwrite.TabIndex = 7;
            this.chkOverwrite.Text = "Overwrite Groups/Locations/Flags";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // chkFlags
            // 
            this.chkFlags.AutoSize = true;
            this.chkFlags.Location = new System.Drawing.Point(12, 92);
            this.chkFlags.Name = "chkFlags";
            this.chkFlags.Size = new System.Drawing.Size(51, 17);
            this.chkFlags.TabIndex = 8;
            this.chkFlags.Text = "Flags";
            this.chkFlags.UseVisualStyleBackColor = true;
            // 
            // frmSettingsCopying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 208);
            this.Controls.Add(this.chkFlags);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.chkChance);
            this.Controls.Add(this.chkDifficulty);
            this.Controls.Add(this.chkTerrain);
            this.Controls.Add(this.chkLocations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkGroups);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettingsCopying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings - Cloning";
            this.Load += new System.EventHandler(this.frmSettingsCopying_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLocations;
        private System.Windows.Forms.CheckBox chkTerrain;
        private System.Windows.Forms.CheckBox chkDifficulty;
        private System.Windows.Forms.CheckBox chkChance;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.CheckBox chkFlags;
    }
}