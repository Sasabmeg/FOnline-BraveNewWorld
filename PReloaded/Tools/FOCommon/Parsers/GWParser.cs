using System;
using System.Collections.Generic;
using System.IO;

using FOCommon.WMLocation;

namespace FOCommon.Parsers
{
    // GenerateWorld.cfg
    public class GWParser : BaseParser, IParser
    {
        readonly List<Location> _locations = new List<Location>();
        readonly List<String> _lines = new List<string>();
        readonly string _filename;
        public GWParser(string filename)
        {
            this._filename = filename;
        }

        public bool Parse()
        {
            if (!File.Exists(_filename))
                return false;

            _locations.Clear();
            _lines.Clear();
            _lines.AddRange(File.ReadAllLines(_filename));
            foreach (String line in _lines)
            {
                if (line.Length < 3)
                    continue;
                string[] tokens = line.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "#")
                    continue;

                Location loc = new Location();
                int i = 0;
                if (tokens[0] == "@")
                {
                    i = 1;
                    loc.OnWorldmap = true;
                }
                else
                    loc.OnWorldmap = false;

                loc.Pid = Int32.Parse(tokens[i]);
                loc.X = Int32.Parse(tokens[i+1]);
                loc.Y = Int32.Parse(tokens[i+2]);
                
                _locations.Add(loc);
            }
            _IsParsed = true;
            return true;
        }

        public List<Location> GetLocations()
        {
            List<Location> locs = new List<Location>();
            locs.AddRange(_locations);
            return locs;
        }

        public bool Exists(Location loc)
        {
            foreach (Location gwLoc in _locations)
            {
                if (loc.Pid == gwLoc.Pid)
                    return true;
            }
            return false;
        }

        public void WriteLocations()
        {
            _locations.Sort();
            List<string> writeLines = new List<string>();
            foreach (Location gwLoc in _locations)
                writeLines.Add((gwLoc.OnWorldmap?"@ ":"")+gwLoc.Pid + " " + gwLoc.X + " " + gwLoc.Y);
            if(!File.Exists(_filename))
                Utils.Log(_filename + " doesn't exist. Can't write location data.");
            else
            {
                File.WriteAllLines(_filename, writeLines.ToArray());
                Utils.Log("GenerateWorld data written to " + _filename);
            }
        }

        public void AddLocation(Location loc)
        {
            _locations.Add(loc);
        }

        public void RemoveLocation(Location loc)
        {
            for(int i=0;i<_locations.Count;i++)
            {
                if (loc.Pid == _locations[i].Pid)
                    _locations.Remove(loc);
            }
        }
    }
}
