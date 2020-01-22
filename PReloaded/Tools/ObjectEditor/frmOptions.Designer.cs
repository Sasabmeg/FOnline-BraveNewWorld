namespace ObjectEditor
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPagePaths = new System.Windows.Forms.TabPage();
            this.btnDefinesFOCLassic = new System.Windows.Forms.Button();
            this.txtDefinesFOClassic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFOOBJ = new System.Windows.Forms.Button();
            this.txtFOOBJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDefines = new System.Windows.Forms.Button();
            this.txtDefines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDataFolder = new System.Windows.Forms.Button();
            this.txtDataFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUI = new System.Windows.Forms.TabPage();
            this.chkResizeOnResize = new System.Windows.Forms.CheckBox();
            this.chkTranslateInterface = new System.Windows.Forms.CheckBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSwitchTab = new System.Windows.Forms.CheckBox();
            this.chkLockTabs = new System.Windows.Forms.CheckBox();
            this.tabPageListView = new System.Windows.Forms.TabPage();
            this.chkShowWholeFilePath = new System.Windows.Forms.CheckBox();
            this.chkDefineBeforeId = new System.Windows.Forms.CheckBox();
            this.chkShowItemPidDefine = new System.Windows.Forms.CheckBox();
            this.tabPageSaving = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.chkFormatWithSpace = new System.Windows.Forms.CheckBox();
            this.tabPageGraphics = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstGraphicFiles = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkLoadGraphics = new System.Windows.Forms.CheckBox();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.chkStripPrefix = new System.Windows.Forms.CheckBox();
            this.tabControlOptions.SuspendLayout();
            this.tabPagePaths.SuspendLayout();
            this.tabPageUI.SuspendLayout();
            this.tabPageListView.SuspendLayout();
            this.tabPageSaving.SuspendLayout();
            this.tabPageGraphics.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 227);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(172, 26);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPagePaths);
            this.tabControlOptions.Controls.Add(this.tabPageUI);
            this.tabControlOptions.Controls.Add(this.tabPageListView);
            this.tabControlOptions.Controls.Add(this.tabPageSaving);
            this.tabControlOptions.Controls.Add(this.tabPageGraphics);
            this.tabControlOptions.Controls.Add(this.tabPageGeneral);
            this.tabControlOptions.Location = new System.Drawing.Point(12, 12);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(350, 209);
            this.tabControlOptions.TabIndex = 16;
            // 
            // tabPagePaths
            // 
            this.tabPagePaths.Controls.Add(this.btnDefinesFOCLassic);
            this.tabPagePaths.Controls.Add(this.txtDefinesFOClassic);
            this.tabPagePaths.Controls.Add(this.label7);
            this.tabPagePaths.Controls.Add(this.btnFOOBJ);
            this.tabPagePaths.Controls.Add(this.txtFOOBJ);
            this.tabPagePaths.Controls.Add(this.label2);
            this.tabPagePaths.Controls.Add(this.btnDefines);
            this.tabPagePaths.Controls.Add(this.txtDefines);
            this.tabPagePaths.Controls.Add(this.label3);
            this.tabPagePaths.Controls.Add(this.btnDataFolder);
            this.tabPagePaths.Controls.Add(this.txtDataFolder);
            this.tabPagePaths.Controls.Add(this.label1);
            this.tabPagePaths.Location = new System.Drawing.Point(4, 22);
            this.tabPagePaths.Name = "tabPagePaths";
            this.tabPagePaths.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePaths.Size = new System.Drawing.Size(342, 183);
            this.tabPagePaths.TabIndex = 0;
            this.tabPagePaths.Text = "Paths";
            this.tabPagePaths.UseVisualStyleBackColor = true;
            // 
            // btnDefinesFOCLassic
            // 
            this.btnDefinesFOCLassic.Location = new System.Drawing.Point(313, 107);
            this.btnDefinesFOCLassic.Name = "btnDefinesFOCLassic";
            this.btnDefinesFOCLassic.Size = new System.Drawing.Size(25, 19);
            this.btnDefinesFOCLassic.TabIndex = 28;
            this.btnDefinesFOCLassic.Text = "...";
            this.btnDefinesFOCLassic.UseVisualStyleBackColor = true;
            this.btnDefinesFOCLassic.Click += new System.EventHandler(this.btnDefinesFOClassic_Click);
            // 
            // txtDefinesFOClassic
            // 
            this.txtDefinesFOClassic.Location = new System.Drawing.Point(103, 105);
            this.txtDefinesFOClassic.Name = "txtDefinesFOClassic";
            this.txtDefinesFOClassic.Size = new System.Drawing.Size(204, 20);
            this.txtDefinesFOClassic.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "FOClassic.fos";
            // 
            // btnFOOBJ
            // 
            this.btnFOOBJ.Location = new System.Drawing.Point(313, 71);
            this.btnFOOBJ.Name = "btnFOOBJ";
            this.btnFOOBJ.Size = new System.Drawing.Size(25, 19);
            this.btnFOOBJ.TabIndex = 25;
            this.btnFOOBJ.Text = "...";
            this.btnFOOBJ.UseVisualStyleBackColor = true;
            this.btnFOOBJ.Click += new System.EventHandler(this.btnFOOBJ_Click);
            // 
            // txtFOOBJ
            // 
            this.txtFOOBJ.Location = new System.Drawing.Point(103, 70);
            this.txtFOOBJ.Name = "txtFOOBJ";
            this.txtFOOBJ.Size = new System.Drawing.Size(204, 20);
            this.txtFOOBJ.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "FOOBJ.MSG";
            // 
            // btnDefines
            // 
            this.btnDefines.Location = new System.Drawing.Point(313, 42);
            this.btnDefines.Name = "btnDefines";
            this.btnDefines.Size = new System.Drawing.Size(25, 19);
            this.btnDefines.TabIndex = 21;
            this.btnDefines.Text = "...";
            this.btnDefines.UseVisualStyleBackColor = true;
            this.btnDefines.Click += new System.EventHandler(this.btnDefines_Click);
            // 
            // txtDefines
            // 
            this.txtDefines.Location = new System.Drawing.Point(103, 40);
            this.txtDefines.Name = "txtDefines";
            this.txtDefines.Size = new System.Drawing.Size(204, 20);
            this.txtDefines.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "_defines.fos";
            // 
            // btnDataFolder
            // 
            this.btnDataFolder.Location = new System.Drawing.Point(313, 11);
            this.btnDataFolder.Name = "btnDataFolder";
            this.btnDataFolder.Size = new System.Drawing.Size(25, 19);
            this.btnDataFolder.TabIndex = 18;
            this.btnDataFolder.Text = "...";
            this.btnDataFolder.UseVisualStyleBackColor = true;
            this.btnDataFolder.Click += new System.EventHandler(this.btnDataFolder_Click);
            // 
            // txtDataFolder
            // 
            this.txtDataFolder.Location = new System.Drawing.Point(103, 10);
            this.txtDataFolder.Name = "txtDataFolder";
            this.txtDataFolder.Size = new System.Drawing.Size(204, 20);
            this.txtDataFolder.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data Folder (/data)";
            // 
            // tabPageUI
            // 
            this.tabPageUI.Controls.Add(this.chkResizeOnResize);
            this.tabPageUI.Controls.Add(this.chkTranslateInterface);
            this.tabPageUI.Controls.Add(this.cmbLanguage);
            this.tabPageUI.Controls.Add(this.label4);
            this.tabPageUI.Controls.Add(this.chkSwitchTab);
            this.tabPageUI.Controls.Add(this.chkLockTabs);
            this.tabPageUI.Location = new System.Drawing.Point(4, 22);
            this.tabPageUI.Name = "tabPageUI";
            this.tabPageUI.Size = new System.Drawing.Size(342, 183);
            this.tabPageUI.TabIndex = 2;
            this.tabPageUI.Text = "UI";
            this.tabPageUI.UseVisualStyleBackColor = true;
            // 
            // chkResizeOnResize
            // 
            this.chkResizeOnResize.AutoSize = true;
            this.chkResizeOnResize.Location = new System.Drawing.Point(15, 127);
            this.chkResizeOnResize.Name = "chkResizeOnResize";
            this.chkResizeOnResize.Size = new System.Drawing.Size(182, 17);
            this.chkResizeOnResize.TabIndex = 10;
            this.chkResizeOnResize.Text = "Resize controls on window resize";
            this.chkResizeOnResize.UseVisualStyleBackColor = true;
            // 
            // chkTranslateInterface
            // 
            this.chkTranslateInterface.AutoSize = true;
            this.chkTranslateInterface.Location = new System.Drawing.Point(15, 59);
            this.chkTranslateInterface.Name = "chkTranslateInterface";
            this.chkTranslateInterface.Size = new System.Drawing.Size(115, 17);
            this.chkTranslateInterface.TabIndex = 9;
            this.chkTranslateInterface.Text = "Translate Interface";
            this.chkTranslateInterface.UseVisualStyleBackColor = true;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(15, 99);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(130, 21);
            this.cmbLanguage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interface Language";
            // 
            // chkSwitchTab
            // 
            this.chkSwitchTab.AutoSize = true;
            this.chkSwitchTab.Location = new System.Drawing.Point(13, 12);
            this.chkSwitchTab.Name = "chkSwitchTab";
            this.chkSwitchTab.Size = new System.Drawing.Size(207, 17);
            this.chkSwitchTab.TabIndex = 6;
            this.chkSwitchTab.Text = "Switch tab to itemtype of selected item";
            this.chkSwitchTab.UseVisualStyleBackColor = true;
            // 
            // chkLockTabs
            // 
            this.chkLockTabs.AutoSize = true;
            this.chkLockTabs.Location = new System.Drawing.Point(33, 35);
            this.chkLockTabs.Name = "chkLockTabs";
            this.chkLockTabs.Size = new System.Drawing.Size(68, 17);
            this.chkLockTabs.TabIndex = 5;
            this.chkLockTabs.Text = "Lock tab";
            this.chkLockTabs.UseVisualStyleBackColor = true;
            // 
            // tabPageListView
            // 
            this.tabPageListView.Controls.Add(this.chkShowWholeFilePath);
            this.tabPageListView.Controls.Add(this.chkDefineBeforeId);
            this.tabPageListView.Controls.Add(this.chkShowItemPidDefine);
            this.tabPageListView.Location = new System.Drawing.Point(4, 22);
            this.tabPageListView.Name = "tabPageListView";
            this.tabPageListView.Size = new System.Drawing.Size(342, 183);
            this.tabPageListView.TabIndex = 3;
            this.tabPageListView.Text = "ListView";
            this.tabPageListView.UseVisualStyleBackColor = true;
            // 
            // chkShowWholeFilePath
            // 
            this.chkShowWholeFilePath.AutoSize = true;
            this.chkShowWholeFilePath.Location = new System.Drawing.Point(13, 58);
            this.chkShowWholeFilePath.Name = "chkShowWholeFilePath";
            this.chkShowWholeFilePath.Size = new System.Drawing.Size(135, 17);
            this.chkShowWholeFilePath.TabIndex = 14;
            this.chkShowWholeFilePath.Text = "Show whole proto path";
            this.chkShowWholeFilePath.UseVisualStyleBackColor = true;
            // 
            // chkDefineBeforeId
            // 
            this.chkDefineBeforeId.AutoSize = true;
            this.chkDefineBeforeId.Location = new System.Drawing.Point(39, 35);
            this.chkDefineBeforeId.Name = "chkDefineBeforeId";
            this.chkDefineBeforeId.Size = new System.Drawing.Size(118, 17);
            this.chkDefineBeforeId.TabIndex = 13;
            this.chkDefineBeforeId.Text = "Put define before id";
            this.chkDefineBeforeId.UseVisualStyleBackColor = true;
            // 
            // chkShowItemPidDefine
            // 
            this.chkShowItemPidDefine.AutoSize = true;
            this.chkShowItemPidDefine.Location = new System.Drawing.Point(13, 12);
            this.chkShowItemPidDefine.Name = "chkShowItemPidDefine";
            this.chkShowItemPidDefine.Size = new System.Drawing.Size(106, 17);
            this.chkShowItemPidDefine.TabIndex = 12;
            this.chkShowItemPidDefine.Text = "Show PID define";
            this.chkShowItemPidDefine.UseVisualStyleBackColor = true;
            // 
            // tabPageSaving
            // 
            this.tabPageSaving.Controls.Add(this.label5);
            this.tabPageSaving.Controls.Add(this.chkFormatWithSpace);
            this.tabPageSaving.Location = new System.Drawing.Point(4, 22);
            this.tabPageSaving.Name = "tabPageSaving";
            this.tabPageSaving.Size = new System.Drawing.Size(342, 183);
            this.tabPageSaving.TabIndex = 4;
            this.tabPageSaving.Text = "Saving";
            this.tabPageSaving.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(149, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = " (FieldName   = FieldValue instead of      FieldName=FieldValue";
            // 
            // chkFormatWithSpace
            // 
            this.chkFormatWithSpace.AutoSize = true;
            this.chkFormatWithSpace.Location = new System.Drawing.Point(13, 12);
            this.chkFormatWithSpace.Name = "chkFormatWithSpace";
            this.chkFormatWithSpace.Size = new System.Drawing.Size(139, 17);
            this.chkFormatWithSpace.TabIndex = 0;
            this.chkFormatWithSpace.Text = "Format fields with space";
            this.chkFormatWithSpace.UseVisualStyleBackColor = true;
            // 
            // tabPageGraphics
            // 
            this.tabPageGraphics.Controls.Add(this.btnDelete);
            this.tabPageGraphics.Controls.Add(this.btnAdd);
            this.tabPageGraphics.Controls.Add(this.lstGraphicFiles);
            this.tabPageGraphics.Controls.Add(this.label6);
            this.tabPageGraphics.Controls.Add(this.chkLoadGraphics);
            this.tabPageGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphics.Name = "tabPageGraphics";
            this.tabPageGraphics.Size = new System.Drawing.Size(342, 183);
            this.tabPageGraphics.TabIndex = 5;
            this.tabPageGraphics.Text = "Graphics";
            this.tabPageGraphics.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(115, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add file(s)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstGraphicFiles
            // 
            this.lstGraphicFiles.FormattingEnabled = true;
            this.lstGraphicFiles.Location = new System.Drawing.Point(13, 48);
            this.lstGraphicFiles.Name = "lstGraphicFiles";
            this.lstGraphicFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGraphicFiles.Size = new System.Drawing.Size(316, 95);
            this.lstGraphicFiles.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Only .zip or .dat (Fallout 2) can be loaded.";
            // 
            // chkLoadGraphics
            // 
            this.chkLoadGraphics.AutoSize = true;
            this.chkLoadGraphics.Location = new System.Drawing.Point(13, 12);
            this.chkLoadGraphics.Name = "chkLoadGraphics";
            this.chkLoadGraphics.Size = new System.Drawing.Size(95, 17);
            this.chkLoadGraphics.TabIndex = 0;
            this.chkLoadGraphics.Text = "Load Graphics";
            this.chkLoadGraphics.UseVisualStyleBackColor = true;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.chkStripPrefix);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(342, 183);
            this.tabPageGeneral.TabIndex = 1;
            this.tabPageGeneral.Text = "Misc";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // chkStripPrefix
            // 
            this.chkStripPrefix.AutoSize = true;
            this.chkStripPrefix.Location = new System.Drawing.Point(13, 12);
            this.chkStripPrefix.Name = "chkStripPrefix";
            this.chkStripPrefix.Size = new System.Drawing.Size(213, 17);
            this.chkStripPrefix.TabIndex = 5;
            this.chkStripPrefix.Text = "Strip prefix from defines (requires restart)";
            this.chkStripPrefix.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 262);
            this.Controls.Add(this.tabControlOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPagePaths.ResumeLayout(false);
            this.tabPagePaths.PerformLayout();
            this.tabPageUI.ResumeLayout(false);
            this.tabPageUI.PerformLayout();
            this.tabPageListView.ResumeLayout(false);
            this.tabPageListView.PerformLayout();
            this.tabPageSaving.ResumeLayout(false);
            this.tabPageSaving.PerformLayout();
            this.tabPageGraphics.ResumeLayout(false);
            this.tabPageGraphics.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPagePaths;
        private System.Windows.Forms.Button btnFOOBJ;
        private System.Windows.Forms.TextBox txtFOOBJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDefines;
        private System.Windows.Forms.TextBox txtDefines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDataFolder;
        private System.Windows.Forms.TextBox txtDataFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.CheckBox chkStripPrefix;
        private System.Windows.Forms.TabPage tabPageUI;
        private System.Windows.Forms.CheckBox chkResizeOnResize;
        private System.Windows.Forms.CheckBox chkTranslateInterface;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSwitchTab;
        private System.Windows.Forms.CheckBox chkLockTabs;
        private System.Windows.Forms.TabPage tabPageListView;
        private System.Windows.Forms.CheckBox chkDefineBeforeId;
        private System.Windows.Forms.CheckBox chkShowItemPidDefine;
        private System.Windows.Forms.TabPage tabPageSaving;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFormatWithSpace;
        private System.Windows.Forms.CheckBox chkShowWholeFilePath;
        private System.Windows.Forms.TabPage tabPageGraphics;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstGraphicFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkLoadGraphics;
        private System.Windows.Forms.Button btnDefinesFOCLassic;
        private System.Windows.Forms.TextBox txtDefinesFOClassic;
        private System.Windows.Forms.Label label7;
    }
}