using System;
using System.Collections.Generic;
using System.IO;
using FOCommon.WMLocation;

namespace FOCommon.Parsers
{
    public class MapParser : BaseParser, IParser
    {
        string PathMaps;
        string PathCity;
        List<Map> Maps = new List<Map>();
        FOGMParser GMParser;
        IniReader Ini;

        public MapParser(FOGMParser GMParser, string PathMaps, string PathCity)
        {
            this.PathCity = PathCity;
            this.PathMaps = PathMaps;
            this.Ini = new IniReader(PathMaps);
            this.GMParser = GMParser;
        }

        public void AddMap(Map map)
        {
            Maps.Add(map);
            Maps.Sort();
        }

        string GetValue(string str)
        {
            return str.Split('=')[1];
        }

        public bool Parse()
        {
            List<String> Lines = new List<string>(File.ReadAllLines(PathCity));

            List<String> MapFileNames = new List<string>();
            int Count = 0;
            foreach (string Line in Lines)
            {
                Count++;
                if (Line.Length>4&&Line.Substring(0, 4) == "map_")
                {
                    Map map = new Map();
                        
                    char[] sep = { ' ' };
                    String[] Parts = GetValue(Line).Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    string MapName = Parts[0];
                    if (MapName.Contains("*"))
                    {
                        MapName=MapName.Replace("*", "");
                        map.AutoMap = true;
                    }
                    if (MapFileNames.Contains(MapName))
                        continue;
                    MapFileNames.Add(MapName);
                    map.FileName = MapName;
                    int Pid = 0;
                    if (Int32.TryParse(Parts[1], out Pid))
                        map.Pid = Pid;
                    else
                    {
                        Utils.Log("MapParser: Failed to parse map pid on line "+Count);
                        continue;
                    }

                    String MapPath = PathMaps + map.FileName + ".fomap";
                    Maps.MapHeader header = Cache.Cache.GetMapHeader(MapPath).Data; // CALL
                    if (!String.IsNullOrEmpty(header.ScriptModule) && header.ScriptModule != "-" && header.ScriptFunc != "-")
                        map.ScriptName = header.ScriptModule + "@" + header.ScriptFunc;
                    else
                        map.ScriptName = "";

                    map.NoLogout = header.NoLogOut;
                    map.Time     = header.Time;

                    Maps.Add(map);
                }
            }
            foreach (Map map in Maps)
                GMParser.FillMapInfo(map);
            _IsParsed = true;
            return true;
        }

        public List<Map> GetMaps()
        {
            return Maps;
        }

        public bool MapExists(Map map)
        {
            foreach (Map lmap in Maps)
            {
                if (map.Pid == lmap.Pid)
                    return true;
            }
            return false;
        }

        public void RemoveMap(Map map)
        {
            //Ini.DeleteEntry("Map " + map.Pid);
            Maps.Remove(map);
        }

        public List<Map> GetMapsFromFileNames(List<String> MapNames)
        {
            List<Map> RetMaps = new List<Map>();

            for (int i = 0; i < MapNames.Count;i++ )
            {
                foreach (Map map in Maps)
                    if (map.FileName == MapNames[i])
                        RetMaps.Add(map);
            }
            return RetMaps;
        }

        string WriteMapEntry(string Header, string Value)
        {
            string Entry = Header;
            int Len= 21 - Entry.Length;
            for (int i = 0; i < Len; i++)
                Entry += " ";
            Entry += Value;
            return Entry;
        }

        public void SaveMaps()
        {
            Maps.Sort();

            foreach (Map map in Maps)
            {
                String MapPath = PathMaps + map.FileName + ".fomap";
                if (!File.Exists(MapPath))
                {
                    Utils.Log(map.FileName + " doesn't exist.");
                    continue;
                }

                if (!map.Modified)
                    continue;

                Utils.Log("Saving changes made to " + map.FileName + "...");
                
                List<String> Lines = new List<String>(File.ReadAllLines(MapPath));
                for(int i=0;i<Lines.Count;i++)
                {
                    if(Lines[i].Contains("ScriptModule"))
                    {
                        if (!String.IsNullOrEmpty(map.ScriptName))
                        {
                            String[] split = map.ScriptName.Split('@');
                            Lines[i] = WriteMapEntry("ScriptModule", split[0]);
                            Lines[i + 1] = WriteMapEntry("ScriptFunc", split[1]);
                        }
                        else
                        {
                            Lines[i] = WriteMapEntry("ScriptModule", "-");
                            Lines[i + 1] = WriteMapEntry("ScriptFunc", "-");
                        }
                        Lines[i + 2] = WriteMapEntry("NoLogOut", map.NoLogout?"1":"0");
                        Lines[i + 3] = WriteMapEntry("Time", (map.Time=="")?"-1":map.Time);
                        break;
                    }
                }

                Utils.Log("Opening " + MapPath + " to write map header data.");
                using (StreamWriter sw = new StreamWriter(MapPath))
                {
                    sw.NewLine = "\n"; // Important!
                    foreach (String Line in Lines)
                    {
                        sw.WriteLine(Line);
                    }
                }
                Utils.Log("Header data written to " + MapPath + ".");
            }
            
            GMParser.WriteMapDataBlock(Maps);
        }

        public int GetFreeMapPID(int start)
        {
            List<Int32> UsedPids = new List<int>();
            foreach (Map map in Maps)
                UsedPids.Add(map.Pid);
            for (int i = start; i < 999; i++)
                if (!UsedPids.Contains(i))
                    return i;
            return -1;
        }
    }
}
