using System;
using System.Collections.Generic;
using System.Text;

using FOCommon.Maps;

namespace TiledMapper
{
    /// <summary>
    /// The class storing a single big tile defined in the presets file.
    /// </summary>
    public class BigTile
    {
        private List<FOCommon.Maps.Tile> Tiles;
        private List<MapObject> Objects;

        public BigTile()
        {
            Tiles = new List<FOCommon.Maps.Tile>();
            Objects = new List<MapObject>();
        }

        public void AddTileClone(FOCommon.Maps.Tile tile)
        {
            FOCommon.Maps.Tile t = (FOCommon.Maps.Tile)tile.Clone();
            t.X %= 2 * (Config.BigTileEdgeSize + 1);
            t.Y %= 2 * (Config.BigTileEdgeSize + 1);
            Tiles.Add(t);
        }

        public void AddObjectClone(MapObject obj)
        {
            MapObject o = (MapObject)obj.Clone();
            o.MapX %= 2 * (Config.BigTileEdgeSize + 1);
            o.MapY %= 2 * (Config.BigTileEdgeSize + 1);
            Objects.Add(o);
        }

        public List<FOCommon.Maps.Tile> GetClonedTiles(ushort btX, ushort btY)
        {
            List<FOCommon.Maps.Tile> ret = new List<FOCommon.Maps.Tile>();
            foreach (FOCommon.Maps.Tile tile in Tiles)
            {
                FOCommon.Maps.Tile t = (FOCommon.Maps.Tile)tile.Clone();
                t.X += (ushort)(2 * btX * Config.BigTileEdgeSize);
                t.Y += (ushort)(2 * btY * Config.BigTileEdgeSize);
                ret.Add(t);
            }
            return ret;
        }

        public List<MapObject> GetClonedObjects(ushort btX, ushort btY)
        {
            List<MapObject> ret = new List<MapObject>();
            foreach (MapObject obj in Objects)
            {
                MapObject o = (MapObject)obj.Clone();
                o.MapX += (ushort)(2 * btX * Config.BigTileEdgeSize);
                o.MapY += (ushort)(2 * btY * Config.BigTileEdgeSize);
                ret.Add(o);
            }
            return ret;
        }
    }
}
