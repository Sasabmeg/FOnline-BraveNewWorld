using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;

namespace FOCommon.Controls
{
    public partial class ColorComboBox : ComboBox
    {
        public Color CustomColor { get; set; }
        private bool ignoreDialog = false;

        public ColorComboBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime) // Hack, because !DesignMode doesn't work in constructor
                FillColors();
        }

        public void FillColors()
        {
            this.Items.Clear();
            // Fill Colors using Reflection
            this.Items.Add("Custom");
            PropertyInfo[] propInfoList = typeof(System.Drawing.Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (System.Reflection.PropertyInfo c in propInfoList)
            {
                Color color = (Color)c.GetValue(c, null);
                this.Items.Add(color);
            }
        }

        private void DrawColor(DrawItemEventArgs e, Color color, ref int nextX)
        {
            int width = e.Bounds.Height * 2 - 8;
            Rectangle rectangle = new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 3, width, e.Bounds.Height - 6);
            SolidBrush brush = new SolidBrush(color);
            Pen pen = new Pen(Color.Black);
            e.Graphics.FillRectangle(brush, rectangle);
            e.Graphics.DrawRectangle(pen, rectangle);
            brush.Dispose();
            pen.Dispose();
            nextX = width + 8;
        }

        private void DrawText(DrawItemEventArgs e, Color color, int nextX)
        {
            String Text;
            if (e.Index > 0)
                Text = color.Name;
            else
                Text = "Custom Color";
            e.Graphics.DrawString(Text, e.Font, new SolidBrush(e.ForeColor), new PointF(nextX, e.Bounds.Y + (e.Bounds.Height - e.Font.Height) / 2));
        }

        public Color Color
        {
            get
            {
                if (this.SelectedIndex == 0) return CustomColor;
                if (this.SelectedItem != null)
                    return (Color)this.SelectedItem;

                return Color.Black;
            }
            set
            {
                if (this.Items.Count == 0) return;
                for (int i = 1; i < this.Items.Count; i++)
                {
                    Color col = (Color)(this.Items[i]);
                    if (col.ToArgb() == value.ToArgb())
                    {
                        this.SelectedIndex = i;
                        return;
                    }
                }
                CustomColor = value;
                ignoreDialog = true;
                this.SelectedIndex = 0;
                ignoreDialog = false;
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (this.SelectedIndex == 0 && Parent.Visible && !ignoreDialog)
            {
                ColorDialog ColorDlg = new ColorDialog();
                ColorDlg.AllowFullOpen = true;
                ColorDlg.AnyColor = true;
                ColorDlg.FullOpen = true;
                ColorDlg.Color = CustomColor;
                if (ColorDlg.ShowDialog() == DialogResult.OK)
                {
                    CustomColor = ColorDlg.Color;
                    this.Invalidate();
                }
            }

            base.OnSelectedIndexChanged(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Color color;
                if (e.Index > 0)
                    color = (Color)this.Items[e.Index];
                else
                {
                    if (CustomColor == null)
                        color = Color.Transparent;
                    else
                        color = CustomColor;
                }

                int nextX = 0;
                e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
                DrawColor(e, color, ref nextX);
                DrawText(e, color, nextX);
            }
            else
                base.OnDrawItem(e);
        }
    }
}
