namespace ScriptHost.Forms
{
    partial class frmScriptsLoaded
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
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.lstScripts)).BeginInit();
            this.SuspendLayout();
            // 
            // lstScripts
            // 
            this.lstScripts.AllColumns.Add(this.olvName);
            this.lstScripts.AllColumns.Add(this.olvColumn1);
            this.lstScripts.AllColumns.Add(this.olvColumn2);
            this.lstScripts.AllColumns.Add(this.olvColumn3);
            this.lstScripts.AllColumns.Add(this.olvColumn4);
            this.lstScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScripts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.lstScripts.FullRowSelect = true;
            this.lstScripts.GridLines = true;
            this.lstScripts.Location = new System.Drawing.Point(13, 13);
            this.lstScripts.Name = "lstScripts";
            this.lstScripts.ShowGroups = false;
            this.lstScripts.Size = new System.Drawing.Size(495, 333);
            this.lstScripts.TabIndex = 0;
            this.lstScripts.UseCompatibleStateImageBehavior = false;
            this.lstScripts.View = System.Windows.Forms.View.Details;
            this.lstScripts.VirtualMode = true;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.Text = "Name";
            this.olvName.Width = 100;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Author";
            this.olvColumn1.Text = "Author";
            this.olvColumn1.Width = 100;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Description";
            this.olvColumn2.Text = "Description";
            this.olvColumn2.Width = 150;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Version";
            this.olvColumn3.Text = "Version";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "FileName";
            this.olvColumn4.Text = "Path";
            // 
            // frmScriptsLoaded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 358);
            this.Controls.Add(this.lstScripts);
            this.Name = "frmScriptsLoaded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loaded Extensions";
            this.Shown += new System.EventHandler(this.frmScriptsLoaded_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lstScripts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lstScripts;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}