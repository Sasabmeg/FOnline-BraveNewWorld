namespace WorldEditor.NZone.EncounterGroup
{
    partial class frmFilter
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
            this.chkEnableFilter = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.chkNpc = new System.Windows.Forms.CheckBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.numNPCPID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkPerk = new System.Windows.Forms.CheckBox();
            this.cmbPerk = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNPCPID)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEnableFilter
            // 
            this.chkEnableFilter.AutoSize = true;
            this.chkEnableFilter.Location = new System.Drawing.Point(12, 12);
            this.chkEnableFilter.Name = "chkEnableFilter";
            this.chkEnableFilter.Size = new System.Drawing.Size(81, 17);
            this.chkEnableFilter.TabIndex = 0;
            this.chkEnableFilter.Text = "Enable filter";
            this.chkEnableFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPerk);
            this.groupBox1.Controls.Add(this.chkPerk);
            this.groupBox1.Controls.Add(this.chkItem);
            this.groupBox1.Controls.Add(this.chkNpc);
            this.groupBox1.Controls.Add(this.cmbItem);
            this.groupBox1.Controls.Add(this.numNPCPID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(9, 67);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(89, 17);
            this.chkItem.TabIndex = 6;
            this.chkItem.Text = "Contains item";
            this.chkItem.UseVisualStyleBackColor = true;
            // 
            // chkNpc
            // 
            this.chkNpc.AutoSize = true;
            this.chkNpc.Location = new System.Drawing.Point(9, 40);
            this.chkNpc.Name = "chkNpc";
            this.chkNpc.Size = new System.Drawing.Size(187, 17);
            this.chkNpc.TabIndex = 5;
            this.chkNpc.Text = "Contains at least an NPC with PID";
            this.chkNpc.UseVisualStyleBackColor = true;
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.DropDownWidth = 400;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(208, 65);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(122, 21);
            this.cmbItem.TabIndex = 4;
            // 
            // numNPCPID
            // 
            this.numNPCPID.Location = new System.Drawing.Point(208, 39);
            this.numNPCPID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNPCPID.Name = "numNPCPID";
            this.numNPCPID.Size = new System.Drawing.Size(64, 20);
            this.numNPCPID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show groups meeting follow criteria:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(132, 171);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 24);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkPerk
            // 
            this.chkPerk.AutoSize = true;
            this.chkPerk.Location = new System.Drawing.Point(9, 94);
            this.chkPerk.Name = "chkPerk";
            this.chkPerk.Size = new System.Drawing.Size(92, 17);
            this.chkPerk.TabIndex = 7;
            this.chkPerk.Text = "Contains Perk";
            this.chkPerk.UseVisualStyleBackColor = true;
            // 
            // cmbPerk
            // 
            this.cmbPerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerk.DropDownWidth = 400;
            this.cmbPerk.FormattingEnabled = true;
            this.cmbPerk.Location = new System.Drawing.Point(208, 92);
            this.cmbPerk.Name = "cmbPerk";
            this.cmbPerk.Size = new System.Drawing.Size(122, 21);
            this.cmbPerk.TabIndex = 8;
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 207);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkEnableFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter Groups";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNPCPID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.NumericUpDown numNPCPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.CheckBox chkNpc;
        private System.Windows.Forms.ComboBox cmbPerk;
        private System.Windows.Forms.CheckBox chkPerk;
    }
}