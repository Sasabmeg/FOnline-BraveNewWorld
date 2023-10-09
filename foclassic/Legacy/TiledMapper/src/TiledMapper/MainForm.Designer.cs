namespace TiledMapper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbTiles = new System.Windows.Forms.RadioButton();
            this.rdbBlocks = new System.Windows.Forms.RadioButton();
            this.rdbVariants = new System.Windows.Forms.RadioButton();
            this.rdbWide = new System.Windows.Forms.RadioButton();
            this.rdbScroll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbScroll2 = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCoords = new System.Windows.Forms.Label();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPicture
            // 
            this.panelPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPicture.AutoScroll = true;
            this.panelPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Controls.Add(this.pictureBoxDrawing);
            this.panelPicture.Location = new System.Drawing.Point(144, 27);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(638, 373);
            this.panelPicture.TabIndex = 0;
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxDrawing.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(0, 0);
            this.pictureBoxDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDrawing.TabIndex = 2;
            this.pictureBoxDrawing.TabStop = false;
            this.pictureBoxDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDrawing_Paint);
            this.pictureBoxDrawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseClick);
            this.pictureBoxDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseDown);
            this.pictureBoxDrawing.MouseLeave += new System.EventHandler(this.pictureBoxDrawing_MouseLeave);
            this.pictureBoxDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseMove);
            this.pictureBoxDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(794, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.openMapToolStripMenuItem,
            this.saveMapToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.compileMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newMapToolStripMenuItem.Text = "New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openMapToolStripMenuItem.Text = "Open Map";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveMapToolStripMenuItem.Text = "Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // compileMapToolStripMenuItem
            // 
            this.compileMapToolStripMenuItem.Name = "compileMapToolStripMenuItem";
            this.compileMapToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.compileMapToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.compileMapToolStripMenuItem.Text = "Compile Map";
            this.compileMapToolStripMenuItem.Click += new System.EventHandler(this.compileMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.aboutToolStripMenuItem.Text = "Edit";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilerToolStripMenuItem,
            this.appearanceToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // compilerToolStripMenuItem
            // 
            this.compilerToolStripMenuItem.Name = "compilerToolStripMenuItem";
            this.compilerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.compilerToolStripMenuItem.Text = "Compiler";
            this.compilerToolStripMenuItem.Click += new System.EventHandler(this.compilerToolStripMenuItem_Click);
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.appearanceToolStripMenuItem.Text = "Appearance";
            this.appearanceToolStripMenuItem.Click += new System.EventHandler(this.appearanceToolStripMenuItem_Click);
            // 
            // rdbTiles
            // 
            this.rdbTiles.AutoSize = true;
            this.rdbTiles.Checked = true;
            this.rdbTiles.Enabled = false;
            this.rdbTiles.Location = new System.Drawing.Point(6, 19);
            this.rdbTiles.Name = "rdbTiles";
            this.rdbTiles.Size = new System.Drawing.Size(83, 17);
            this.rdbTiles.TabIndex = 2;
            this.rdbTiles.TabStop = true;
            this.rdbTiles.Text = "Toggle Tiles";
            this.rdbTiles.UseVisualStyleBackColor = true;
            this.rdbTiles.CheckedChanged += new System.EventHandler(this.rdbTiles_CheckedChanged);
            // 
            // rdbBlocks
            // 
            this.rdbBlocks.AutoSize = true;
            this.rdbBlocks.Enabled = false;
            this.rdbBlocks.Location = new System.Drawing.Point(6, 42);
            this.rdbBlocks.Name = "rdbBlocks";
            this.rdbBlocks.Size = new System.Drawing.Size(87, 17);
            this.rdbBlocks.TabIndex = 3;
            this.rdbBlocks.Text = "Toggle Walls";
            this.rdbBlocks.UseVisualStyleBackColor = true;
            this.rdbBlocks.CheckedChanged += new System.EventHandler(this.rdbBlocks_CheckedChanged);
            // 
            // rdbVariants
            // 
            this.rdbVariants.AutoSize = true;
            this.rdbVariants.Checked = true;
            this.rdbVariants.Enabled = false;
            this.rdbVariants.Location = new System.Drawing.Point(6, 19);
            this.rdbVariants.Name = "rdbVariants";
            this.rdbVariants.Size = new System.Drawing.Size(98, 17);
            this.rdbVariants.TabIndex = 5;
            this.rdbVariants.TabStop = true;
            this.rdbVariants.Text = "Change Variant";
            this.rdbVariants.UseVisualStyleBackColor = true;
            this.rdbVariants.CheckedChanged += new System.EventHandler(this.rdbVariants_CheckedChanged);
            // 
            // rdbWide
            // 
            this.rdbWide.AutoSize = true;
            this.rdbWide.Enabled = false;
            this.rdbWide.Location = new System.Drawing.Point(6, 42);
            this.rdbWide.Name = "rdbWide";
            this.rdbWide.Size = new System.Drawing.Size(93, 17);
            this.rdbWide.TabIndex = 6;
            this.rdbWide.Text = "Change Width";
            this.rdbWide.UseVisualStyleBackColor = true;
            this.rdbWide.CheckedChanged += new System.EventHandler(this.rdbWide_CheckedChanged);
            // 
            // rdbScroll
            // 
            this.rdbScroll.AutoSize = true;
            this.rdbScroll.Enabled = false;
            this.rdbScroll.Location = new System.Drawing.Point(6, 65);
            this.rdbScroll.Name = "rdbScroll";
            this.rdbScroll.Size = new System.Drawing.Size(116, 17);
            this.rdbScroll.TabIndex = 4;
            this.rdbScroll.Text = "Place Scrollblocker";
            this.rdbScroll.UseVisualStyleBackColor = true;
            this.rdbScroll.CheckedChanged += new System.EventHandler(this.rdbScroll_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTiles);
            this.groupBox1.Controls.Add(this.rdbBlocks);
            this.groupBox1.Controls.Add(this.rdbScroll);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbScroll2);
            this.groupBox2.Controls.Add(this.rdbVariants);
            this.groupBox2.Controls.Add(this.rdbWide);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details mode";
            // 
            // rdbScroll2
            // 
            this.rdbScroll2.AutoSize = true;
            this.rdbScroll2.Enabled = false;
            this.rdbScroll2.Location = new System.Drawing.Point(6, 65);
            this.rdbScroll2.Name = "rdbScroll2";
            this.rdbScroll2.Size = new System.Drawing.Size(116, 17);
            this.rdbScroll2.TabIndex = 7;
            this.rdbScroll2.Text = "Place Scrollblocker";
            this.rdbScroll2.UseVisualStyleBackColor = true;
            this.rdbScroll2.CheckedChanged += new System.EventHandler(this.rdbScroll2_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(12, 142);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(126, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCoords
            // 
            this.lblCoords.AutoSize = true;
            this.lblCoords.Location = new System.Drawing.Point(12, 268);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(40, 13);
            this.lblCoords.TabIndex = 10;
            this.lblCoords.Text = "Coords";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.lblCoords);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MainForm";
            this.Text = "Tiled Mapper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBoxDrawing;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbTiles;
        private System.Windows.Forms.RadioButton rdbBlocks;
        private System.Windows.Forms.RadioButton rdbVariants;
        private System.Windows.Forms.RadioButton rdbWide;
        private System.Windows.Forms.RadioButton rdbScroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rdbScroll2;
        private System.Windows.Forms.ToolStripMenuItem compileMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appearanceToolStripMenuItem;
        private System.Windows.Forms.Label lblCoords;


    }
}

