using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TiledMapper.Xml;
using TiledMapper.Forms;

namespace TiledMapper
{
    public delegate void ValueSetterDelegate(bool value);

    public partial class MainForm : Form
    {
        private static MainForm self = null;
        private Map map;
        string _mapFileName;
        bool init = false;
        string mapToLoad = "";
        string mapFileName
        {
            get
            {
                return _mapFileName;
            }
            set
            {
                _mapFileName = value;
                if (!init) return;
                if (value.Equals(""))
                    this.Text = "Tiled Mapper - unnamed";
                else if (value == null)
                    this.Text = "Tiled Mapper";
                else
                    this.Text = "Tiled Mapper - " + value;
            }
        }

        public MainForm(string[] args)
        {
            InitializeComponent();
            self = this;
            if (args.Length > 0)
                mapToLoad = args[0];
        }

        public void SetUndo(bool value)
        {
            this.undoToolStripMenuItem.Enabled = value;
        }

        public void SetRedo(bool value)
        {
            this.redoToolStripMenuItem.Enabled = value;
        }

        public void SetPostMode(bool value)
        {
            if (!value)
            {
                this.rdbTiles.Enabled = true;
                this.rdbBlocks.Enabled = true;
                this.rdbScroll.Enabled = true;
                this.rdbVariants.Enabled = false;
                this.rdbWide.Enabled = false;
                this.rdbScroll2.Enabled = false;
                if (rdbTiles.Checked) tileMode = TileMode.Tiles;
                else if (rdbBlocks.Checked) tileMode = TileMode.Blocks;
                else if (rdbScroll.Checked) tileMode = TileMode.Scrolls;
                this.btnConvert.Text = "Convert";
            }
            else
            {
                this.rdbTiles.Enabled = false;
                this.rdbBlocks.Enabled = false;
                this.rdbScroll.Enabled = false;
                this.rdbVariants.Enabled = true;
                this.rdbWide.Enabled = true;
                this.rdbScroll2.Enabled = true;
                if (rdbVariants.Checked) tileMode = TileMode.Variants;
                else if (rdbWide.Checked) tileMode = TileMode.Width;
                else if (rdbScroll2.Checked) tileMode = TileMode.Scrolls;
                this.btnConvert.Text = "Revert";
            }
        }

        private void setMapMenus(bool enabled)
        {
            this.saveAsToolStripMenuItem.Enabled  = enabled;
            this.saveMapToolStripMenuItem.Enabled = enabled;
            this.resizeToolStripMenuItem.Enabled  = enabled;
            this.compileMapToolStripMenuItem.Enabled = enabled;
            if (!enabled)
            {
                SetUndo(false);
                SetRedo(false);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LostFocus += MainForm_LostFocus;
            setMapMenus(false);
            paint = false;
            mapFileName = null;
            init = true;
            updateCoords(-1, -1);
            if (!mapToLoad.Equals(""))
                tryLoadMap(mapToLoad);
        }

        private void MainForm_LostFocus(object sender, EventArgs e)
        {
            paint = false;
        }

        private void save()
        {
            map.Save(mapFileName);
        }

        private void saveAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Tiled map (*.tilemap)|*.tilemap";
            dlg.RestoreDirectory = true;
            DialogResult ret = dlg.ShowDialog(this);
            if (ret == DialogResult.OK)
            {
                mapFileName = dlg.FileName;
                save();
            }
        }

