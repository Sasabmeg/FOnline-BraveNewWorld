namespace TiledMapper
{
    partial class SizeForm
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
            this.numNorth = new System.Windows.Forms.NumericUpDown();
            this.numEast = new System.Windows.Forms.NumericUpDown();
            this.numSouth = new System.Windows.Forms.NumericUpDown();
            this.numWest = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWest)).BeginInit();
            this.SuspendLayout();
            // 
            // numNorth
            // 
            this.numNorth.Location = new System.Drawing.Point(104, 53);
            this.numNorth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numNorth.Name = "numNorth";
            this.numNorth.Size = new System.Drawing.Size(50, 20);
            this.numNorth.TabIndex = 0;
            // 
            // numEast
            // 
            this.numEast.Location = new System.Drawing.Point(181, 119);
            this.numEast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numEast.Name = "numEast";
            this.numEast.Size = new System.Drawing.Size(50, 20);
            this.numEast.TabIndex = 1;
            // 
            // numSouth
            // 
            this.numSouth.Location = new System.Drawing.Point(104, 190);
            this.numSouth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSouth.Name = "numSouth";
            this.numSouth.Size = new System.Drawing.Size(50, 20);
            this.numSouth.TabIndex = 2;
            // 
            // numWest
            // 
            this.numWest.Location = new System.Drawing.Point(25, 119);
            this.numWest.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numWest.Name = "numWest";
            this.numWest.Size = new System.Drawing.Size(50, 20);
            this.numWest.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input the number of rows and columns by which the map should be adjusted.";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Location = new System.Drawing.Point(25, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(156, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(81, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 105);
            this.panel1.TabIndex = 11;
            // 
            // SizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(254, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numWest);
            this.Controls.Add(this.numSouth);
            this.Controls.Add(this.numEast);
            this.Controls.Add(this.numNorth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 300);
            this.Name = "SizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Resize Map";
            this.Load += new System.EventHandler(this.SizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNorth;
        private System.Windows.Forms.NumericUpDown numEast;
        private System.Windows.Forms.NumericUpDown numSouth;
        private System.Windows.Forms.NumericUpDown numWest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}