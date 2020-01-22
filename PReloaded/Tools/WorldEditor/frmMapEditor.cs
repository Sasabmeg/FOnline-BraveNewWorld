using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FOCommon.Parsers;
using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmMapEditor : Form
    {
        frmEditMap EditMap;
        MapParser parser;

        public frmMapEditor(MapParser parser)
        {
            this.parser = parser;
            InitializeComponent();
            this.olvMusic.AspectToStringConverter = delegate(object x)
            {
                List<String> MusicNames = (List<String>)x;
                return String.Format("{0}", Utils.ToCSV(", ", MusicNames));
            };
        }

        private void frmEditMaps_Load(object sender, EventArgs e)
        {
            lstMaps.SetObjects(parser.GetMaps());
            lstMaps.RestoreState(TableSerializer.Load("lstMaps"));
        }

        private void lstMaps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Map map = (Map)lstMaps.SelectedObject;
            if (map == null)
                return;
            EditMap = new frmEditMap(map, parser, false);
            EditMap.ShowDialog();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            TableSerializer.Save("lstMaps", lstMaps.SaveState());
            this.Close();
        }

        private void btnAddNewMap_Click(object sender, EventArgs e)
        {
            EditMap = new frmEditMap(null, parser, true);
            EditMap.ShowDialog();
            if (EditMap.save)
            {
                parser.AddMap(EditMap.Map);
                lstMaps.SetObjects(parser.GetMaps());
            }
        }

        private void btnRemoveMap_Click(object sender, EventArgs e)
        {
            RemoveSelectedMap();
        }

        private void RemoveSelectedMap()
        {
            Map map = (Map)lstMaps.SelectedObject;
            if (map == null)
                return;

            parser.RemoveMap(map);
            lstMaps.SetObjects(parser.GetMaps());
        }

        private void btnEditInMapper_Click(object sender, EventArgs e)
        {
            Map map = (Map)lstMaps.SelectedObject;
            if (map == null)
                return;

            if (!FOCommon.Utils.LaunchMapper(map, Config.PathMapper, Config.PathMapsDir))
                Message.Show("Mapper not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstMaps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveSelectedMap();
            }
        }
    }
}
