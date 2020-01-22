namespace WorldEditor
{
    partial class frmScriptList
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
            this.lstScripts = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.lstScripts)).BeginInit();
            this.SuspendLayout();
            // 
            // lstScripts
            // 
            this.lstScripts.AllColumns.Add(this.olvColumn3);
            this.lstScripts.AllColumns.Add(this.olvColumn5);
            this.lstScripts.AllColumns.Add(this.olvColumn4);
            this.lstScripts.AllColumns.Add(this.olvColumn1);
            this.lstScripts.AllColumns.Add(this.olvColumn2);
            this.lstScripts.AllColumns.Add(this.olvColumn6);
            this.lstScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScripts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn5,
            this.olvColumn4,
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn6});
            this.lstScripts.FullRowSelect = true;
            this.lstScripts.Location = new System.Drawing.Point(12, 12);
            this.lstScripts.Name = "lstScripts";
            this.lstScripts.ShowGroups = false;
            this.lstScripts.Size = new System.Drawing.Size(838, 546);
            this.lstScripts.TabIndex = 0;
            this.lstScripts.UseCompatibleStateImageBehavior = false;
            this.lstScripts.View = System.Windows.Forms.View.Details;
            this.lstScripts.VirtualMode = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 150;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Description";
            this.olvColumn2.Text = "Description";
            this.olvColumn2.Width = 200;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Enabled";
            this.olvColumn3.Text = "Enabled";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Type";
            this.olvColumn4.Text = "Type";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "App";
            this.olvColumn5.Text = "Application";
            this.olvColumn5.Width = 90;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "ReservedPlace";
            this.olvColumn6.Text = "ReservedPlace";
            this.olvColumn6.Width = 180;
            // 
            // frmScriptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 570);
            this.Controls.Add(this.lstScripts);
            this.Name = "frmScriptList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scriptlist";
            this.Load += new System.EventHandler(this.frmScriptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstScripts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lstScripts;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
    }
}