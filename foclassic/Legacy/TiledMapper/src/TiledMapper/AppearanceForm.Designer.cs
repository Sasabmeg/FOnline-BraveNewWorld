namespace TiledMapper
{
    partial class AppearanceForm
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
            this.numGridSize = new System.Windows.Forms.NumericUpDown();
            this.numBlockSize = new System.Windows.Forms.NumericUpDown();
            this.numWallSize = new System.Windows.Forms.NumericUpDown();
            this.numWallPadding = new System.Windows.Forms.NumericUpDown();
            this.numWidePadding = new System.Windows.Forms.NumericUpDown();
            this.tbFont = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.cbBackground = new FOCommon.Controls.ColorComboBox();
            this.cbLine = new FOCommon.Controls.ColorComboBox();
            this.cbBlock = new FOCommon.Controls.ColorComboBox();
            this.cbScrollBlockerText = new FOCommon.Controls.ColorComboBox();
            this.cbVariantText = new FOCommon.Controls.ColorComboBox();
            this.cbWall = new FOCommon.Controls.ColorComboBox();
            this.cbTile = new FOCommon.Controls.ColorComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWallSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWallPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidePadding)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numGridSize
            // 
            this.numGridSize.Location = new System.Drawing.Point(106, 20);
            this.numGridSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGridSize.Name = "numGridSize";
            this.numGridSize.Size = new System.Drawing.Size(60, 20);
            this.numGridSize.TabIndex = 0;
            this.numGridSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBlockSize
            // 
            this.numBlockSize.Location = new System.Drawing.Point(106, 47);
            this.numBlockSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBlockSize.Name = "numBlockSize";
            this.numBlockSize.Size = new System.Drawing.Size(60, 20);
            this.numBlockSize.TabIndex = 1;
            this.numBlockSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWallSize
            // 
            this.numWallSize.Location = new System.Drawing.Point(106, 74);
            this.numWallSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWallSize.Name = "numWallSize";
            this.numWallSize.Size = new System.Drawing.Size(60, 20);
            this.numWallSize.TabIndex = 2;
            this.numWallSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWallPadding
            // 
            this.numWallPadding.Location = new System.Drawing.Point(106, 101);
            this.numWallPadding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWallPadding.Name = "numWallPadding";
            this.numWallPadding.Size = new System.Drawing.Size(60, 20);
            this.numWallPadding.TabIndex = 3;
            this.numWallPadding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWidePadding
            // 
            this.numWidePadding.Location = new System.Drawing.Point(106, 128);
            this.numWidePadding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidePadding.Name = "numWidePadding";
            this.numWidePadding.Size = new System.Drawing.Size(60, 20);
            this.numWidePadding.TabIndex = 4;
            this.numWidePadding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbFont
            // 
            this.tbFont.Enabled = false;
            this.tbFont.Location = new System.Drawing.Point(93, 18);
            this.tbFont.Name = "tbFont";
            this.tbFont.Size = new System.Drawing.Size(265, 20);
            this.tbFont.TabIndex = 10;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(364, 16);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(25, 23);
            this.btnFont.TabIndex = 11;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // cbBackground
            // 
            this.cbBackground.Color = System.Drawing.Color.Black;
            this.cbBackground.CustomColor = System.Drawing.Color.Empty;
            this.cbBackground.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackground.FormattingEnabled = true;
            this.cbBackground.Location = new System.Drawing.Point(77, 19);
            this.cbBackground.Name = "cbBackground";
            this.cbBackground.Size = new System.Drawing.Size(121, 21);
            this.cbBackground.TabIndex = 5;
            // 
            // cbLine
            // 
            this.cbLine.Color = System.Drawing.Color.Black;
            this.cbLine.CustomColor = System.Drawing.Color.Empty;
            this.cbLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLine.FormattingEnabled = true;
            this.cbLine.Location = new System.Drawing.Point(77, 73);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(121, 21);
            this.cbLine.TabIndex = 7;
            // 
            // cbBlock
            // 
            this.cbBlock.Color = System.Drawing.Color.Black;
            this.cbBlock.CustomColor = System.Drawing.Color.Empty;
            this.cbBlock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlock.FormattingEnabled = true;
            this.cbBlock.Location = new System.Drawing.Point(77, 100);
            this.cbBlock.Name = "cbBlock";
            this.cbBlock.Size = new System.Drawing.Size(121, 21);
            this.cbBlock.TabIndex = 8;
            // 
            // cbScrollBlockerText
            // 
            this.cbScrollBlockerText.Color = System.Drawing.Color.Black;
            this.cbScrollBlockerText.CustomColor = System.Drawing.Color.Empty;
            this.cbScrollBlockerText.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbScrollBlockerText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScrollBlockerText.FormattingEnabled = true;
            this.cbScrollBlockerText.Location = new System.Drawing.Point(93, 44);
            this.cbScrollBlockerText.Name = "cbScrollBlockerText";
            this.cbScrollBlockerText.Size = new System.Drawing.Size(121, 21);
            this.cbScrollBlockerText.TabIndex = 12;
            // 
            // cbVariantText
            // 
            this.cbVariantText.Color = System.Drawing.Color.Black;
            this.cbVariantText.CustomColor = System.Drawing.Color.Empty;
            this.cbVariantText.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVariantText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariantText.FormattingEnabled = true;
            this.cbVariantText.Location = new System.Drawing.Point(268, 44);
            this.cbVariantText.Name = "cbVariantText";
            this.cbVariantText.Size = new System.Drawing.Size(121, 21);
            this.cbVariantText.TabIndex = 13;
            // 
            // cbWall
            // 
            this.cbWall.Color = System.Drawing.Color.Black;
            this.cbWall.CustomColor = System.Drawing.Color.Empty;
            this.cbWall.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWall.FormattingEnabled = true;
            this.cbWall.Location = new System.Drawing.Point(77, 127);
            this.cbWall.Name = "cbWall";
            this.cbWall.Size = new System.Drawing.Size(121, 21);
            this.cbWall.TabIndex = 9;
            // 
            // cbTile
            // 
            this.cbTile.Color = System.Drawing.Color.Black;
            this.cbTile.CustomColor = System.Drawing.Color.Empty;
            this.cbTile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTile.FormattingEnabled = true;
            this.cbTile.Location = new System.Drawing.Point(77, 46);
            this.cbTile.Name = "cbTile";
            this.cbTile.Size = new System.Drawing.Size(121, 21);
            this.cbTile.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tile edge width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tile border width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Wall width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Wall padding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wide wall padding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Family and style";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Background";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tile border";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Block";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tile";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Scrollblocker";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Variant";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Wall";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numGridSize);
            this.groupBox1.Controls.Add(this.numBlockSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numWallSize);
            this.groupBox1.Controls.Add(this.numWallPadding);
            this.groupBox1.Controls.Add(this.numWidePadding);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 159);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sizes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbBackground);
            this.groupBox2.Controls.Add(this.cbTile);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbLine);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbWall);
            this.groupBox2.Controls.Add(this.cbBlock);
            this.groupBox2.Location = new System.Drawing.Point(203, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 159);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbFont);
            this.groupBox3.Controls.Add(this.cbScrollBlockerText);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnFont);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbVariantText);
            this.groupBox3.Location = new System.Drawing.Point(12, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 77);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font settings";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Location = new System.Drawing.Point(118, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(237, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AppearanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(427, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppearanceForm";
            this.ShowInTaskbar = false;
            this.Text = "Appearance Options";
            this.Load += new System.EventHandler(this.AppearanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWallSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWallPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidePadding)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGridSize;
        private System.Windows.Forms.NumericUpDown numBlockSize;
        private System.Windows.Forms.NumericUpDown numWallSize;
        private System.Windows.Forms.NumericUpDown numWallPadding;
        private System.Windows.Forms.NumericUpDown numWidePadding;
        private System.Windows.Forms.TextBox tbFont;
        private System.Windows.Forms.Button btnFont;
        private FOCommon.Controls.ColorComboBox cbBackground;
        private FOCommon.Controls.ColorComboBox cbLine;
        private FOCommon.Controls.ColorComboBox cbBlock;
        private FOCommon.Controls.ColorComboBox cbScrollBlockerText;
        private FOCommon.Controls.ColorComboBox cbVariantText;
        private FOCommon.Controls.ColorComboBox cbWall;
        private FOCommon.Controls.ColorComboBox cbTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}