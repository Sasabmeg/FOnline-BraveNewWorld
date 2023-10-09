using System;
using System.Collections.Generic;
using System.Text;

using FOCommon.Maps;
using FOCommon.Parsers;

namespace TiledMapper
{
    public class CompilerException : Exception
    {
        public readonly string Text;
        public CompilerException(string text)
        {
            this.Text = text;
        }
    }

    public partial class Map
    {
        private class ScrollblockersPlacer : LineTracerCallback
        {
            public ushort Hx { get; private set; }
            public ushort Hy { get; private set; }
            public ushort Tx { get; private set; }
            public ushort Ty { get; private set; }
            public ushort MaxHx { get; private set; }
            public ushort MaxHy { get; private set; }
            public int Dist { get; private set; }
            public double Angle { get; private set; }
            private FOMap fomap;
            public ScrollblockersPlacer(Pair<int, int> from, Pair<int, int> to, Map map, FOMap fomap)
            {
                this.fomap = fomap;
                Angle = 0;
                Dist = 0;
                MaxHx = (ushort)(2 * Config.BigTileEdgeSize * map.Width);
                MaxHy = (ushort)(2 * Config.BigTileEdgeSize * map.Height);
                Hx = (ushort)((map.Width - from.First - 1) * (2 * Config.BigTileEdgeSize) + Config.BigTileEdgeSize);
                Hy = (ushort)(from.Second * (2 * Config.BigTileEdgeSize) + Config.BigTileEdgeSize);
                Tx = (ushort)((map.Width - to.First - 1) * (2 * Config.BigTileEdgeSize) + Config.BigTileEdgeSize);
                Ty = (ushort)(to.Second * (2 * Config.BigTileEdgeSize) + Config.BigTileEdgeSize);
            }
            public bool Exec(ushort hx, ushort hy)
            {
                fomap.AddObject(new MapObject(MapObjectType.Scenery, Config.ScrollblockerPID, hx, hy));
                return false;
            }
        }

        /// <summary>
        /// Compile the map instance.
        /// </summary>
        /// <param name="fileName">Output file name</param>
        /// <param name="header">Map header to be included</param>
        public void Compile(string fileName, MapHeader header)
        {
            FOCommon.Utils.Log("Compiling " + fileName + " using preset '" + Config.CurrentPreset + "'.");
            Preset p = PresetsManager.GetPreset(Config.CurrentPreset);
            if (p == null)
            {
                FOCommon.Utils.Log("Error: preset '" + Config.CurrentPreset + "' not found.");
                throw new CompilerException("internal: preset '" + Config.CurrentPreset + "' not found");
            }

            FOMap m = new FOMap();
            m.Header = header;

            header.MaxHexX = (ushort)(2 * Config.BigTileEdgeSize * Width);
            header.MaxHexY = (ushort)(2 * Config.BigTileEdgeSize * Height);
            header.Version = 4;
            header.WorkHexX = (ushort)(header.MaxHexX / 2);
            header.WorkHexY = (ushort)(header.MaxHexY / 2);

            // tiles
            for(int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                    compileTile(m, p, x, y);

            // scrollblockers
            if (scrollBlockers.Count > 3)
            {
                for (int i = 2; i < scrollBlockers.Count; i++)
                {
                    Pair<int, int> from = scrollBlockers[i-1];
                    Pair<int, int> to = scrollBlockers[i];
                    LineTracer.TraceHex(new ScrollblockersPlacer(from, to, this, m));
                }
                LineTracer.TraceHex(new ScrollblockersPlacer(scrollBlockers[scrollBlockers.Count - 1], scrollBlockers[1], this, m));
            }

            FOMapParser parser = new FOMapParser(fileName);
            parser.Map = m;
            parser.Save();
            FOCommon.Utils.Log("Compilation successful.");
        }

        #region Helpers

        private void compileTile(FOMap m, Preset p, int tx, int ty)
        {
            Tile tile = tiles[tx, ty];

            if (!tile.Filled) compileEmpty(m, p, tx, ty);
            else if (tile.Wide) compileWide(m, p, tx, ty);
            else
            {
                bool compilen = false;
                for (int dir = Directions.North; dir <= Directions.West; dir++)
                {
                    if (tile.IsPath(dir) && tile.GetNeighbour(dir).Wide)
                    {
                        compileAdapter(m, p, tx, ty, dir);
                        compilen = true;
                        break;
                    }
                }
                if (!compilen) compileNormalCorridor(m, p, tx, ty);
            }
        }

        private void compileEmpty(FOMap m, Preset p, int tx, int ty)
        {
            Tile tile = tiles[tx, ty];
            BigTile bt = p.GetBigTile(0, tile.Variant);
            if(bt == null) throw new CompilerException(
                   String.Format("there is no empty tile with variant {0} to place on ({1},{2})", tile.Variant, tx, ty));
            placeBigTile(m, bt, tx, ty);
        }

        private void compileWide(FOMap m, Preset p, int tx, int ty)
        {
            Tile tile = tiles[tx, ty];
            int hash = GetTileHash(tile);
            int num = PresetsManager.GetWideNum(hash);
            if (num == -1) throw new CompilerException(
                     String.Format("there is no tile for hash W{0,8} to place on ({1},{2})", Utils.HashCode(hash), tx, ty));
            BigTile bt = p.GetBigTile(num, tile.Variant);
            if (bt == null)
            {
                throw new CompilerException(
                    String.Format("there is no tile W{0,8}/{1} to place on ({2},{3})", Utils.HashCode(hash), tile.Variant, tx, ty));
            }
            placeBigTile(m, bt, tx, ty);
        }

        private void compileAdapter(FOMap m, Preset p, int tx, int ty, int dir)
        {
            Tile tile = tiles[tx, ty];
            int num = PresetsManager.GetAdapterNum(dir);
            if (num == -1)
            {
                throw new CompilerException(
                    String.Format("there is no tile for adapter {0} to place on ({2},{3})",
                    Directions.ToChar(dir), tx, ty));
            }
            BigTile bt = p.GetBigTile(num, tile.Variant);
            if (bt == null)
            {
                throw new CompilerException(
                    String.Format("there is no adapter tile {0}/{1} to place on ({2},{3})",
                    Directions.ToChar(dir), tile.Variant, tx, ty));
            }
            placeBigTile(m, bt, tx, ty);
        }

        private void compileNormalCorridor(FOMap m, Preset p, int tx, int ty)
        {
            Tile tile = tiles[tx, ty];
            int hash = GetTileHash(tile);
            int num = PresetsManager.GetNum(hash);
            if(num == -1) throw new CompilerException(
                    String.Format("there is no tile for hash {0,8} to place on ({1},{2})", Utils.HashCode(hash), tx, ty));

            BigTile bt = p.GetBigTile(num, tile.Variant);
            if (bt == null) throw new CompilerException(
                    String.Format("there is no tile {0,8}/{1} to place on ({2},{3})", Utils.HashCode(hash), tile.Variant, tx, ty));
            placeBigTile(m, bt, tx, ty);
        }

        private void placeBigTile(FOMap m, BigTile bt, int tx, int ty)
        {
            ushort my = (ushort)ty;
            ushort mx = (ushort)(Width - tx - 1);
            m.Objects.AddRange(bt.GetClonedObjects(mx, my));
            m.Tiles.AddRange(bt.GetClonedTiles(mx, my));
        }

        #endregion
    }
}
