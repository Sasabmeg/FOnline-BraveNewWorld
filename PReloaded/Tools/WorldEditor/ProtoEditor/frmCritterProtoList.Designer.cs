namespace WorldEditor.ProtoEditor
{
    partial class frmCritterProtoList
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
            this.protoList = new BrightIdeasSoftware.FastObjectListView();
            this.col1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.col2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.col3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.col4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rdbAssignPid = new System.Windows.Forms.RadioButton();
            this.rdbAssignFree = new System.Windows.Forms.RadioButton();
            this.numPid = new System.Windows.Forms.NumericUpDown();
            this.lblCopied = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPid)).BeginInit();
            this.SuspendLayout();
            // 
            // protoList
            // 
            this.protoList.AllColumns.Add(this.col1);
            this.protoList.AllColumns.Add(this.col2);
            this.protoList.AllColumns.Add(this.col3);
            this.protoList.AllColumns.Add(this.col4);
            this.protoList.AllowColumnReorder = true;
            this.protoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.protoList.Cursor = System.Windows.Forms.Cursors.Default;
            this.protoList.Font = new System.Drawing.Font("Tahoma", 8F);
            this.protoList.FullRowSelect = true;
            this.protoList.Location = new System.Drawing.Point(12, 12);
            this.protoList.Name = "protoList";
            this.protoList.ShowGroups = false;
            this.protoList.Size = new System.Drawing.Size(674, 335);
            this.protoList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.protoList.TabIndex = 3;
            this.protoList.UseCompatibleStateImageBehavior = false;
            this.protoList.View = System.Windows.Forms.View.Details;
            this.protoList.VirtualMode = true;
            this.protoList.DoubleClick += new System.EventHandler(this.protoList_DoubleClick);
            this.protoList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.protoList_KeyUp);
            // 
            // col1
            // 
            this.col1.AspectName = "key";
            this.col1.IsEditable = false;
            this.col1.Text = "PID";
            this.col1.Width = 36;
            // 
            // col2
            // 
            this.col2.AspectName = "value.Name";
            this.col2.IsEditable = false;
            this.col2.Text = "Name";
            this.col2.Width = 189;
            // 
            // col3
            // 
            this.col3.AspectName = "value.Desc";
            this.col3.IsEditable = false;
            this.col3.Text = "Description";
            this.col3.Width = 275;
            // 
            // col4
            // 
            this.col4.AspectName = "value.Savefile";
            this.col4.IsEditable = false;
            this.col4.Text = "Save file";
            this.col4.Width = 138;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(9, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(135, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(302, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(563, 369);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 40);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button4_Click);
            // 
            // rdbAssignPid
            // 
            this.rdbAssignPid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAssignPid.AutoSize = true;
            this.rdbAssignPid.Location = new System.Drawing.Point(428, 369);
            this.rdbAssignPid.Name = "rdbAssignPid";
            this.rdbAssignPid.Size = new System.Drawing.Size(14, 13);
            this.rdbAssignPid.TabIndex = 8;
            this.rdbAssignPid.TabStop = true;
            this.rdbAssignPid.UseVisualStyleBackColor = true;
            // 
            // rdbAssignFree
            // 
            this.rdbAssignFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAssignFree.AutoSize = true;
            this.rdbAssignFree.Checked = true;
            this.rdbAssignFree.Location = new System.Drawing.Point(428, 392);
            this.rdbAssignFree.Name = "rdbAssignFree";
            this.rdbAssignFree.Size = new System.Drawing.Size(77, 17);
            this.rdbAssignFree.TabIndex = 9;
            this.rdbAssignFree.TabStop = true;
            this.rdbAssignFree.Text = "Assign free";
            this.rdbAssignFree.UseVisualStyleBackColor = true;
            // 
            // numPid
            // 
            this.numPid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPid.Location = new System.Drawing.Point(448, 366);
            this.numPid.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPid.Name = "numPid";
            this.numPid.Size = new System.Drawing.Size(110, 20);
            this.numPid.TabIndex = 10;
            this.numPid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCopied
            // 
            this.lblCopied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopied.AutoSize = true;
            this.lblCopied.Location = new System.Drawing.Point(12, 350);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(0, 13);
            this.lblCopied.TabIndex = 11;
            // 
            // frmCritterProtoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 421);
            this.Controls.Add(this.lblCopied);
            this.Controls.Add(this.numPid);
            this.Controls.Add(this.rdbAssignFree);
            this.Controls.Add(this.rdbAssignPid);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.protoList);
            this.Name = "frmCritterProtoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Critter Protos";
            this.Load += new System.EventHandler(this.frmCritterProtoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView protoList;
        private BrightIdeasSoftware.OLVColumn col1;
        private BrightIdeasSoftware.OLVColumn col2;
        private BrightIdeasSoftware.OLVColumn col3;
        private BrightIdeasSoftware.OLVColumn col4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RadioButton rdbAssignPid;
        private System.Windows.Forms.RadioButton rdbAssignFree;
        private System.Windows.Forms.NumericUpDown numPid;
        private System.Windows.Forms.Label lblCopied;
    }
}