namespace WorldEditor
{
    partial class frmShell
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
            this.csl = new WorldEditor.Controls.Console();
            this.SuspendLayout();
            // 
            // csl
            // 
            this.csl.BackColor = System.Drawing.Color.Black;
            this.csl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.csl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csl.ForeColor = System.Drawing.Color.Orange;
            this.csl.Location = new System.Drawing.Point(0, 0);
            this.csl.Name = "csl";
            this.csl.Size = new System.Drawing.Size(624, 433);
            this.csl.TabIndex = 0;
            this.csl.Text = "";
            this.csl.WordWrap = false;
            this.csl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.csl_KeyDown);
            // 
            // frmShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 433);
            this.Controls.Add(this.csl);
            this.Name = "frmShell";
            this.Text = "FOnline Shell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShell_FormClosing);
            this.Load += new System.EventHandler(this.frmShell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Console csl;
    }
}