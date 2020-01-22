using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.WMLocation
{
    enum LocationSize
    {
        Small = 12,
        Medium = 24,
        Big = 32,
    }

    public class Location : IComparable<Location>
    {
        public int Pid { get; set;}
        public int X { get; set;}
        public int Y { get; set; }
        public List<Map> Maps { get; set; }
        public string Name { get; set; }
        public string WorldMapName { get; set; }
        public string WorldMapDescription { get; set; }
        public string WorldMapTownImagePath { get; set; }
        public string WorldMapSignImagePath { get; set; }
        public List<EntryPoint> EntryPoints { get; set; }
        public int MaxPlayers { get; set;}
        public int Size { get; set; }
        public string Entrance { get; set; }
        public string EntranceScript { get; set; }
        public List<string> Flags { get; set; }
        public bool Visible { get; set; }
        public bool GeckVisible { get; set; }
        public bool AutoGarbage {get; set; }
        public bool OnWorldmap { get; set; }
        public bool Modified { get; set; }

        public Location()
        {
            Flags = new List<string>();
        }

        public override string ToString()
        {
            return "-- " + Name + " -- " + "\n" +
                Utils.ToStringProp("Pid", Pid.ToString()) +
                Utils.ToStringProp("Coords", X + "," + Y) +
                Utils.ToStringProp("Visible", (Visible ? "Yes" : "No"));
        }

        public List<String> MapFileNamesToList()
        {
            List<String> names = new List<string>();
            foreach (Map map in Maps)
            {
                names.Add(map.FileName);
            }
            return names;
        }

        public int CompareTo(Location loc)
        {
            if (this.Pid < loc.Pid) return -1;
            if (this.Pid == loc.Pid) return 0;
            return 1;
        }
    }
}
