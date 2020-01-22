using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using FOCommon.WMLocation;
using FOCommon.Maps;
using FOCommon.Parsers;

// Simple caching mechanism, mainly for speeding up the WorldEditor. 
// Reading a lot of fomap files just to parse out the header data is slow on a HDD, especially if it's fragmented.
namespace FOCommon.Cache
{
    enum CacheType
    {
        MapHeader = 0
    };

    public class MapHeaderCache
    {
        public DateTime LastWriteTime;
        public MapHeader Data;

        public MapHeaderCache() { }
        public MapHeaderCache(DateTime LastWriteTime, string ScriptFunc, string ScriptModule, string Time, bool NoLogout)
        {
            this.Data = new MapHeader();
            this.LastWriteTime = LastWriteTime;
            this.Data.ScriptFunc = ScriptFunc;
            this.Data.ScriptModule = ScriptModule;
            this.Data.Time = Time;
            this.Data.NoLogOut = NoLogout;
        }
    }

    // TODO: Use reflection for read/write
    public static class Cache
    {
        static Dictionary<String, MapHeaderCache> _mapHeaders = new Dictionary<string, MapHeaderCache>();

        public static void Load(string fileName)
        {
            if (!File.Exists(fileName))
                return;
            foreach (String line in File.ReadAllLines(fileName))
            {
                string[] param = line.Split('|');
                int type = Int32.Parse(param[0]);
                if (type == (int)CacheType.MapHeader)
                {
                    _mapHeaders[param[1]] = new MapHeaderCache(DateTime.Parse(param[2]), param[3], param[4], param[5], param[6] == "1");
                }
            }
        }

        public static void Save(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, false);
            foreach (KeyValuePair<string, MapHeaderCache> kvp in _mapHeaders)
            {
                sw.WriteLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", (int)CacheType.MapHeader, kvp.Key, kvp.Value.LastWriteTime, kvp.Value.Data.ScriptFunc,
                    kvp.Value.Data.ScriptModule, kvp.Value.Data.Time, (kvp.Value.Data.NoLogOut == true ? "1" : "0")));
            }
            sw.Close();
        }

        private static MapHeaderCache ReadMapHeaderFile(string MapPath)
        {
            FOMapParser parser = new FOMapParser(MapPath);
            parser.Parse(true);

            MapHeaderCache hdc = new MapHeaderCache();
            hdc.Data = parser.Map.Header;
            hdc.LastWriteTime = File.GetLastWriteTime(MapPath);
            _mapHeaders[MapPath] = hdc;
            return hdc;
        }

        public static MapHeaderCache GetMapHeader(string MapPath)
        {
            if (!File.Exists(MapPath))
            {
                Utils.Log("Couldn't open " + MapPath + " to read header data. This means that a reference exists in Locations.cfg, yet the map doesn't exist.");
                return null;
            }

            if (!_mapHeaders.ContainsKey(MapPath))
                return ReadMapHeaderFile(MapPath);

            DateTime time = File.GetLastWriteTime(MapPath);

            if (DateTime.Parse(File.GetLastWriteTime(MapPath).ToString()).CompareTo(_mapHeaders[MapPath].LastWriteTime) != 0)
                return ReadMapHeaderFile(MapPath);

            return _mapHeaders[MapPath];
        }
    }
}
