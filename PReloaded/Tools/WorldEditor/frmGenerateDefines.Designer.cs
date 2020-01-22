namespace WorldEditor
{
    partial class frmGenerateDefines
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkMaps = new System.Windows.Forms.CheckBox();
            this.chkDialogs = new System.Windows.Forms.CheckBox();
            this.chkNpcPids = new System.Windows.Forms.CheckBox();
            this.chkEnum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point( 94, 118 );
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size( 143, 23 );
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler( this.btnGenerate_Click );
            // 
            // chkMaps
            // 
            this.chkMaps.AutoSize = true;
            this.chkMaps.Location = new System.Drawing.Point( 13, 13 );
            this.chkMaps.Name = "chkMaps";
            this.chkMaps.Size = new System.Drawing.Size( 247, 17 );
            this.chkMaps.TabIndex = 1;
            this.chkMaps.Text = "_maps.fos - Generates Maps/Location defines.";
            this.chkMaps.UseVisualStyleBackColor = true;
            // 
            // chkDialogs
            // 
            this.chkDialogs.AutoSize = true;
            this.chkDialogs.Location = new System.Drawing.Point( 13, 37 );
            this.chkDialogs.Name = "chkDialogs";
            this.chkDialogs.Size = new System.Drawing.Size( 82, 17 );
            this.chkDialogs.TabIndex = 2;
            this.chkDialogs.Text = "_dialogs.fos";
            this.chkDialogs.UseVisualStyleBackColor = true;
            // 
            // chkNpcPids
            // 
            this.chkNpcPids.AutoSize = true;
            this.chkNpcPids.Location = new System.Drawing.Point( 13, 61 );
            this.chkNpcPids.Name = "chkNpcPids";
            this.chkNpcPids.Size = new System.Drawing.Size( 92, 17 );
            this.chkNpcPids.TabIndex = 3;
            this.chkNpcPids.Text = "_npc_pids.fos";
            this.chkNpcPids.UseVisualStyleBackColor = true;
            // 
            // chkEnum
            // 
            this.chkEnum.AutoSize = true;
            this.chkEnum.Location = new System.Drawing.Point( 13, 95 );
            this.chkEnum.Name = "chkEnum";
            this.chkEnum.Size = new System.Drawing.Size( 86, 17 );
            this.chkEnum.TabIndex = 4;
            this.chkEnum.Text = "Create enum";
            this.chkEnum.UseVisualStyleBackColor = true;
            // 
            // frmGenerateDefines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 340, 156 );
            this.Controls.Add( this.chkEnum );
            this.Controls.Add( this.chkNpcPids );
            this.Controls.Add( this.chkDialogs );
            this.Controls.Add( this.chkMaps );
            this.Controls.Add( this.btnGenerate );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGenerateDefines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate Defines";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkMaps;
        private System.Windows.Forms.CheckBox chkDialogs;
        private System.Windows.Forms.CheckBox chkNpcPids;
        private System.Windows.Forms.CheckBox chkEnum;
    }
}