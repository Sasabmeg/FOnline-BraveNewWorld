using System;
using System.Collections.Generic;
using System.Text;

namespace TiledMapper
{
    /// <summary>
    /// The class that holds the definition of big tiles, taken from
    /// the preset file.
    /// </summary>
    public class Preset
    {
        Dictionary<Pair<int, int>, BigTile> bigTiles;
        Dictionary<int, int> bigTilesCount;

        public Preset()
        {
            bigTiles = new Dictionary<Pair<int, int>, BigTile>();
            bigTilesCount = new Dictionary<int, int>();
        }

        /// <summary>
        /// Sets the big tile.
        /// </summary>
        /// <param name="num">Index of the tile</param>
        /// <param name="variant">Variant of that index</param>
        /// <param name="bt">Big tile to be added</param>
        public void AddBigTile(int num, int variant, BigTile bt)
        {
            bigTiles.Add(new Pair<int, int>(num, variant), bt);
            if (bigTilesCount.ContainsKey(num)) bigTilesCount[num]++;
            else bigTilesCount.Add(num, 1);
        }

        /// <summary>
        /// Returns a big tile with a given index and variant, possibly creating
        /// one on spot.
        /// </summary>
        /// <param name="num">Index of the tile</param>
        /// <param name="variant">Variant of the given index</param>
        /// <param name="force">Optional parameter forcing the creation of big tile if one does not exist</param>
        /// <returns>The corresponding big tile, or null of one does not exist and was not forcibly created</returns>
        public BigTile GetBigTile(int num, int variant, bool force = false)
        {
            if (variant == 0)
            {
                if (!bigTilesCount.ContainsKey(num)) variant = 1;
                else variant = Utils.Random(1, bigTilesCount[num]);
            }

            Pair<int, int> pair = new Pair<int, int>(num, variant);
            if (!bigTiles.ContainsKey(pair))
            {
                if(!force) return null;
                AddBigTile(num, variant, new BigTile());
            }
            
            return bigTiles[pair];
        }
    }
}
