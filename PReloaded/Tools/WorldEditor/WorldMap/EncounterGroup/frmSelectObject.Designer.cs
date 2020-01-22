namespace WorldEditor.NZone.EncounterGroup
{
    partial class frmSelectObject
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
            this.lstObjects = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSomeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lstObjects
            // 
            this.lstObjects.AllColumns.Add(this.olvColumn1);
            this.lstObjects.AllColumns.Add(this.olvColumn2);
            this.lstObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.lstObjects.FullRowSelect = true;
            this.lstObjects.Location = new System.Drawing.Point(12, 26);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.ShowGroups = false;
            this.lstObjects.Size = new System.Drawing.Size(337, 280);
            this.lstObjects.TabIndex = 0;
            this.lstObjects.UseCompatibleStateImageBehavior = false;
            this.lstObjects.View = System.Windows.Forms.View.Details;
            this.lstObjects.VirtualMode = true;
            this.lstObjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstObjects_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "Id";
            this.olvColumn1.Width = 40;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 200;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(132, 312);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSomeText
            // 
            this.lblSomeText.AutoSize = true;
            this.lblSomeText.Location = new System.Drawing.Point(9, 9);
            this.lblSomeText.Name = "lblSomeText";
            this.lblSomeText.Size = new System.Drawing.Size(81, 13);
            this.lblSomeText.TabIndex = 2;
            this.lblSomeText.Text = "SomeText Here";
            // 
            // frmSelectObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 348);
            this.Controls.Add(this.lblSomeText);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstObjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 376);
            this.Name = "frmSelectObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.frmSelectProto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lstObjects;
        private System.Windows.Forms.Button btnOk;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Label lblSomeText;
    }
}