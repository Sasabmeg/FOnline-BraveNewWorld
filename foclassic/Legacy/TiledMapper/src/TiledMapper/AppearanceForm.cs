using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiledMapper
{
    public partial class AppearanceForm : Form
    {
        public AppearanceForm()
        {
            InitializeComponent();
        }

        public bool OK { get; private set; }
        private Font font;

        private void AppearanceForm_Load(object sender, EventArgs e)
        {
            OK = false;
            cbBackground.Color = Config.BackgroundColor;
            cbBlock.Color = Config.BlockColor;
            cbLine.Color = Config.LineColor;
            cbScrollBlockerText.Color = Config.ScrollblockerTextColor;
            cbTile.Color = Config.TileColor;
            cbVariantText.Color = Config.VariantTextColor;
            cbWall.Color = Config.WallColor;

            numBlockSize.Value = Config.LineSize;
            numGridSize.Value = Config.GridSize;
            numWallPadding.Value = Config.WallPadding;
            numWallSize.Value = Config.WallSize;
            numWidePadding.Value = Config.WidePadding;

            font = Config.Font;

            updateFontString();
        }

        private void updateFontString()
        {
            tbFont.Text = string.Format("{0}, {1}pt {2}", font.Name, font.Size, font.Style.ToString());
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.FontMustExist = true;
            dlg.Font = font;
            dlg.ShowEffects = false;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.font = dlg.Font;
                updateFontString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OK = true;
            Config.BackgroundColor = cbBackground.Color;
            Config.BlockColor = cbBlock.Color;
            Config.Font = this.font;
            Config.GridSize = (int)numGridSize.Value;
            Config.LineColor = cbLine.Color;
            Config.LineSize = (int)numBlockSize.Value;
            Config.ScrollblockerTextColor = cbScrollBlockerText.Color;
            Config.TileColor = cbTile.Color;
            Config.VariantTextColor = cbVariantText.Color;
            Config.WallColor = cbWall.Color;
            Config.WallPadding = (int)numWallPadding.Value;
            Config.WallSize = (int)numWallSize.Value;
            Config.WidePadding = (int)numWidePadding.Value;

            Config.Save();
            this.Close();
        }
    }
}
