using System;
using System.Collections.Generic;
using System.Text;

namespace TiledMapper
{
    /// <summary>
    /// Tiled Mapper's tile, a single element of the tiled map.
    /// </summary>
    public class Tile
    {
        public bool Filled { get; set; }
        public int Variant { get; set; }
        public int ScrollBlocker { get; set; }
        public bool Wide { get; set; }
        private bool[] blocks;
        private Tile[] neighbours;

        public Tile()
        {
            Filled = false;
            Variant = 0;
            Wide = false;
            blocks = new bool[4];
            for (int i = 0; i < 4; i++) blocks[i] = false;
            neighbours = new Tile[4];
            for (int i = 0; i < 4; i++) neighbours[i] = null;
            ScrollBlocker = 0;
        }

        public Tile(int variant, bool wide)
        {
            Variant = variant;
            Wide = wide;
            blocks = new bool[4];
            for (int i = 0; i < 4; i++) blocks[i] = false;
            neighbours = new Tile[4];
            for (int i = 0; i < 4; i++) neighbours[i] = null;
            ScrollBlocker = 0;
        }

        public Tile GetNeighbour(int dir)
        {
            return neighbours[dir];
        }

        public bool GetBlock(int dir)
        {
            return blocks[dir];
        }

        public bool IsPath(int dir)
        {
            return neighbours[dir] != null && neighbours[dir].Filled && !GetBlock(dir);
        }

        public void SetBlock(int dir, bool val)
        {
            setBlock(dir, val);
            if (neighbours[(int)dir] != null)
                neighbours[(int)dir].setBlock(((int)dir + 2) % 4, val);
        }

        public void ToggleBlock(int dir)
        {
            SetBlock(dir, !GetBlock(dir));
        }

        public Tile AttachToTile(Tile tile, int fromDir)
        {
            tile.attachTile(this, fromDir);
            neighbours[(fromDir + 2) % 4] = tile;
            blocks[(fromDir + 2) % 4] = tile.GetBlock(fromDir);
            return this;
        }

        public Tile DropTile(int dir)
        {
            this.neighbours[dir] = null;
            return this;
        }

        protected void attachTile(Tile tile, int fromDir)
        {
            neighbours[fromDir] = tile;
        }

        protected void setBlock(int dir, bool val)
        {
            blocks[dir] = val;
        }
    }
}
