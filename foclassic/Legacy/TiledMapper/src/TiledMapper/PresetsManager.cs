using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using FOCommon.Parsers;
using FOCommon.Maps;

namespace TiledMapper
{
    /// <summary>
    /// The class responsible for management of preset contents and
    /// translation of tile codes into their indicies (as stored in Presets).
    /// </summary>
    public static class PresetsManager
    {
        static Dictionary<string, Preset> cache;
        static Dictionary<int, int> tileNum;
        static Dictionary<int, int> wideTileNum;
        static int[] adapterNum;
        static bool blockParsed;

        /// <summary>
        /// Initialize the PresetsManager.
        /// </summary>
        public static void Init()
        {
            cache = new Dictionary<string, Preset>();
            tileNum = new Dictionary<int, int>();
            wideTileNum = new Dictionary<int, int>();
            adapterNum = new int[4];
            Invalidate();
        }

        /// <summary>
        /// Reset the class and the cache.
        /// </summary>
        public static void Invalidate()
        {
            blockParsed = false;
            cache.Clear();
            tileNum.Clear();
            wideTileNum.Clear();
            for (int i = 0; i < 4; i++) adapterNum[i] = -1;
        }

        /// <summary>
        /// Gets the preset with a given name.
        /// </summary>
        /// <param name="name">Name of the preset</param>
        /// <returns></returns>
        public static Preset GetPreset(string name)
        {
            if (!blockParsed) parseBlocks();
            if (!cache.ContainsKey(name))
            {
                if (!precache(name)) return null;
            }

            return cache[name];
        }

        /// <summary>
        /// Returns index of a normal tile with a given hash.
        /// </summary>
        /// <param name="hash">The tile's hash</param>
        /// <returns></returns>
        public static int GetNum(int hash)
        {
            if (!tileNum.ContainsKey(hash)) return -1;
            return tileNum[hash];
        }

        /// <summary>
        /// Returns index of a wide tile with a given hash.
        /// </summary>
        /// <param name="hash">The tile's hash</param>
        /// <returns></returns>
        public static int GetWideNum(int hash)
        {
            if (!wideTileNum.ContainsKey(hash)) return -1;
            return wideTileNum[hash];
        }

        /// <summary>
        /// Returns index of an adapter tile.
        /// </summary>
        /// <param name="dir">Adapter's direction</param>
        /// <returns></returns>
        public static int GetAdapterNum(int dir)
        {
            return adapterNum[dir];
        }

        private static void parseBlocks()
        {
            FOCommon.Utils.Log("Parsing block txt...");
            StreamReader r = new StreamReader(Config.PresetsPath + @"\block.txt");
            int idx = 0;
            while (!r.EndOfStream)
            {
                string line = r.ReadLine();
                bool wide = false;
                if (string.IsNullOrEmpty(line)) continue;

                if (line.Length == 9)
                {
                    char c = line[0];
                    line = line.Remove(0, 1);

                    switch(c)
                    {
                        case 'W':
                        {
                            wide = true;
                            break;
                        }
                        case 'n':
                        {
                            adapterNum[Directions.North] = idx++;
                            continue;
                        }
                        case 'e':
                        {
                            adapterNum[Directions.East] = idx++;
                            continue;
                        }
                        case 's':
                        {
                            adapterNum[Directions.South] = idx++;
                            continue;
                        }
                        case 'w':
                        {
                            adapterNum[Directions.West] = idx++;
                            continue;
                        }
                        default: break;
                    }
                }
                int hash = Convert.ToInt32(line, 2);
                if (wide)
                    wideTileNum.Add(hash, idx);
                else
                    tileNum.Add(hash, idx);
                idx++;
            }
            blockParsed = true;
            r.Close();
            if (!checkBlocks())
                MainForm.ErrorBox("There were errors while parsing block.txt. See the log for details.", "Error!");
            else
                FOCommon.Utils.Log("block.txt parsed.");
        }

        private static bool checkBlocks()
        {
            List<string> missing = new List<string>();
            for (int i = 0; i < 256; i++)
            {
                if (ignoreBlock(i)) continue;
                if (!tileNum.ContainsKey(i))
                    missing.Add(Utils.HashCode(i));
            }

            int[] wides = { 165, 231, 189 };

            for (int i = 0; i < 3; i++)
            {
                if (!wideTileNum.ContainsKey(wides[i]))
                    missing.Add("W" + Utils.HashCode(wides[i]));
            }

            
            for (int i = 0; i < 4; i++)
            {
                if (adapterNum[i] == -1)
                {
                    char c = Directions.ToChar(i);
                    if (i == Directions.North || i == Directions.South)
                        missing.Add(c + "10100101");
                    else
                        missing.Add(c + "11100111");
                }
            }

            if (missing.Count > 0)
            {
                FOCommon.Utils.Log(
                    string.Format("The following tiles are missing from block.txt: {0}.",
                    string.Join(", ", missing.ToArray())));
                return false;
            }
            return true;
        }

        private static bool ignoreBlock(int hash)
        {
            if (dtest(hash, 2, 1, 4)) return true;
            if (dtest(hash, 8, 1, 32)) return true;
            if (dtest(hash, 16, 4, 128)) return true;
            if (dtest(hash, 64, 128, 32)) return true;
            return false;
        }

        private static int b(int i)
        {
            return 1 << i;
        }

        private static bool dtest(int hash, int mid, int l, int r)
        {
            if ((hash & mid) == 0) return false;
            return ((hash & l) == 0) || ((hash & r) == 0);
        }

        private static bool precache(string name)
        {
            FOMapParser parser = new FOMapParser(Config.PresetsPath + @"\" + name);
            if (!parser.Parse()) return false;

            FOMap map = parser.Map;

            Preset p = new Preset();
            foreach (FOCommon.Maps.Tile tile in map.Tiles)
            {
                BigTile bt = p.GetBigTile(tile.X / (2 * (Config.BigTileEdgeSize + 1)),
                    (tile.Y / (2 * (Config.BigTileEdgeSize + 1)) + 1), true);
                bt.AddTileClone(tile);
            }

            foreach (MapObject obj in map.Objects)
            {
                BigTile bt = p.GetBigTile(obj.MapX / (2 * (Config.BigTileEdgeSize + 1)),
                    (obj.MapY / (2 * (Config.BigTileEdgeSize + 1)) + 1), true);
                bt.AddObjectClone(obj);
            }

            cache.Add(name, p);
            return true;
        }
    }
}
