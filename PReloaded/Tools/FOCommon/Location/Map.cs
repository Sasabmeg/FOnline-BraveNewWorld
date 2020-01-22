using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.WMLocation
{
    public class Map : System.IComparable<Map>
    {
        public string FileName { get; set; }
        public string Name { get; set; }
        public List<string> Music { get; set; }
        public string SoundString { get; set; }
        public string ScriptName { get; set; }
        public int Pid { get; set; }
        public string Time { get; set; }
        public bool NoLogout { get; set; }
        public bool Modified { get; set; }
        public bool AutoMap { get; set; }
        public int CompareTo(Map map)
        {
            if (this.Pid < map.Pid) return -1;
            if (this.Pid == map.Pid) return 0;
            return 1;
        }

        public override string ToString()
        {
            return "-- " + Name + " -- " + "\n" +
                Utils.ToStringProp("Pid", Pid.ToString()) +
                Utils.ToStringProp("FileName", FileName.ToString()) +
                Utils.ToStringProp("ScriptName", ScriptName.ToString()) +
                Utils.ToStringProp("SoundString", SoundString.ToString()) +
                Utils.ToStringProp("NoLogout", NoLogout.ToString());
        }


        public Map()
        {
            Music = new List<string>();
        }
    }
}
