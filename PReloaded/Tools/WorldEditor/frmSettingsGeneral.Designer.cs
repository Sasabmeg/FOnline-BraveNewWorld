namespace WorldEditor
{
    partial class frmSettingsGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingsGeneral));
            this.btnOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.chkDisplayLocationNames = new System.Windows.Forms.CheckBox();
            this.chkDisplayLocations = new System.Windows.Forms.CheckBox();
            this.chkDisplayToolTip = new System.Windows.Forms.CheckBox();
            this.tabZone = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBrushed = new FOCommon.Controls.ColorComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModified = new FOCommon.Controls.ColorComboBox();
            this.cmbFiltered = new FOCommon.Controls.ColorComboBox();
            this.cmbImplemented = new FOCommon.Controls.ColorComboBox();
            this.cmbSelected = new FOCommon.Controls.ColorComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabZone.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(83, 270);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(202, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabZone);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 252);
            this.tabControl1.TabIndex = 6;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.chkDisplayLocationNames);
            this.tabGeneral.Controls.Add(this.chkDisplayLocations);
            this.tabGeneral.Controls.Add(this.chkDisplayToolTip);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(335, 226);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // chkDisplayLocationNames
            // 
            this.chkDisplayLocationNames.AutoSize = true;
            this.chkDisplayLocationNames.Location = new System.Drawing.Point(16, 40);
            this.chkDisplayLocationNames.Name = "chkDisplayLocationNames";
            this.chkDisplayLocationNames.Size = new System.Drawing.Size(135, 17);
            this.chkDisplayLocationNames.TabIndex = 8;
            this.chkDisplayLocationNames.Text = "Display Locationnames";
            this.chkDisplayLocationNames.UseVisualStyleBackColor = true;
            // 
            // chkDisplayLocations
            // 
            this.chkDisplayLocations.AutoSize = true;
            this.chkDisplayLocations.Location = new System.Drawing.Point(16, 17);
            this.chkDisplayLocations.Name = "chkDisplayLocations";
            this.chkDisplayLocations.Size = new System.Drawing.Size(109, 17);
            this.chkDisplayLocations.TabIndex = 7;
            this.chkDisplayLocations.Text = "Display Locations";
            this.chkDisplayLocations.UseVisualStyleBackColor = true;
            this.chkDisplayLocations.CheckedChanged += new System.EventHandler(this.chkDisplayLocations_CheckedChanged);
            // 
            // chkDisplayToolTip
            // 
            this.chkDisplayToolTip.AutoSize = true;
            this.chkDisplayToolTip.Location = new System.Drawing.Point(16, 62);
            this.chkDisplayToolTip.Name = "chkDisplayToolTip";
            this.chkDisplayToolTip.Size = new System.Drawing.Size(143, 17);
            this.chkDisplayToolTip.TabIndex = 6;
            this.chkDisplayToolTip.Text = "Display Location ToolTip";
            this.chkDisplayToolTip.UseVisualStyleBackColor = true;
            // 
            // tabZone
            // 
            this.tabZone.Controls.Add(this.groupBox1);
            this.tabZone.Location = new System.Drawing.Point(4, 22);
            this.tabZone.Name = "tabZone";
            this.tabZone.Padding = new System.Windows.Forms.Padding(3);
            this.tabZone.Size = new System.Drawing.Size(335, 226);
            this.tabZone.TabIndex = 1;
            this.tabZone.Text = "Zone";
            this.tabZone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBrushed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbModified);
            this.groupBox1.Controls.Add(this.cmbFiltered);
            this.groupBox1.Controls.Add(this.cmbImplemented);
            this.groupBox1.Controls.Add(this.cmbSelected);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Colors";
            // 
            // cmbBrushed
            // 
            this.cmbBrushed.Color = System.Drawing.Color.Black;
            this.cmbBrushed.CustomColor = System.Drawing.Color.Empty;
            this.cmbBrushed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrushed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrushed.FormattingEnabled = true;
            this.cmbBrushed.Location = new System.Drawing.Point(129, 133);
            this.cmbBrushed.Name = "cmbBrushed";
            this.cmbBrushed.Size = new System.Drawing.Size(188, 21);
            this.cmbBrushed.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Brushed Zones:";
            // 
            // cmbModified
            // 
            this.cmbModified.Color = System.Drawing.Color.Black;
            this.cmbModified.CustomColor = System.Drawing.Color.Empty;
            this.cmbModified.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModified.FormattingEnabled = true;
            this.cmbModified.Location = new System.Drawing.Point(129, 104);
            this.cmbModified.Name = "cmbModified";
            this.cmbModified.Size = new System.Drawing.Size(188, 21);
            this.cmbModified.TabIndex = 7;
            // 
            // cmbFiltered
            // 
            this.cmbFiltered.Color = System.Drawing.Color.Black;
            this.cmbFiltered.CustomColor = System.Drawing.Color.Empty;
            this.cmbFiltered.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltered.FormattingEnabled = true;
            this.cmbFiltered.Location = new System.Drawing.Point(129, 77);
            this.cmbFiltered.Name = "cmbFiltered";
            this.cmbFiltered.Size = new System.Drawing.Size(188, 21);
            this.cmbFiltered.TabIndex = 6;
            // 
            // cmbImplemented
            // 
            this.cmbImplemented.Color = System.Drawing.Color.Black;
            this.cmbImplemented.CustomColor = System.Drawing.Color.Empty;
            this.cmbImplemented.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbImplemented.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImplemented.FormattingEnabled = true;
            this.cmbImplemented.Location = new System.Drawing.Point(129, 50);
            this.cmbImplemented.Name = "cmbImplemented";
            this.cmbImplemented.Size = new System.Drawing.Size(188, 21);
            this.cmbImplemented.TabIndex = 5;
            // 
            // cmbSelected
            // 
            this.cmbSelected.Color = System.Drawing.Color.Black;
            this.cmbSelected.CustomColor = System.Drawing.Color.Empty;
            this.cmbSelected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelected.FormattingEnabled = true;
            this.cmbSelected.Location = new System.Drawing.Point(129, 22);
            this.cmbSelected.Name = "cmbSelected";
            this.cmbSelected.Size = new System.Drawing.Size(188, 21);
            this.cmbSelected.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Zone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modified Zones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtered Zones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Implemented Zones:";
            // 
            // frmSettingsGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 306);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettingsGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings - General Settings";
            this.Load += new System.EventHandler(this.frmSettingsGeneral_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabZone.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.CheckBox chkDisplayLocationNames;
        private System.Windows.Forms.CheckBox chkDisplayLocations;
        private System.Windows.Forms.CheckBox chkDisplayToolTip;
        private System.Windows.Forms.TabPage tabZone;
        private System.Windows.Forms.GroupBox groupBox1;
        
        private System.Windows.Forms.Label label5;
        private FOCommon.Controls.ColorComboBox cmbModified;
        private FOCommon.Controls.ColorComboBox cmbFiltered;
        private FOCommon.Controls.ColorComboBox cmbImplemented;
        private FOCommon.Controls.ColorComboBox cmbSelected;
        private FOCommon.Controls.ColorComboBox cmbBrushed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}