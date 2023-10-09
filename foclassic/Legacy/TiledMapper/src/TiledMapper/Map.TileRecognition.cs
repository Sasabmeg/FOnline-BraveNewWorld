using System;
using System.Collections.Generic;
using System.Text;

namespace TiledMapper
{
    public partial class Map
    {
        public int GetTileHash(Tile tile)
        {
            int hash = 0;
            hash += test2(tile, Directions.South, Directions.East, b(0));
            hash += test(tile, Directions.South, b(1));
            hash += test2(tile, Directions.South, Directions.West, b(2));
            hash += test(tile, Directions.East, b(3));
            hash += test(tile, Directions.West, b(4));
            hash += test2(tile, Directions.North, Directions.East, b(5));
            hash += test(tile, Directions.North, b(6));
            hash += test2(tile, Directions.North, Directions.West, b(7));
            
            return hash;
        }

        public int GetTileCorridorHash(Tile tile)
        {
            int tHash = GetTileHash(tile);
            int hash = 0;
            // vertical at corners
            hash += ctest2(tHash, b(6), b(7), b(0));
            hash += ctest2(tHash, b(6), b(5), b(1));
            hash += ctest2(tHash, b(1), b(2), b(2));
            hash += ctest2(tHash, b(1), b(0), b(3));

            // horizontal at corners
            hash += ctest2(tHash, b(4), b(7), b(4));
            hash += ctest2(tHash, b(3), b(5), b(5));
            hash += ctest2(tHash, b(4), b(2), b(6));
            hash += ctest2(tHash, b(3), b(0), b(7));

            // vertical
            hash += ctest(tHash, b(4), b(8));
            hash += ctest(tHash, b(3), b(9));
            hash += ctest(tHash, b(6), b(10));
            hash += ctest(tHash, b(1), b(11));

            return hash;
        }

        #region Helpers

        private int test(Tile tile, int dir, int value)
        {
            if (tile.IsPath(dir)) return 0;
            return value;
        }

        private int test2(Tile tile, int dir1, int dir2, int value)
        {
            if (!tile.IsPath(dir1) || !tile.IsPath(dir2)) return value;
            if (!tile.GetNeighbour(dir1).IsPath(dir2)) return value;
            if (!tile.GetNeighbour(dir2).IsPath(dir1)) return value;
            return 0;
        }

        private int b(int i)
        {
            return 1 << i;
        }

        private int ctest(int hash, int m, int value)
        {
            if ((hash & m) != 0) return value;
            return 0;
        }

        private int ctest2(int hash, int m, int n, int value)
        {
            if(((hash & m) == 0) && ((hash & n) != 0)) return value;
            return 0;
        }

        private bool bit(int hash, int f)
        {
            return (hash & b(f)) != 0;
        }

        #endregion
    }
}