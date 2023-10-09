using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TiledMapper
{
    public partial class Map
    {
        /// <summary>
        /// Resize the map instance.
        /// </summary>
        /// <param name="n">Number or rows to be added to or removed from the north side</param>
        /// <param name="e">Number or columns to be added to or removed from the east side</param>
        /// <param name="s">Number or rows to be added to or removed from the south side</param>
        /// <param name="w">Number or columns to be added to or removed from the west side</param>
        public void Resize(int n, int e, int s, int w)
        {
            if (-n >= Height || -s >= Height || -e >= Width || -w >= Width) return;
            if (-(n + s) >= Height || -(e + w) >= Width) return;
            Tile[,] cutTiles;
            if (n < 0)
            {
                cutTiles = new Tile[Width, -n];
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < -n; y++)
                        cutTiles[x, y] = tiles[x, y];
            }
            else cutTiles = null;
            ChangeInternalResize ch = new ChangeInternalResize(Directions.North, n, cutTiles);
            apply(ch);

            if (e < 0)
            {
                cutTiles = new Tile[-e, Height];
                for (int x = Width + e; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        cutTiles[x - (Width + e), y] = tiles[x, y];
            }
            else cutTiles = null;
            ch = new ChangeInternalResize(Directions.East, e, cutTiles);
            apply(ch);

            if (s < 0)
            {
                cutTiles = new Tile[Width, -s];
                for (int x = 0; x < Width; x++)
                    for (int y = Height + s; y < Height; y++)
                        cutTiles[x, y - (Height + s)] = tiles[x, y];
            }
            else cutTiles = null;
            ch = new ChangeInternalResize(Directions.South, s, cutTiles);
            apply(ch);

            if (w < 0)
            {
                cutTiles = new Tile[-w, Height];
                for (int x = 0; x < -w; x++)
                    for (int y = 0; y < Height; y++)
                        cutTiles[x, y] = tiles[x, y];
            }
            else cutTiles = null;
            ch = new ChangeInternalResize(Directions.West, w, cutTiles);
            apply(ch);

            FullRedraw();
        }

        #region Resizing changes handling

        private void redoNorthResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width, Height + size];
            if (size > 0)
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y + size] = tiles[x, y];
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < size; y++)
                        newTiles[x, y] = new Tile();

                joinTiles(newTiles, Width, Height + size);
                for (int x = 0; x < Width; x++)
                    newTiles[x, size - 1].AttachToTile(newTiles[x, size], Directions.North);
            }
            else
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height + size; y++)
                        newTiles[x, y] = tiles[x, y - size];
                for (int x = 0; x < Width; x++)
                    newTiles[x, 0].DropTile(Directions.North);
            }
            tiles = newTiles;
            Height += size;
            fixScrollblockers(0, size);
        }

        private void redoEastResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width + size, Height];
            if (size > 0)
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x, y];
                for (int x = Width; x < Width + size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = new Tile();

                joinTiles(newTiles, Width + size, Height);
                for (int y = 0; y < Height; y++)
                    newTiles[Width - 1, y].AttachToTile(newTiles[Width, y], Directions.East);
            }
            else
            {
                for (int x = 0; x < Width + size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x, y];
                for (int y = 0; y < Height; y++)
                    newTiles[Width + size - 1, y].DropTile(Directions.East);
            }
            tiles = newTiles;
            Width += size;
            fixScrollblockers(0, 0);
        }

        private void redoSouthResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width, Height + size];
            if (size > 0)
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x, y];
                for (int x = 0; x < Width; x++)
                    for (int y = Height; y < Height + size; y++)
                        newTiles[x, y] = new Tile();

                joinTiles(newTiles, Width, Height + size);
                for (int x = 0; x < Width; x++)
                    newTiles[x, size].AttachToTile(newTiles[x, size - 1], Directions.South);
            }
            else
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height + size; y++)
                        newTiles[x, y] = tiles[x, y];
                for (int x = 0; x < Width; x++)
                    newTiles[x, Height + size - 1].DropTile(Directions.South);
            }
            tiles = newTiles;
            Height += size;
            fixScrollblockers(0, 0);
        }

        private void redoWestResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width + size, Height];
            if (size > 0)
            {
                
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x + size, y] = tiles[x, y];
                for (int x = 0; x < size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = new Tile();

                joinTiles(newTiles, Width + size, Height);
                for (int y = 0; y < Height; y++)
                    newTiles[size - 1, y].AttachToTile(newTiles[size, y], Directions.West);
            }
            else
            {
                for (int x = 0; x < Width + size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x - size, y];
                for (int y = 0; y < Height; y++)
                    newTiles[0, y].DropTile(Directions.West);
            }
            tiles = newTiles;
            Width += size;
            fixScrollblockers(size, 0);
        }

        private void fixScrollblockers(int offsX, int offsY)
        {
            for (int i = 1; i < scrollBlockers.Count; )
            {
                scrollBlockers[i].First += offsX;
                scrollBlockers[i].Second += offsY;
                if (scrollBlockers[i].First < 0 || scrollBlockers[i].Second < 0 ||
                    scrollBlockers[i].First >= Width || scrollBlockers[i].Second >= Height)
                {
                    scrollBlockers.RemoveAt(i);
                    continue;
                }
                tiles[scrollBlockers[i].First, scrollBlockers[i].Second].ScrollBlocker = i;
                i++;
            }
        }

        private void undoNorthResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width, Height - size];
            if (size > 0)
            {
                for (int x = 0; x < Width; x++)
                    for (int y = size; y < Height; y++)
                        newTiles[x, y - size] = tiles[x, y];
                for (int x = 0; x < Width; x++)
                    newTiles[x, 0].DropTile(Directions.North);
            }
            else
            {
                for (int x = 0; x < Width; x++)
                    for (int y = -size; y < Height - size; y++)
                        newTiles[x, y] = tiles[x, y + size];
                Tile[,] oldTiles = ch.Tiles;
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < -size; y++)
                        newTiles[x, y] = oldTiles[x, y];

                joinTiles(newTiles, Width, Height - size);
                for (int x = 0; x < Width; x++)
                    newTiles[x, -size - 1].AttachToTile(newTiles[x, -size], Directions.North);
            }
            tiles = newTiles;
            Height -= size;
            fixScrollblockers(0, -size);
            reattachScrollBlockers();
        }

        private void undoEastResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width - size, Height];
            if (size > 0)
            {
                for (int x = 0; x < Width - size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x, y];
                for (int y = 0; y < Height; y++)
                    newTiles[Width - size - 1, y].DropTile(Directions.East);
            }
            else
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x, y];
                Tile[,] oldTiles = ch.Tiles;
                for (int x = Width; x < Width - size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = oldTiles[x - Width, y];

                joinTiles(newTiles, Width - size, Height);
                for (int y = 0; y < Height; y++)
                    newTiles[Width, y].AttachToTile(newTiles[Width - 1, y], Directions.East);
            }
            tiles = newTiles;
            Width -= size;
            fixScrollblockers(0, 0);
            reattachScrollBlockers();
        }

        private void undoSouthResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width, Height - size];
            if (size > 0)
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height - size; y++)
                        newTiles[x, y] = tiles[x, y];
                for (int x = 0; x < Width; x++)
                    newTiles[x, Height - size - 1].DropTile(Directions.South);
            }
            else
            {
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x, y];
                Tile[,] oldTiles = ch.Tiles;
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < -size; y++)
                        newTiles[x, Height + y] = oldTiles[x, y];

                joinTiles(newTiles, Width, Height - size);
                for (int x = 0; x < Width; x++)
                    newTiles[x, Height].AttachToTile(newTiles[x, Height - 1], Directions.South);
            }
            tiles = newTiles;
            Height -= size;
            fixScrollblockers(0, 0);
            reattachScrollBlockers();
        }

        private void undoWestResize(ChangeInternalResize ch)
        {
            int size = ch.Size;
            Tile[,] newTiles = new Tile[Width - size, Height];
            if (size > 0)
            {
                for (int x = size; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x - size, y] = tiles[x, y];
                for (int y = 0; y < Height; y++)
                    newTiles[0, y].DropTile(Directions.West);
            }
            else
            {
                for (int x = -size; x < Width - size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = tiles[x + size, y];
                Tile[,] oldTiles = ch.Tiles;
                for (int x = 0; x < -size; x++)
                    for (int y = 0; y < Height; y++)
                        newTiles[x, y] = oldTiles[x, y];

                joinTiles(newTiles, Width - size, Height);
                for (int y = 0; y < Height; y++)
                    newTiles[-size - 1, y].AttachToTile(newTiles[-size, y], Directions.West);
            }
            tiles = newTiles;
            Width -= size;
            fixScrollblockers(-size, 0);
            reattachScrollBlockers();
        }

        private void reattachScrollBlockers()
        {
            // d shall hold scrollblockers that are not registered yet
            Dictionary<int, Pair<int, int>> d = new Dictionary<int, Pair<int, int>>();

            for(int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    int scrollBlocker = tiles[x, y].ScrollBlocker;
                    if (scrollBlocker != 0)
                    {
                        if (scrollBlocker >= scrollBlockers.Count ||
                            scrollBlockers[scrollBlocker].First != x ||
                            scrollBlockers[scrollBlocker].Second != y)
                        {
                            d.Add(scrollBlocker, new Pair<int, int>(x, y));
                        }
                    }
                }

            foreach (KeyValuePair<int, Pair<int, int>> kvp in d)
            {
                if (kvp.Key < scrollBlockers.Count) scrollBlockers.Insert(kvp.Key, kvp.Value);
                else scrollBlockers.Add(kvp.Value);
            }

            for (int i = 1; i < scrollBlockers.Count; i++)
            {
                Tile t = tiles[scrollBlockers[i].First, scrollBlockers[i].Second];
                t.ScrollBlocker = i;
            }
        }

        #endregion
    }
}