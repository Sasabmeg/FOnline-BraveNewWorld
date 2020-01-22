namespace WorldEditor
{
    partial class frmSpecialEncounters
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
            this.lstSpecialEncounters = new BrightIdeasSoftware.FastObjectListView();
            this.lblSpecialEncounters = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstSpecialEncounters)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSpecialEncounters
            // 
            this.lstSpecialEncounters.Location = new System.Drawing.Point(12, 25);
            this.lstSpecialEncounters.Name = "lstSpecialEncounters";
            this.lstSpecialEncounters.ShowGroups = false;
            this.lstSpecialEncounters.Size = new System.Drawing.Size(715, 390);
            this.lstSpecialEncounters.TabIndex = 0;
            this.lstSpecialEncounters.UseCompatibleStateImageBehavior = false;
            this.lstSpecialEncounters.View = System.Windows.Forms.View.Details;
            this.lstSpecialEncounters.VirtualMode = true;
            // 
            // lblSpecialEncounters
            // 
            this.lblSpecialEncounters.AutoSize = true;
            this.lblSpecialEncounters.Location = new System.Drawing.Point(12, 9);
            this.lblSpecialEncounters.Name = "lblSpecialEncounters";
            this.lblSpecialEncounters.Size = new System.Drawing.Size(102, 13);
            this.lblSpecialEncounters.TabIndex = 1;
            this.lblSpecialEncounters.Text = "Special Encounters:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(195, 421);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(158, 26);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New Special Encounter";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(365, 421);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 25);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Special Encounter";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // frmSpecialEncounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 457);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblSpecialEncounters);
            this.Controls.Add(this.lstSpecialEncounters);
            this.Name = "frmSpecialEncounters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Special Encounters Editor";
            this.Load += new System.EventHandler(this.frmSpecialEncounters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstSpecialEncounters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView lstSpecialEncounters;
        private System.Windows.Forms.Label lblSpecialEncounters;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemove;
    }
}