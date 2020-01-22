namespace WorldEditor
{
    partial class frmZoneValueDisplay
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
            this.txtZoneValue = new System.Windows.Forms.TextBox();
            this.btnDisplayZones = new System.Windows.Forms.Button();
            this.chkDisplay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ZoneValue String:";
            // 
            // txtZoneValue
            // 
            this.txtZoneValue.Location = new System.Drawing.Point(138, 6);
            this.txtZoneValue.Name = "txtZoneValue";
            this.txtZoneValue.Size = new System.Drawing.Size(254, 20);
            this.txtZoneValue.TabIndex = 1;
            // 
            // btnDisplayZones
            // 
            this.btnDisplayZones.Location = new System.Drawing.Point(95, 64);
            this.btnDisplayZones.Name = "btnDisplayZones";
            this.btnDisplayZones.Size = new System.Drawing.Size(189, 23);
            this.btnDisplayZones.TabIndex = 2;
            this.btnDisplayZones.Text = "Done";
            this.btnDisplayZones.UseVisualStyleBackColor = true;
            this.btnDisplayZones.Click += new System.EventHandler(this.btnDisplayZones_Click);
            // 
            // chkDisplay
            // 
            this.chkDisplay.AutoSize = true;
            this.chkDisplay.Location = new System.Drawing.Point(138, 32);
            this.chkDisplay.Name = "chkDisplay";
            this.chkDisplay.Size = new System.Drawing.Size(126, 17);
            this.chkDisplay.TabIndex = 3;
            this.chkDisplay.Text = "Display on Worldmap";
            this.chkDisplay.UseVisualStyleBackColor = true;
            // 
            // frmZoneValueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 99);
            this.Controls.Add(this.chkDisplay);
            this.Controls.Add(this.btnDisplayZones);
            this.Controls.Add(this.txtZoneValue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmZoneValueDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZoneValue Display";
            this.Load += new System.EventHandler(this.frmZoneValueDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZoneValue;
        private System.Windows.Forms.Button btnDisplayZones;
        private System.Windows.Forms.CheckBox chkDisplay;
    }
}