using System;
using System.Collections.Generic;
using System.IO;
using FOCommon.WMLocation;


namespace FOCommon.Parsers
{
    public class LocationParser : BaseParser, IParser
    {
        readonly MapParser _mapParse;
        readonly GWParser _gwParser;
        readonly FOGMParser _gmParser;
        readonly String _locationsCfgPath;
        readonly IniReader _ini;
        List<Location> _locations;

        public LocationParser(string locationsCfgPath, MapParser mapParse, GWParser gwParse, FOGMParser gmParser)
        {
            _ini              = new IniReader(locationsCfgPath);
            _locationsCfgPath = locationsCfgPath;
            _mapParse         = mapParse;
            _gwParser         = gwParse;
            _gmParser         = gmParser;
        }

        string GetTextFromIndexToChar(string str, int index, char c)
        {
            int findex = str.IndexOf(c, index, str.Length-index);
            string ret = str.Substring(index, findex - index);
            return ret;
        }

        void PrepareEntires(Location loc)
        {
            if (string.IsNullOrEmpty(loc.Entrance))
                return;

            int num;
            if(Int32.TryParse(loc.Entrance, out num)) // one entry per map
            {
                if (loc.EntryPoints == null)
                    loc.EntryPoints = new List<EntryPoint>();
                for (int i = 0; i < num; i++)
                {
                    if (i == loc.EntryPoints.Count)
                        loc.EntryPoints.Add(new EntryPoint());
                    if(loc.Maps != null && loc.Maps.Count-1>=i)
                        loc.EntryPoints[i].MapName = loc.Maps[i].FileName;
                }
            }
            else // it's more complex
            {
                string str = loc.Entrance;
                str=str.Remove(0, 1);
                string[] entpoints = str.Split(',');
                if(loc.EntryPoints.Count!=entpoints.Length)
                    Utils.Log("Mismatch in entry point size: " + loc.Name + "["+loc.Pid+"]");

                string[] tok = { " " };
                for (int i = 0; i < loc.EntryPoints.Count; i++)
                {
                    string[] param = entpoints[i].Split(tok, StringSplitOptions.RemoveEmptyEntries);
                    loc.EntryPoints[i].Entire = Int32.Parse(param[1]);
                    loc.EntryPoints[i].MapName = loc.Maps[Int32.Parse(param[0])].FileName;
                }
            }
        }

        List<Location> GetLocationCfgInformation(List<Location> locations)
        {
            List<String> Lines = new List<string>(File.ReadAllLines(_locationsCfgPath));

            Location Loc = null;
            bool newloc = true;
            List<String> MapFileNames = new List<string>();
            char[] Sep = { ' ' };

            foreach (string line in Lines)
            {
                if (line.Length > 3)
                {
                    if (line.Substring(0, 5) == "[Area")
                    {
                        if (Loc != null)
                        {
                            Loc.Maps = _mapParse.GetMapsFromFileNames(MapFileNames);
                            MapFileNames = new List<string>();
                            if (newloc)
                                locations.Add(Loc);
                        }
                        newloc = true;
                        Loc = new Location();
                        Loc.Pid = Int32.Parse(GetTextFromIndexToChar(line, 5, ']'));
                        for (int k = 0; k < locations.Count; k++)
                            if (locations[k].Pid == Loc.Pid)
                            {
                                Loc = locations[k];
                                newloc = false;
                            }
                    }

                    String[] Parts = line.Split(new char[]{'='}, StringSplitOptions.RemoveEmptyEntries);
                    if (Parts.Length < 2)
                        continue;
                    string FieldName = Parts[0];
                    string FieldValue = Parts[1];
                    FieldName = FieldName.Trim();
                    FieldValue = FieldValue.Trim();

                    if (Loc == null) continue;

                         if (FieldName=="name") Loc.Name = FieldValue;
                    else if (FieldName=="max_players") Loc.MaxPlayers = Int32.Parse(FieldValue);
                    else if (FieldName=="size") Loc.Size = Int32.Parse(FieldValue);
                    else if (FieldName=="entrance") Loc.Entrance = FieldValue;
                    else if (FieldName== "entrance_script") Loc.EntranceScript = FieldValue;
                    else if (FieldName=="visible") Loc.Visible = (Int32.Parse(FieldValue) == 1 ? true : false);
                    else if (FieldName== "auto_garbage") Loc.AutoGarbage = (Int32.Parse(FieldValue) == 1 ? true : false);
                    else if (FieldName=="max_players") Loc.MaxPlayers = Int32.Parse(FieldValue);
                    else if (FieldName== "geck_visible") Loc.GeckVisible = (Int32.Parse(FieldValue) == 1 ? true : false);
                    else if (FieldName.Length > 4 && FieldName.Substring(0, 4) == "map_") MapFileNames.Add(FieldValue.Split(Sep)[0].Replace("*", ""));
                    else if (FieldName.Length > 3 && FieldName.Substring(0, 2) == "#@") Loc.Flags.Add(GetTextFromIndexToChar(line, 2, '='));
                }
            }
            if (Loc == null)
                return locations;

            Loc.Maps = _mapParse.GetMapsFromFileNames(MapFileNames);

            MapFileNames = new List<string>();
            if (newloc)
                locations.Add(Loc);

            return locations;
        }

