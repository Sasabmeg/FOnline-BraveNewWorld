namespace TiledMapper
{
    partial class CompilerForm
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
            this.lbPresets = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cbCurrent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNeverShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbPresets
            // 
            this.lbPresets.Enabled = false;
            this.lbPresets.FormattingEnabled = true;
            this.lbPresets.Location = new System.Drawing.Point(12, 85);
            this.lbPresets.Name = "lbPresets";
            this.lbPresets.Size = new System.Drawing.Size(360, 134);
            this.lbPresets.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(347, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(25, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Location = new System.Drawing.Point(102, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(219, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Presets path";
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(93, 9);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(248, 20);
            this.tbPath.TabIndex = 0;
            // 
            // cbCurrent
            // 
            this.cbCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrent.FormattingEnabled = true;
            this.cbCurrent.Location = new System.Drawing.Point(91, 35);
            this.cbCurrent.Name = "cbCurrent";
            this.cbCurrent.Size = new System.Drawing.Size(281, 21);
            this.cbCurrent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current preset";
            // 
            // cbNeverShow
            // 
            this.cbNeverShow.AutoSize = true;
            this.cbNeverShow.Location = new System.Drawing.Point(210, 62);
            this.cbNeverShow.Name = "cbNeverShow";
            this.cbNeverShow.Size = new System.Drawing.Size(162, 17);
            this.cbNeverShow.TabIndex = 8;
            this.cbNeverShow.Text = "Don\'t show header data form";
            this.cbNeverShow.UseVisualStyleBackColor = true;
            // 
            // CompilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.cbNeverShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCurrent);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lbPresets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 292);
            this.Name = "CompilerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Compiler Options";
            this.Load += new System.EventHandler(this.CompilerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPresets;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ComboBox cbCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbNeverShow;
    }
}