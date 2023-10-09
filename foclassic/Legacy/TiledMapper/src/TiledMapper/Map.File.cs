using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using TiledMapper.Xml;

namespace TiledMapper
{
    public partial class Map
    {
        /// <summary>
        /// Create a new map instance and associate the form controls.
        /// </summary>
        /// <param name="width">Width of the map in tiles</param>
        /// <param name="height">Height of the map in tiles</param>
        /// <param name="dbox">Drawing box for the map representation</param>
        /// <param name="undo">Delegate disabling and enabling the 'undo' action</param>
        /// <param name="redo">Delegate disabling and enabling the 'redo' action</param>
        /// <param name="postMode">Delegate changing edit mode on the interface</param>
        /// <returns></returns>
        public static Map NewMap(int width, int height, System.Windows.Forms.PictureBox dbox, ValueSetterDelegate undo, ValueSetterDelegate redo, ValueSetterDelegate postMode)
        {
            Map map = new Map(width, height, dbox, undo, redo, postMode);
            map.setPostMode(false);
            map.FullRedraw();

            return map;
        }

        /// <summary>
        /// Load a map instance from a file.
        /// </summary>
        /// <param name="fileName">Path for the file</param>
        /// <param name="dbox">Drawing box for the map representation</param>
        /// <param name="undo">Delegate disabling and enabling the 'undo' action</param>
        /// <param name="redo">Delegate disabling and enabling the 'redo' action</param>
        /// <param name="postMode">Delegate changing edit mode on the interface</param>
        /// <returns></returns>
        public static Map LoadMap(string fileName, System.Windows.Forms.PictureBox dbox, ValueSetterDelegate undo, ValueSetterDelegate redo, ValueSetterDelegate postMode)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlElement d = doc.DocumentElement;

            if (d.Name != "tilemap")
            {
                throw new XmlMapperException("not a tiled map file");
            }

            bool convert = !d.HasAttribute("version");

            bool convert2 = convert || !d.GetAttribute("version").Equals(Config.MapVersion);

            XmlElement el = d.FirstChildElement("header");
            if (el == null)
                throw new XmlMapperException("no header was found");

            int width = el.GetIntAttribute("width");
            int height = el.GetIntAttribute("height");
            bool post = el.GetBoolAttribute("details");

            Map map = new Map(width, height, dbox, undo, redo, postMode);

            el = d.FirstChildElement("scrollblockers");
            if (el == null)
                throw new XmlMapperException("no scrollblockers info found");

            XmlNodeList nl = el.GetElementsByTagName("scrollblocker");
            for (int i = 0; i < nl.Count; i++)
            {
                XmlElement sn = nl.Item(i).TryToElement();
                if (sn == null) continue;
                int x = sn.GetIntAttribute("x");
                int y = sn.GetIntAttribute("y");

                map.tiles[x, y].ScrollBlocker = map.scrollBlockers.Count;
                map.scrollBlockers.Add(new Pair<int, int>(x, y));
            }

            el = d.FirstChildElement("tiles");
            if (el == null)
                throw new XmlMapperException("no tiles info found");

            nl = el.GetElementsByTagName("tile");
            for (int i = 0; i < nl.Count; i++)
            {
                XmlElement sn = nl.Item(i).TryToElement();
                if (sn == null) continue;
                int x = sn.GetIntAttribute("x");
                int y = sn.GetIntAttribute("y");
                int variant = sn.GetIntAttribute("variant");
                bool filled = sn.TryGetBoolAttribute("filled");
                if (convert)
                {
                    if (variant == 0) variant = -1;
                    else if (variant == 1) variant = 0;
                }

                if (convert2)
                {
                    if (variant == -1)
                        variant = 0;
                    else filled = true;
                }

                bool wide = sn.GetBoolAttribute("wide");
                string walls = sn.GetAttribute("walls");

                Tile tile = map.tiles[x, y];
                tile.Filled = filled;
                tile.Variant = variant;
                tile.Wide = wide;

                bool[] w = parseBools(walls);
                for (int j = 0; j < 4; j++)
                    tile.SetBlock(j, w[j]);
            }
            map.post = post;

            map.setPostMode(post);
            map.FullRedraw();
            return map;
        }

        /// <summary>
        /// Save the map instance.
        /// </summary>
        /// <param name="fileName">File name for the saved map</param>
        public void Save(string fileName)
        {
            XmlDocument d = new XmlDocument();
            XmlElement root = d.CreateElement("tilemap");
            root.SetAttribute("version", Config.MapVersion);
            d.AppendChild(root);

            XmlElement el = d.CreateElement("header");
            el.SetAttribute("width",Width.ToString());
            el.SetAttribute("height",Height.ToString());
            el.SetAttribute("details", post.ToString().ToLower());

            d.DocumentElement.AppendChild(el);

            XmlElement blocks = d.CreateElement("scrollblockers");
            for (int i = 1; i < scrollBlockers.Count; i++)
            {
                XmlElement bl = d.CreateElement("scrollblocker");
                bl.SetAttribute("x", scrollBlockers[i].First.ToString());
                bl.SetAttribute("y", scrollBlockers[i].Second.ToString());
                blocks.AppendChild(bl);
            }
            d.DocumentElement.AppendChild(blocks);

            XmlElement allTiles = d.CreateElement("tiles");
            for (int y=0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    Tile tile=tiles[x, y];
                    XmlElement t = d.CreateElement("tile");
                    t.SetAttribute("x", x.ToString());
                    t.SetAttribute("y", y.ToString());
                    t.SetAttribute("variant", tile.Variant.ToString());
                    t.SetAttribute("wide", tile.Wide.ToString().ToLower());
                    t.SetAttribute("walls",
                        tile.GetBlock(Directions.North).ToString().ToLower() + "," +
                        tile.GetBlock(Directions.East).ToString().ToLower() + "," +
                        tile.GetBlock(Directions.South).ToString().ToLower() + "," +
                        tile.GetBlock(Directions.West).ToString().ToLower()
                        );
                    if (tile.Filled) t.SetAttribute("filled", true.ToString().ToLower());
                    allTiles.AppendChild(t);
                }
            d.DocumentElement.AppendChild(allTiles);

            d.Save(fileName);
        }

        private static bool[] parseBools(string s)
        {
            bool[] ret = new bool[4];
            string[] spl = s.Split(',');
            if (spl.Length != 4)
                throw new XmlMapperException("wrong walls format");

            for (int i = 0; i < 4; i++)
                ret[i] = XmlConvert.ToBoolean(spl[i]);

            return ret;
        }
    }
}