        public List<Location> GetLocations()
        {
            return this._locations;
        }

        public bool Parse()
        {
            List<Location> locations = _gwParser.GetLocations();
            locations = GetLocationCfgInformation(locations);
            foreach (Location loc in locations)
            {
                _gmParser.FillLocationInfo(loc);
                PrepareEntires(loc);
            }
            this._locations = locations;

            _IsParsed = true;
            return true;
        }

        public void RemoveLocation(Location Loc)
        {
            _gwParser.RemoveLocation(Loc);
        }

        public bool IsFreeLocationPID(int pid)
        {
            return (String.IsNullOrEmpty(_ini.IniReadValue("Area " + pid, "name")));
        }

        public int GetFreeLocationPID(int start)
        {
            for (int i = start; i < 999; i++)
            {
                if (String.IsNullOrEmpty(_ini.IniReadValue("Area " + i, "name")))
                    return i;
            }
            return -1;
        }

        public void SaveLocations(List<Location> locations)
        {
            locations.Sort();
            _locations = locations;

            List<String> Lines = new List<string>(File.ReadAllLines(_locationsCfgPath));
            int LineStart = Lines.IndexOf("# Max area = 500") + 2;
            Lines.RemoveRange(LineStart, Lines.Count - LineStart);
            foreach (Location Loc in locations)
            {
                Lines.Add("");
                Lines.Add("[Area " + Loc.Pid + "]");
                Lines.Add("name=" + Loc.Name);
                Lines.Add("size=" + Loc.Size);
                Lines.Add("visible=" + (Loc.Visible? "1" : "0"));
                Lines.Add("auto_garbage=" + (Loc.AutoGarbage?"1":"0"));
                Lines.Add("geck_visible=" + (Loc.GeckVisible ?"1":"0"));
                if(Loc.MaxPlayers>0)
                    Lines.Add("max_players="+Loc.MaxPlayers);
                if(!String.IsNullOrEmpty(Loc.EntranceScript))
                    Lines.Add("entrance_script=" + Loc.EntranceScript);
                for (int i = 0; i < Loc.Maps.Count;i++)
                    Lines.Add("map_"+i+"=" + Loc.Maps[i].FileName+(Loc.Maps[i].AutoMap?"*":"")+ " "+Loc.Maps[i].Pid);
                if (!String.IsNullOrEmpty(Loc.Entrance))
                    Lines.Add("entrance=" + Loc.Entrance);
                foreach (String Flag in Loc.Flags)
                    Lines.Add("#@" + Flag + "=1");

                    if (Loc.OnWorldmap && !_gwParser.Exists(Loc))
                        _gwParser.AddLocation(Loc);
                    else if (!Loc.OnWorldmap && _gwParser.Exists(Loc))
                        _gwParser.RemoveLocation(Loc);
            }
            Utils.Log("Writing Locations.cfg data to " + _locationsCfgPath);
            File.WriteAllLines(_locationsCfgPath, Lines.ToArray());
            Utils.Log("Data written to " + _locationsCfgPath);

            _gwParser.WriteLocations();
            _gmParser.WriteLocationDataBlock(locations);
        }
    }
}
