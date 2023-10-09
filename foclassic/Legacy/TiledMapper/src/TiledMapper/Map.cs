using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TiledMapper
{
    /// <summary>
    /// The main class holding the map and handling editing
    /// </summary>
    public partial class Map
    {
        public MapType Type { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        private Tile[,] tiles;
        private bool post;

        private int lastToggle;

        private List<BaseChange> changes;
        private int changesIndex;

        private System.Windows.Forms.PictureBox box;
        private ValueSetterDelegate setUndo;
        private ValueSetterDelegate setRedo;
        private ValueSetterDelegate setPostMode;

        private List<Pair<int, int>> scrollBlockers;

        private Map(int width, int height, System.Windows.Forms.PictureBox dbox, ValueSetterDelegate undo, ValueSetterDelegate redo, ValueSetterDelegate postMode)
        {
            box = dbox;
            setUndo = undo;
            setRedo = redo;
            setPostMode = postMode;

            Width = width;
            Height = height;

            scrollBlockers = new List<Pair<int, int>>();
            scrollBlockers.Add(new Pair<int, int>(-1, -1));

            changes = new List<BaseChange>();
            changes.Add(new ChangeDummy());
            changesIndex = 0;
            post = false;
            lastToggle = -1;

            tiles = makeTiles(width, height);
        }

        /// <summary>
        /// Handler for the mouse clicking and painting a tile or wall.
        /// </summary>
        public bool Click(int x, int y, TileMode mode)
        {
            if (x < 0 || y < 0 || x >= box.Width || y >= box.Height) return false;

            switch (mode)
            {
                case TileMode.Tiles: return clickTiles(x, y);
                case TileMode.Blocks: return clickBlocks(x, y);
                default: break;
            }
            return false;
        }

        /// <summary>
        /// Handler for a single click on a tile.
        /// </summary>
        public void OneClick(int x, int y, TileMode mode, bool left)
        {
            if (x < 0 || y < 0 || x >= box.Width || y >= box.Height) return;

            switch (mode)
            {
                case TileMode.Variants:
                    clickTileVariant(x, y, left);
                    break;
                case TileMode.Scrolls:
                    clickScrollPlace(x, y);
                    break;
                case TileMode.Width:
                    clickToggleWidth(x, y);
                    break;
                default: break;
            }
        }

        /// <summary>
        /// Handler for the stopping of painting with the mouse.
        /// </summary>
        public void StopClick()
        {
            lastToggle = -1;
        }

        /// <summary>
        /// Translation of mouse coordinates.
        /// </summary>
        /// <param name="h">A single mouse coordinate on the map.</param>
        /// <returns>The corresponding tile coordinate</returns>
        public static int MouseToTile(int h)
        {
            h -= Config.LineSize;
            return h / bsize(1);
        }

        /// <summary>
        /// Handler for mode changing.
        /// </summary>
        public void ClickConvert()
        {
            ChangeConvert change = new ChangeConvert(!post);
            apply(change);
        }

        /// <summary>
        /// Handler for action redoing.
        /// </summary>
        public void Redo()
        {
            redo(false);
        }

        /// <summary>
        /// Handler for action undoing.
        /// </summary>
        public void Undo()
        {
            bool quit = true;
            do
            {
                BaseChange change = changes[changesIndex];
                switch (change.Type)
                {
                    case ChangeType.SetVariant:
                        {
                            ChangeSetVariant ch = change as ChangeSetVariant;
                            tiles[ch.X, ch.Y].Variant = ch.From;
                            updateTile(ch.X, ch.Y);
                            break;
                        }
                    case ChangeType.ToggleTile:
                        {
                            ChangeToggleTile ch = change as ChangeToggleTile;
                            tiles[ch.X, ch.Y].Variant = ch.PreviousVariant;
                            tiles[ch.X, ch.Y].Filled = !tiles[ch.X, ch.Y].Filled;
                            updateTile(ch.X, ch.Y);
                            break;
                        }
                    case ChangeType.ToggleBlock:
                        {
                            ChangeToggleBlock ch = change as ChangeToggleBlock;
                            tiles[ch.X, ch.Y].ToggleBlock(ch.Dir);
                            updateBlock(ch.X, ch.Y, ch.Dir);
                            break;
                        }
                    case ChangeType.InternalResize:
                        {
                            ChangeInternalResize ch = change as ChangeInternalResize;
                            int size = ch.Size;

                            if (size != 0)
                            {
                                switch (ch.Dir)
                                {
                                    case Directions.North:
                                        undoNorthResize(ch);
                                        break;
                                    case Directions.East:
                                        undoEastResize(ch);
                                        break;
                                    case Directions.South:
                                        undoSouthResize(ch);
                                        break;
                                    case Directions.West:
                                        undoWestResize(ch);
                                        break;
                                    default: break;
                                }
                            }

                            if (change.StopUndo)
                            {
                                FullRedraw();
                                quit = true;
                            }
                            else quit = false;
                            break;
                        }
                    case ChangeType.ToggleWide:
                        {
                            ChangeToggleWide ch = change as ChangeToggleWide;
                            int tx = ch.X;
                            int ty = ch.Y;
                            tiles[tx, ty].Wide = ch.From;
                            FullRedraw();
                            break;
                        }
                    case ChangeType.Convert:
                        {
                            ChangeConvert ch = change as ChangeConvert;
                            post = !ch.Forward;
                            setPostMode(post);
                            FullRedraw();
                            break;
                        }
                    case ChangeType.SetScrollblockers:
                        {
                            ChangeSetScrollBlockers ch = change as ChangeSetScrollBlockers;
                            int idx = ch.Index;
                            Tile tile = tiles[ch.X, ch.Y];
                            if (idx == 0) // was new
                            {
                                tile.ScrollBlocker = 0;
                                scrollBlockers.RemoveAt(scrollBlockers.Count - 1);
                                updateTile(ch.X, ch.Y);
                                break;
                            }

                            // was deleted at idx position
                            tile.ScrollBlocker = idx;
                            scrollBlockers.Insert(idx, new Pair<int, int>(ch.X, ch.Y));
                            for (int i = idx + 1; i < scrollBlockers.Count; i++)
                            {
                                int nx = scrollBlockers[i].First;
                                int ny = scrollBlockers[i].Second;
                                tiles[nx, ny].ScrollBlocker++;
                                updateTile(nx, ny);
                            }
                            updateTile(ch.X, ch.Y);
                            break;
                        }
                    default: break;
                }
                changesIndex--;
            } while (!quit);

            if (changesIndex == 0) setUndo(false);
            setRedo(true);
        }

        #region Changes queue

        private void clearChanges()
        {
            if (changes.Count > 1)
                changes.RemoveRange(1, changes.Count - 1);
            changesIndex = 0;
            setRedo(false);
            setUndo(false);
        }

        private void truncateChanges()
        {
            if (changesIndex + 1 < changes.Count)
                changes.RemoveRange(changesIndex + 1, changes.Count - changesIndex - 1);
            setRedo(false);
        }

        private void apply(BaseChange change)
        {
            truncateChanges();
            changes.Add(change);
            redo(true);
        }

        private void redo(bool step)
        {
            bool quit = true;
            do
            {
                changesIndex++;
                BaseChange change = changes[changesIndex];
                switch (change.Type)
                {
                    case ChangeType.SetVariant:
                        {
                            ChangeSetVariant ch = change as ChangeSetVariant;
                            tiles[ch.X, ch.Y].Variant = ch.To;
                            updateTile(ch.X, ch.Y);
                            break;
                        }
                    case ChangeType.ToggleTile:
                        {
                            ChangeToggleTile ch = change as ChangeToggleTile;
                            tiles[ch.X, ch.Y].Variant = 0;
                            tiles[ch.X, ch.Y].Filled = !tiles[ch.X, ch.Y].Filled;
                            updateTile(ch.X, ch.Y);
                            break;
                        }
                    case ChangeType.ToggleBlock:
                        {
                            ChangeToggleBlock ch = change as ChangeToggleBlock;
                            tiles[ch.X, ch.Y].ToggleBlock(ch.Dir);
                            updateBlock(ch.X, ch.Y, ch.Dir);
                            break;
                        }
                    case ChangeType.InternalResize:
                        {
                            ChangeInternalResize ch = change as ChangeInternalResize;
                            int size = ch.Size;

                            if (size != 0)
                            {
                                switch (ch.Dir)
                                {
                                    case Directions.North:
                                        redoNorthResize(ch);
                                        break;
                                    case Directions.East:
                                        redoEastResize(ch);
                                        break;
                                    case Directions.South:
                                        redoSouthResize(ch);
                                        break;
                                    case Directions.West:
                                        redoWestResize(ch);
                                        break;
                                    default: break;
                                }
                            }

                            if (step) break;
                            if (change.StopRedo)
                            {
                                quit = true;
                                FullRedraw();
                            }
                            else quit = false;
                            break;
                        }
                    case ChangeType.Convert:
                        {
                            ChangeConvert ch = change as ChangeConvert;
                            post = ch.Forward;
                            setPostMode(post);
                            FullRedraw();
                            break;
                        }
                    case ChangeType.ToggleWide:
                        {
                            ChangeToggleWide ch = change as ChangeToggleWide;
                            int tx = ch.X;
                            int ty = ch.Y;
                            tiles[tx, ty].Wide = ch.To;
                            FullRedraw();
                            break;
                        }
                    case ChangeType.SetScrollblockers:
                        {
                            ChangeSetScrollBlockers ch = change as ChangeSetScrollBlockers;
                            Tile tile = tiles[ch.X, ch.Y];
                            int idx = ch.Index;
                            if (idx == 0)
                            {
                                tile.ScrollBlocker = scrollBlockers.Count;
                                scrollBlockers.Add(new Pair<int, int>(ch.X, ch.Y));
                                updateTile(ch.X, ch.Y);
                                break;
                            }

                            for (int i = idx + 1; i < scrollBlockers.Count; i++)
                            {
                                int nx = scrollBlockers[i].First;
                                int ny = scrollBlockers[i].Second;
                                tiles[nx, ny].ScrollBlocker--;
                                updateTile(nx, ny);
                            }
                            tile.ScrollBlocker = 0;
                            updateTile(ch.X, ch.Y);
                            scrollBlockers.RemoveAt(idx);
                            break;
                        }
                    default: break;
                }
            } while (!quit);

            if (changesIndex + 1 == changes.Count) setRedo(false);
            setUndo(true);
        }

        #endregion

        #region Clicking and painting

        private void clickTileVariant(int x, int y, bool left)
        {
            int tx = MouseToTile(x);
            int ty = MouseToTile(y);
            Tile tile = tiles[tx, ty];

            if (left)
            {
                int variant = tile.Variant + 1;
                ChangeSetVariant change = new ChangeSetVariant(tx, ty, tile.Variant, variant);
                apply(change);
            }
            else
            {
                if (tile.Variant == 0) return;
                int variant = tile.Variant - 1;
                ChangeSetVariant change = new ChangeSetVariant(tx, ty, tile.Variant, variant);
                apply(change);
            }
        }

        private void clickScrollPlace(int x, int y)
        {
            int tx = MouseToTile(x);
            int ty = MouseToTile(y);

            Tile tile = tiles[tx, ty];
            int idx = tile.ScrollBlocker;

            ChangeSetScrollBlockers change = new ChangeSetScrollBlockers(tx, ty, idx);
            apply(change);
        }

        private void clickToggleWidth(int x, int y)
        {
            int tx = MouseToTile(x);
            int ty = MouseToTile(y);

            Tile tile = tiles[tx, ty];

            ChangeToggleWide change = new ChangeToggleWide(tx, ty, tile.Wide, !tile.Wide);
            apply(change);
        }

        private bool clickTiles(int x, int y)
        {
            int tx = MouseToTile(x);
            int ty = MouseToTile(y);
            Tile tile = tiles[tx, ty];
            if (lastToggle == -1)
            {
                if (!tile.Filled) lastToggle = 1;
                else lastToggle = 0;
            }
            if (lastToggle == 1 && !tile.Filled || lastToggle == 0 && tile.Filled)
            {
                ChangeToggleTile change = new ChangeToggleTile(tx, ty, tile.Variant);
                apply(change);
            }

            return true;
        }

        private bool clickBlocks(int x, int y)
        {
            if (!((x % bsize(1) >= Config.LineSize) ^ (y % bsize(1) >= Config.LineSize)))
                return true;

            int dir = 0;
            Tile tile = null;
            int tx = 0;
            int ty = 0;
            if ((x % bsize(1) < Config.LineSize))
            {
                tx = x / bsize(1);
                ty = y / bsize(1);
                dir = Directions.West;
                if (tx == Width)
                {
                    dir = Directions.East;
                    tx--;
                }
                if (ty == Height) ty--;
            }
            else
            {
                tx = x / bsize(1);
                ty = y / bsize(1);
                dir = Directions.North;
                if (ty == Height)
                {
                    dir = Directions.South;
                    ty--;
                }
            }
            tile = tiles[tx, ty];
            if (lastToggle == -1)
            {
                if (tile.GetBlock(dir)) lastToggle = 0;
                else lastToggle = 1;
            }
            if (lastToggle == 1 && !tile.GetBlock(dir) || lastToggle == 0 && tile.GetBlock(dir))
            {
                ChangeToggleBlock change = new ChangeToggleBlock(tx, ty, dir);
                apply(change);
            }

            return true;
        }

        #endregion

        #region Helpers

        private static int bsize(int h)
        {
            return h * (Config.LineSize + Config.GridSize);
        }

        private static Tile[,] makeTiles(int width, int height)
        {
            Tile[,] tiles = new Tile[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    tiles[x, y] = new Tile(0, false);
                    if (x > 0) tiles[x, y].AttachToTile(tiles[x - 1, y], Directions.East);
                    if (y > 0) tiles[x, y].AttachToTile(tiles[x, y - 1], Directions.South);
                }
            return tiles;
        }

        private static void joinTiles(Tile[,] tiles, int width, int height)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    if (x > 0) tiles[x, y].AttachToTile(tiles[x - 1, y], Directions.East);
                    if (y > 0) tiles[x, y].AttachToTile(tiles[x, y - 1], Directions.South);
                }
        }

        #endregion
    }
}
