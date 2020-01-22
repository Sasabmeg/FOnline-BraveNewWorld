using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using FOCommon.Parsers;
using FOCommon.WMLocation;

namespace WorldEditor
{
    public partial class frmAddMaps : Form
    {
        public List<Map> Maps;
        List<Map> UsedMaps;
        MapParser MapParser;

        public frmAddMaps(MapParser MapParser, List<Map> UsedMaps)
        {
            this.UsedMaps = UsedMaps;
            this.MapParser = MapParser;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool DupMap(List<Map> maps, Map map)
        {
            if (maps == null)
                return false;

            foreach (Map lmap in maps)
            {
                if (lmap.Pid == map.Pid)
                    return true;
            }
            return false;
        }

        private void frmAddMaps_Load(object sender, EventArgs e)
        {
            foreach (Map map in MapParser.GetMaps())
            {
                if (!DupMap(UsedMaps, map))
                    lstMaps.AddObject(map);
            }
        }

        private void btnAddMaps_Click(object sender, EventArgs e)
        {
            ArrayList SMaps = (ArrayList)lstMaps.SelectedObjects;
            SMaps.Cast<Map>();
            Maps = new List<Map>();
            foreach(Map map in SMaps.ToArray())
                    Maps.Add(map);
            this.Close();
        }
    }
}
