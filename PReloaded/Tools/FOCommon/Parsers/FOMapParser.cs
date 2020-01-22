using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


using FOCommon.Maps;

namespace FOCommon.Parsers
{
    public class FOMapParser : BaseParser, IParser
    {
        public FOMap Map;
        public string FileName;

        enum ParseMode { Nothing, Header, Tiles, Objects, Finished }
        private ParseMode mode;

        public FOMapParser(string fileName)
        {
            _IsParsed = false;
            FileName = fileName;
        }

        public bool Parse()
        {
            return Parse(false);
        }

        public bool Parse(bool onlyHeader)
        {
            if (!File.Exists(FileName))
            {
                Utils.Log(FileName + " doesn't exist. Can't parse data.");
                return false;
            }

            Map = new FOMap();

            StreamReader r = File.OpenText(FileName);

            mode = ParseMode.Nothing;
            while (!r.EndOfStream && mode != ParseMode.Finished)
            {
                if (mode == ParseMode.Tiles && onlyHeader)
                    break;

                if (mode == ParseMode.Objects)
                {
                    parseObjects(r);
                    break;
                }

                string line = r.ReadLine();
                if (String.IsNullOrEmpty(line))
                    continue;
                if (updateModeLine(line)) continue;

                switch (mode)
                {
                    case ParseMode.Header:  parseHeaderLine(line); break;
                    case ParseMode.Tiles:   parseTileLine(line); break;
                    default: break;
                }
            }

            r.Close();
            _IsParsed = true;
            return true;
        }

        public bool Save()
        {
            if (Map == null) return false;
            StreamWriter w = new StreamWriter(FileName);
            w.NewLine = "\n";
            saveHeader(w);
            saveTiles(w);
            saveObjects(w);
            w.WriteLine();
            w.Close();
            return true;
        }

        private bool updateModeLine(string line)
        {
            if (line.Equals("[Header]"))
            {
                mode = ParseMode.Header;
                return true;
            }
            if (line.Equals("[Tiles]"))
            {
                mode = ParseMode.Tiles;
                return true;
            }
            if (line.Equals("[Objects]"))
            {
                mode = ParseMode.Objects;
                return true;
            }
            return false;
        }

        private void parseHeaderLine(string line)
        {
            int idx = line.IndexOf(" ");
            string arg = line.Substring(0, idx);
            string value = line.Substring(idx, line.Length - idx).TrimStart(" ".ToCharArray());
            PropertyInfo prop = typeof(MapHeader).GetProperty(arg);
            if (prop != null && prop.CanWrite)
            {
                object obj = resolveProp(prop, value);
                prop.SetValue(Map.Header, obj, null);
            }
        }

        private object resolveProp(PropertyInfo prop, string value)
        {
            if (prop.PropertyType == typeof(UInt16)) return UInt16.Parse(value);
            if (prop.PropertyType == typeof(int)) return int.Parse(value);
            if (prop.PropertyType == typeof(string)) return value;
            if (prop.PropertyType == typeof(bool)) return (bool)(int.Parse(value) != 0);
            return null;
        }

        private void parseTileLine(string line)
        {
            string[] spl = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string mods = spl[0].Length > 5 ? spl[0].Substring(5, spl[0].Length - 5) : "";
            int idx = 0;
            bool roof = spl[idx++].Substring(0, 4).Equals("roof");
            UInt16 hx = UInt16.Parse(spl[idx++]);
            UInt16 hy = UInt16.Parse(spl[idx++]);
            int offsX = 0;
            int offsY = 0;
            int layer = 0;
            if(mods.Contains("o"))
            {
                offsX = int.Parse(spl[idx++]);
                offsY = int.Parse(spl[idx++]);
            }
            if (mods.Contains("l"))
            {
                layer = int.Parse(spl[idx++]);
            }
            Tile tile = new Tile(roof, hx, hy, spl[idx], layer, offsX, offsY);
            Map.AddTile(tile);
        }

        private void parseObjects(StreamReader r)
        {
            MapObject obj = null;
            while (!r.EndOfStream)
            {
                string line = r.ReadLine();
                if (String.IsNullOrEmpty(line)) continue;
                string[] spl = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (spl[0].Equals("MapObjType"))
                {
                    if(obj != null) Map.AddObject(obj);
                    obj = new MapObject();
                    obj.MapObjType = int.Parse(spl[1]);
                    continue;
                }
                if (spl[0].Equals("ProtoId"))
                {
                    obj.ProtoId = UInt16.Parse(spl[1]);
                    continue;
                }
                if (spl[0].Equals("MapX"))
                {
                    obj.MapX = UInt16.Parse(spl[1]);
                    continue;
                }
                if (spl[0].Equals("MapY"))
                {
                    obj.MapY = UInt16.Parse(spl[1]);
                    continue;
                }
                obj.Properties.Add(spl[0], spl[1]);
            }
            if (obj != null) Map.AddObject(obj);
        }

        private void saveHeader(StreamWriter w)
        {
            w.WriteLine("[Header]");
            PropertyInfo[] properties = typeof(MapHeader).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                if (prop.PropertyType == typeof(Boolean))
                {
                    string fmtc = string.Format(@"{0,-21}{1}", prop.Name, (bool)(prop.GetValue(Map.Header, null)) ? "1" : "0");
                    w.WriteLine(fmtc);
                    continue;
                }
                string fmt = string.Format(@"{0,-21}{1}", prop.Name, prop.GetValue(Map.Header, null));
                w.WriteLine(fmt);
            }
            w.WriteLine();
        }

        private void saveTiles(StreamWriter w)
        {
            w.WriteLine("[Tiles]");
            foreach (Tile tile in Map.Tiles)
            {
                string tileStr = tile.Roof ? "roof" : "tile";
                string offStr = "        ";
                string layerStr = "  ";
                bool hasOffset = tile.OffsX != 0 || tile.OffsY != 0;
                bool hasLayer = tile.Layer != 0;
                if (hasLayer || hasOffset)
                {
                    tileStr += "_";
                    if (hasOffset)
                    {
                        tileStr += "o";
                        offStr = string.Format(@"{0,-3} {1,-3} ", tile.OffsX, tile.OffsY);
                    }
                    if (hasLayer)
                    {
                        tileStr += "l";
                        layerStr = string.Format(@"{0,-2}", tile.Layer);
                    }
                }
                string total = string.Format(@"{0,-10} {1,-4} {2,-4} {3}{4}", tileStr, tile.X, tile.Y, offStr, layerStr) + tile.Path;
                w.WriteLine(total);
            }
            w.WriteLine();
        }

        private void saveObjects(StreamWriter w)
        {
            w.WriteLine("[Objects]");
            foreach (MapObject obj in Map.Objects)
            {
                w.WriteLine("MapObjType           " + obj.MapObjType.ToString());
                w.WriteLine("ProtoId              " + obj.ProtoId.ToString());
                if (obj.MapX != 0) w.WriteLine("MapX                 " + obj.MapX.ToString());
                if (obj.MapY != 0) w.WriteLine("MapY                 " + obj.MapY.ToString());
                foreach (KeyValuePair<string, string> kvp in obj.Properties)
                {
                    string fmt = string.Format(@"{0,-20} {1}", kvp.Key, kvp.Value);
                    w.WriteLine(fmt);
                }
                w.WriteLine("");
            }
        }
    }
}