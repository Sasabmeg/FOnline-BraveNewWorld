namespace WorldEditor
{
    partial class frmEditMap
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScript = new System.Windows.Forms.Label();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.btnAssignPID = new System.Windows.Forms.Button();
            this.cmbMusic = new System.Windows.Forms.ComboBox();
            this.chkNologout = new System.Windows.Forms.CheckBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.chkAutomap = new System.Windows.Forms.CheckBox();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnRemoveMusic = new System.Windows.Forms.Button();
            this.lstBoxMusic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Location = new System.Drawing.Point(3, 94);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(37, 13);
            this.lblScript.TabIndex = 7;
            this.lblScript.Text = "Script:";
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(71, 91);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(129, 20);
            this.txtScript.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soundstring:";
            // 
            // txtSound
            // 
            this.txtSound.Location = new System.Drawing.Point(71, 220);
            this.txtSound.Name = "txtSound";
            this.txtSound.Size = new System.Drawing.Size(235, 20);
            this.txtSound.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Music:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(72, 62);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(128, 20);
            this.txtFileName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filename:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 24);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 24);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PID:";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(72, 35);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(73, 20);
            this.txtPID.TabIndex = 20;
            // 
            // btnAssignPID
            // 
            this.btnAssignPID.Location = new System.Drawing.Point(151, 35);
            this.btnAssignPID.Name = "btnAssignPID";
            this.btnAssignPID.Size = new System.Drawing.Size(96, 21);
            this.btnAssignPID.TabIndex = 21;
            this.btnAssignPID.Text = "Assign Free PID";
            this.btnAssignPID.UseVisualStyleBackColor = true;
            this.btnAssignPID.Click += new System.EventHandler(this.btnAssignPID_Click);
            // 
            // cmbMusic
            // 
            this.cmbMusic.FormattingEnabled = true;
            this.cmbMusic.Items.AddRange(new object[] {
            "01hub",
            "03wrldmp",
            "05raider",
            "07desert",
            "08vats",
            "10labone",
            "12junktn",
            "13carvrn",
            "14necro",
            "16follow",
            "17arroyo",
            "18modoc",
            "19reno",
            "20car",
            "21sf",
            "22vcity",
            "23world",
            "24redd"});
            this.cmbMusic.Location = new System.Drawing.Point(71, 193);
            this.cmbMusic.Name = "cmbMusic";
            this.cmbMusic.Size = new System.Drawing.Size(129, 21);
            this.cmbMusic.TabIndex = 22;
            // 
            // chkNologout
            // 
            this.chkNologout.AutoSize = true;
            this.chkNologout.Location = new System.Drawing.Point(71, 246);
            this.chkNologout.Name = "chkNologout";
            this.chkNologout.Size = new System.Drawing.Size(225, 17);
            this.chkNologout.TabIndex = 23;
            this.chkNologout.Text = "No logout (Player can\'t logout on this map)";
            this.chkNologout.UseVisualStyleBackColor = true;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(206, 62);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(31, 20);
            this.btnChooseFile.TabIndex = 24;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(245, 91);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(61, 20);
            this.txtTime.TabIndex = 27;
            // 
            // chkAutomap
            // 
            this.chkAutomap.AutoSize = true;
            this.chkAutomap.Location = new System.Drawing.Point(71, 263);
            this.chkAutomap.Name = "chkAutomap";
            this.chkAutomap.Size = new System.Drawing.Size(186, 17);
            this.chkAutomap.TabIndex = 28;
            this.chkAutomap.Text = "Visible in Automaps (in the pipboy)";
            this.chkAutomap.UseVisualStyleBackColor = true;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(206, 191);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(90, 23);
            this.btnAddMusic.TabIndex = 30;
            this.btnAddMusic.Text = "Add Music";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // btnRemoveMusic
            // 
            this.btnRemoveMusic.Location = new System.Drawing.Point(206, 164);
            this.btnRemoveMusic.Name = "btnRemoveMusic";
            this.btnRemoveMusic.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveMusic.TabIndex = 31;
            this.btnRemoveMusic.Text = "Remove Music";
            this.btnRemoveMusic.UseVisualStyleBackColor = true;
            this.btnRemoveMusic.Click += new System.EventHandler(this.btnRemoveMusic_Click);
            // 
            // lstBoxMusic
            // 
            this.lstBoxMusic.FormattingEnabled = true;
            this.lstBoxMusic.Location = new System.Drawing.Point(72, 118);
            this.lstBoxMusic.Name = "lstBoxMusic";
            this.lstBoxMusic.Size = new System.Drawing.Size(128, 69);
            this.lstBoxMusic.TabIndex = 32;
            this.lstBoxMusic.DoubleClick += new System.EventHandler(this.lstBoxMusic_DoubleClick);
            // 
            // frmEditMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 320);
            this.Controls.Add(this.lstBoxMusic);
            this.Controls.Add(this.btnRemoveMusic);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.chkAutomap);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.chkNologout);
            this.Controls.Add(this.cmbMusic);
            this.Controls.Add(this.btnAssignPID);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.lblScript);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Map - ";
            this.Load += new System.EventHandler(this.frmEditMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScript;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btnAssignPID;
        private System.Windows.Forms.ComboBox cmbMusic;
        private System.Windows.Forms.CheckBox chkNologout;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.CheckBox chkAutomap;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnRemoveMusic;
        private System.Windows.Forms.ListBox lstBoxMusic;

    }
}