        public static void ErrorBox(string msg, string caption)
        {
            MessageBox.Show(self, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMapForm form = new NewMapForm();
            form.ShowDialogCenter(this);
            if (!form.OK) return;

            map = Map.NewMap(form.MapWidth, form.MapHeight, this.pictureBoxDrawing, SetUndo, SetRedo, SetPostMode);
            this.btnConvert.Enabled = true;
            setMapMenus(true);
            this.rdbTiles.Checked = true;
            mapFileName = "";
        }

        private void openMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Tiled map (*.tilemap)|*.tilemap";
            dlg.CheckFileExists = true;
            dlg.RestoreDirectory = true;
            DialogResult ret = dlg.ShowDialog(this);
            if (ret == DialogResult.OK)
                tryLoadMap(dlg.FileName);
        }

        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mapFileName != null && !mapFileName.Equals("")) save();
            else saveAs();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map.Redo();
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs args)
        {
            SizeForm form = new SizeForm(map.Width, map.Height);
            form.ShowDialogCenter(this);
            if (!form.OK) return;

            int n = form.N;
            int e = form.E;
            int s = form.S;
            int w = form.W;

            if(-n >= Height || -s >= Height || -e >= Width || -w >= Width ||
                -(n+s) >= Height || -(e+w) >= Width)
            {
                ErrorBox("The parameters you provided make it impossible to resize the map.",
                    "Invalid parameters!");
            }

            map.Resize(n, e, s, w);
        }

        private void pictureBoxDrawing_Paint(object sender, PaintEventArgs e)
        {
            if (map != null) map.Redraw(e.Graphics);
        }

        private void pictureBoxDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            paint = map.Click(e.X, e.Y, tileMode);
        }

        private void pictureBoxDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            updateCoords(Map.MouseToTile(e.X), Map.MouseToTile(e.Y));
            if (paint) paint = map.Click(e.X, e.Y, tileMode);
        }

        private void pictureBoxDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        bool _paint;
        bool paint
        {
            get
            {
                return _paint;
            }
            set
            {
                _paint = value;
                if (map!=null && !value) map.StopClick();
            }
        }
        TileMode tileMode;

        private void pictureBoxDrawing_MouseLeave(object sender, EventArgs e)
        {
            paint = false;
            updateCoords(-1, -1);
        }

        private void rdbTiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTiles.Checked) tileMode = TileMode.Tiles;
        }

        private void rdbBlocks_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBlocks.Checked) tileMode = TileMode.Blocks;
        }

        private void rdbScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbScroll.Checked) tileMode = TileMode.Scrolls;
        }

        private void rdbVariants_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVariants.Checked) tileMode = TileMode.Variants;
        }

        private void rdbWide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWide.Checked) tileMode = TileMode.Width;
        }

        private void rdbScroll2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbScroll2.Checked) tileMode = TileMode.Scrolls;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            map.ClickConvert();
        }

        private void compileMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compile();
        }

        private void pictureBoxDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                map.OneClick(e.X, e.Y, tileMode, true);
            else if (e.Button == MouseButtons.Right)
                map.OneClick(e.X, e.Y, tileMode, false);
        }

        private void compilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompilerForm form = new CompilerForm();
            form.ShowDialogCenter(this);
        }

        private void compile()
        {
            FOCommon.Maps.MapHeader hd = new FOCommon.Maps.MapHeader();
            if (Config.NeverShowHeaderForm)
            {
                hd.NoLogOut = false;
                hd.Time = "-1";
                hd.DayTime = "300  600  1140 1380";
                hd.DayColor0 = "18  18  53 ";
                hd.DayColor1 = "128 128 128";
                hd.DayColor2 = "103 95  86 ";
                hd.DayColor3 = "51  40  29 ";
            }
            else
            {
                HeaderForm frm = new HeaderForm();
                frm.ShowDialogCenter(this);
                if (frm.OK)
                {
                    hd.ScriptModule = frm.Module;
                    hd.ScriptFunc = frm.Function;
                    hd.NoLogOut = frm.NoLogOut;
                    hd.Time = frm.Time;
                    hd.DayTime = frm.DayTime;
                    hd.DayColor0 = frm.DayColor0;
                    hd.DayColor1 = frm.DayColor1;
                    hd.DayColor2 = frm.DayColor2;
                    hd.DayColor3 = frm.DayColor3;
                }
                else return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "FOnline map (*.fomap)|*.fomap";
            dlg.RestoreDirectory = true;
            DialogResult ret = dlg.ShowDialog(this);
            if (ret != DialogResult.OK) return;
            try
            {
                map.Compile(dlg.FileName, hd);
            }
            catch (CompilerException e)
            {
                ErrorBox("The following error was encountered:\n" + e.Text,
                    "Error compiling map!");
            }
        }

        private void appearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppearanceForm frm = new AppearanceForm();
            frm.ShowDialogCenter(this);
            if (frm.OK && map != null) map.FullRedraw();
        }

        private void updateCoords(int x, int y)
        {
            if (x < 0)
            {
                lblCoords.Text = "";
                return;
            }
            lblCoords.Text = string.Format("x: {0}, y: {1}", x, y);
        }

        private void tryLoadMap(string name)
        {
            try
            {
                Map m = Map.LoadMap(name, this.pictureBoxDrawing, SetUndo, SetRedo, SetPostMode);
                if (m != null)
                {
                    map = m;
                    mapFileName = name;
                    this.btnConvert.Enabled = true;
                    setMapMenus(true);
                    this.rdbTiles.Checked = true;
                }
            }
            catch (XmlMapperException exception)
            {
                ErrorBox("Error parsing the map file: " + exception.Text + ".", "Open map error");
            }
            catch (Exception)
            {
                ErrorBox("Error opening file " + name + ".", "Open map error");
            }
        }
    }
}
