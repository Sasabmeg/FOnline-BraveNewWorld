using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmEditTownMap : Form
    {
        bool IsDragging = false;
        public bool Failed = false;
        public bool Saved = false;
        public string EntranceString = "";
        public List<EntryPoint> EntryPoints = new List<EntryPoint>();
        List<Map> Maps;
        EntryPoint SelectedEntryPoint=null;
        private static Pen pen = new Pen(Color.Black, 3.0f);
        private static Font font = new Font(FontFamily.GenericMonospace, 12.0f, FontStyle.Bold);
        Image EntryMarker;
        Image EntryMarkerSelected;

        public frmEditTownMap(string TownMap, List<EntryPoint> EntryPoints, List<Map> Maps)
        {
            if (string.IsNullOrEmpty(Config.PathTownMaps))
            {
                Message.Show("No path set for town graphics.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Failed = true;
                return;
            }

            foreach (String image in Directory.GetFiles(@Config.PathTownMaps, "*.png"))
            {
                string fname = Path.GetFileNameWithoutExtension(image);
                if (fname.ToLower() == TownMap.ToLower())
                {
                    InitializeComponent();
                    pctTownMap.ImageLocation = image;
                    this.EntryPoints = EntryPoints;
                    this.Maps = Maps;
                    foreach(Map map in Maps)
                        cmbMap.Items.Add(map.FileName);

                    EntryMarker = Image.FromFile(@Config.PathTownMaps+"\\hotspot1.png");
                    EntryMarkerSelected = Image.FromFile(@Config.PathTownMaps+"\\hotspot2.png");
                    return;
                }
            }
            Failed = true;
            Message.Show("Town image not found. Add " + Path.GetFileNameWithoutExtension(TownMap) + ".* (png, jpeg, gif) to your graphics folder.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pctTownMap_Paint(object sender, PaintEventArgs e)
        {
            foreach (EntryPoint ent in EntryPoints)
            {
                Graphics g = e.Graphics;
                Drawing.DrawOutlinedText(g, ent.Name, font, Brushes.LightGreen, new Point(ent.X-(ent.Name.Length*3), ent.Y-20), Brushes.Black);
                
                if(ent==SelectedEntryPoint)
                    e.Graphics.DrawImage(EntryMarkerSelected, new Point(ent.X, ent.Y));
                else
                    e.Graphics.DrawImage(EntryMarker, new Point(ent.X, ent.Y));
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (SelectedEntryPoint == null)
                return;
            SelectedEntryPoint.Name = txtName.Text;
            pctTownMap.Refresh();
        }

        private void numX_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedEntryPoint == null)
                return;
            SelectedEntryPoint.X = (int)numX.Value;
            pctTownMap.Refresh();
        }

        private void numY_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedEntryPoint == null)
                return;
            SelectedEntryPoint.Y = (int)numY.Value;
            pctTownMap.Refresh();
        }

        private void pctTownMap_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void pctTownMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging && SelectedEntryPoint != null)
            {
                SelectedEntryPoint.X = e.X-12;
                SelectedEntryPoint.Y = e.Y-3;
                if (e.X - 12 < 0)
                    numX.Value = 0;
                else
                    numX.Value = e.X - 12;
                if (e.Y - 3 < 0)
                    numY.Value = 0;
                else
                    numY.Value = e.Y - 3;
                pctTownMap.Refresh();
            }
        }

        private void pctTownMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedEntryPoint = null;
                txtName.Text = "";
                cmbMap.SelectedIndex = -1;
                numX.Value = 0;
                numY.Value = 0;
                pctTownMap.Refresh();
            }

            if (e.Button != MouseButtons.Left)
                return;

            foreach (EntryPoint ent in EntryPoints)
            {
                if ((e.X >= ent.X && e.X <= ent.X + 25) &&
                    e.Y >= ent.Y && e.Y <= ent.Y + 13)
                {
                    SelectedEntryPoint = ent;
                    for (int i = 0; i < cmbMap.Items.Count; i++)
                        if ((string)cmbMap.Items[i] == ent.MapName)
                            cmbMap.SelectedIndex = i;
                    txtName.Text = ent.Name;
                    numEntire.Value = ent.Entire;
                    numX.Value = ent.X;
                    numY.Value = ent.Y;
                    pctTownMap.Refresh();
                    IsDragging = true;
                    return;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SelectedEntryPoint == null)
                return;
            EntryPoints.Remove(SelectedEntryPoint);
            pctTownMap.Refresh();
        }

        private void frmEditTownMap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntryPoint ent = new EntryPoint(txtName.Text, (int)numX.Value, (int)numY.Value);
            ent.MapName = cmbMap.Text;
            EntryPoints.Add(ent);
            pctTownMap.Refresh();
        }

        int FindIndexOfMap(string map)
        {
            for (int i = 0; i < cmbMap.Items.Count; i++)
            {
                if ((string)cmbMap.Items[i] == map)
                    return i;
            }
            Message.Show("Unable to find map index for entrypoint", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        string CreateEntranceString(List<EntryPoint> EntryPoints)
        {
            if (EntryPoints == null || EntryPoints.Count == 0)
                return "";

            string str="$";
            for (int i=0;i<EntryPoints.Count;i++)
                str += FindIndexOfMap(EntryPoints[i].MapName) + " " + EntryPoints[i].Entire + (i<EntryPoints.Count-1?", ":"");
            return str;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            EntranceString = CreateEntranceString(EntryPoints);
            Saved = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numEntire_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedEntryPoint == null)
                return;
            SelectedEntryPoint.Entire = (int)numEntire.Value;
        }

        private void cmbMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedEntryPoint == null)
                return;
            SelectedEntryPoint.MapName= cmbMap.Text;
        }
    }
}
