using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TiledMapper
{
    public partial class Map
    {
        /// <summary>
        /// Redraw the map.
        /// </summary>
        /// <param name="g">Graphics object to redraw on</param>
        public void Redraw(Graphics g)
        {
            redrawGrid(g);
            redrawBlocks(g);
            redrawTiles(g);
        }

        /// <summary>
        /// Resize the drawing box associated with the map and invalidate the contents,
        /// forcing a full redraw.
        /// </summary>
        public void FullRedraw()
        {
            box.Size = new Size(Config.LineSize + bsize(Width), Config.LineSize + bsize(Height));
            box.Invalidate();
        }

        #region Drawing helpers

        private void redrawGrid(Graphics g)
        {
            g.Clear(Config.BackgroundColor);

            Pen pen = getLinePen();

            int x = Config.LineSize / 2;
            int y = Config.LineSize + bsize(Height);
            for (int i = 0; i <= Width; i++)
            {
                g.DrawLine(pen, x, 0, x, y);
                x += bsize(1);
            }

            x = Config.LineSize + bsize(Width);
            y = Config.LineSize / 2;
            for (int i = 0; i <= Height; i++)
            {
                g.DrawLine(pen, 0, y, x, y);
                y += bsize(1);
            }
            pen.Dispose();
        }

        private void redrawTiles(Graphics g)
        {
            SolidBrush brush = getTileBrush(true);
            SolidBrush emptyBrush = getTileBrush(false);
            Pen pen = null;
            SolidBrush variantFontBrush = null;
            if (post)
            {
                pen = getWallPen();
                variantFontBrush = getVariantFontBrush();
            }
            SolidBrush scrollblockerFontBrush = getScrollblockerFontBrush();

            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    if (tiles[x, y].Filled)
                        drawTile(x, y, g, brush, pen, variantFontBrush, scrollblockerFontBrush);
                    else
                        drawTile(x, y, g, emptyBrush, null, variantFontBrush, scrollblockerFontBrush);

            brush.Dispose();
            emptyBrush.Dispose();
            if (pen != null) pen.Dispose();
            if (variantFontBrush != null) variantFontBrush.Dispose();
            scrollblockerFontBrush.Dispose();
        }

        private void redrawBlocks(Graphics g)
        {
            Pen pen = getBlockPen();
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                {
                    if (tiles[x, y].GetBlock(Directions.East))
                        drawBlock(x, y, Directions.East, g, pen);
                    if (tiles[x, y].GetBlock(Directions.South))
                        drawBlock(x, y, Directions.South, g, pen);
                    if (x == 0 && tiles[x, y].GetBlock(Directions.West))
                        drawBlock(x, y, Directions.West, g, pen);
                    if (y == 0 && tiles[x, y].GetBlock(Directions.North))
                        drawBlock(x, y, Directions.North, g, pen);
                }
            pen.Dispose();
        }

        private void updateTile(int tx, int ty)
        {
            Graphics g = box.CreateGraphics();
            Tile tile = tiles[tx, ty];

            SolidBrush brush = getTileBrush(tile.Filled);
            Pen pen = post && tile.Filled ? getWallPen() : null;
            SolidBrush variantFontBrush = getVariantFontBrush();
            SolidBrush scrollblockerFontBrush = getScrollblockerFontBrush();
            drawTile(tx, ty, g, brush, pen, variantFontBrush, scrollblockerFontBrush);
            brush.Dispose();
            if (pen != null) pen.Dispose();
            if (variantFontBrush != null) variantFontBrush.Dispose();
            scrollblockerFontBrush.Dispose();
        }

        private void drawTile(int tx, int ty, Graphics g, Brush brush, Pen pen, Brush variantFontBrush, Brush scrollblockerFontBrush)
        {
            g.FillRectangle(brush, Config.LineSize + bsize(tx),
                Config.LineSize + bsize(ty), Config.GridSize, Config.GridSize);

            Tile tile = tiles[tx, ty];

            if (pen != null && tile.Filled)
            {
                if (tile.Wide)
                {
                    // cross-section?
                    if (tile.IsPath(Directions.North) && tile.IsPath(Directions.East))
                        drawWideCross(tx, ty, g, pen);
                    // east-west?
                    else if (!tile.IsPath(Directions.North))
                        drawWideEW(tx, ty, g, pen);
                    // north-south then
                    else drawWideNS(tx, ty, g, pen);
                }
                else
                {
                    bool drawn = false;
                    for (int dir = Directions.North; dir <= Directions.West; dir++)
                    {
                        if (tile.IsPath(dir) && tile.GetNeighbour(dir).Wide)
                        {
                            drawAdapter(tx, ty, dir, g, pen);
                            drawn = true;
                            break;
                        }
                    }
                    if (!drawn) drawNormalCorridor(tx, ty, g, pen);
                }
            }

            // display scrollblocker
            if (tile.ScrollBlocker != 0)
                g.DrawString(tile.ScrollBlocker.ToString(), getFont(), scrollblockerFontBrush,
                    Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding + getFont().Size + 1);

            // display variant
            if (variantFontBrush != null && tile.Variant > 0)
                g.DrawString(tile.Variant.ToString(), getFont(), variantFontBrush,
                    Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding);
        }

        private void drawWideCross(int tx, int ty, Graphics g, Pen pen)
        {
            // vertical
            g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WidePadding, Config.LineSize + bsize(ty),
                            Config.LineSize + bsize(tx) + Config.WidePadding, Config.LineSize + bsize(ty) + Config.WidePadding);

            g.DrawLine(pen, bsize(tx + 1) - Config.WidePadding, Config.LineSize + bsize(ty),
                            bsize(tx + 1) - Config.WidePadding, Config.LineSize + bsize(ty) + Config.WidePadding);

            g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WidePadding, bsize(ty + 1) - Config.WidePadding,
                            Config.LineSize + bsize(tx) + Config.WidePadding, bsize(ty + 1) + Config.LineSize);

            g.DrawLine(pen, bsize(tx + 1) - Config.WidePadding, bsize(ty + 1) - Config.WidePadding,
                            bsize(tx + 1) - Config.WidePadding, bsize(ty + 1) + Config.LineSize);

            // horizontal
            g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize + bsize(ty) + Config.WidePadding,
                            Config.LineSize + bsize(tx) + Config.WidePadding, Config.LineSize + bsize(ty) + Config.WidePadding);

            g.DrawLine(pen, Config.LineSize + bsize(tx), bsize(ty + 1) - Config.WidePadding,
                             Config.LineSize + bsize(tx) + Config.WidePadding, bsize(ty + 1) - Config.WidePadding);

            g.DrawLine(pen, bsize(tx + 1) - Config.WidePadding, Config.LineSize + bsize(ty) + Config.WidePadding,
                            bsize(tx + 1) + Config.LineSize, Config.LineSize + bsize(ty) + Config.WidePadding);

            g.DrawLine(pen, bsize(tx + 1) - Config.WidePadding, bsize(ty + 1) - Config.WidePadding,
                            bsize(tx + 1) + Config.LineSize, bsize(ty + 1) - Config.WidePadding);
        }

        private void drawWideEW(int tx, int ty, Graphics g, Pen pen)
        {
            g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize + bsize(ty) + Config.WidePadding,
                            Config.LineSize + bsize(tx + 1), Config.LineSize + bsize(ty) + Config.WidePadding);

            g.DrawLine(pen, Config.LineSize + bsize(tx), bsize(ty + 1) - 3,
                            Config.LineSize + bsize(tx + 1), bsize(ty + 1) - 3);
        }

        private void drawWideNS(int tx, int ty, Graphics g, Pen pen)
        {
            g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WidePadding, Config.LineSize + bsize(ty),
                            Config.LineSize + bsize(tx) + Config.WidePadding, Config.LineSize + bsize(ty + 1));

            g.DrawLine(pen, bsize(tx + 1) - 3, Config.LineSize + bsize(ty),
                            bsize(tx + 1) - 3, Config.LineSize + bsize(ty + 1));
        }

        private void drawAdapter(int tx, int ty, int dir, Graphics g, Pen pen)
        {
            switch (dir)
            {
                case Directions.North:
                    {
                        g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WidePadding, Config.LineSize + bsize(ty),
                                        Config.LineSize + bsize(tx) + Config.WallPadding, bsize(ty + 1) + Config.LineSize);
                        g.DrawLine(pen, bsize(tx + 1) - Config.WidePadding, Config.LineSize + bsize(ty),
                                        bsize(tx + 1) - Config.WallPadding, bsize(ty + 1) + Config.LineSize);
                        break;
                    }
                case Directions.East:
                    {
                        g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize + bsize(ty) + Config.WallPadding,
                                        bsize(tx + 1) + Config.LineSize, Config.LineSize + bsize(ty) + Config.WidePadding);
                        g.DrawLine(pen, Config.LineSize + bsize(tx), bsize(ty + 1) - Config.WallPadding,
                                        bsize(tx + 1) + Config.LineSize, bsize(ty + 1) - Config.WidePadding);
                        break;
                    }
                case Directions.South:
                    {
                        g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty),
                                        Config.LineSize + bsize(tx) + Config.WidePadding, bsize(ty + 1) + Config.LineSize);
                        g.DrawLine(pen, bsize(tx + 1) - Config.WallPadding, Config.LineSize + bsize(ty),
                                        bsize(tx + 1) - Config.WidePadding, bsize(ty + 1) + Config.LineSize);
                        break;
                    }
                case Directions.West:
                    {
                        g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize + bsize(ty) + Config.WidePadding,
                                        bsize(tx + 1) + Config.LineSize, Config.LineSize + bsize(ty) + Config.WallPadding);
                        g.DrawLine(pen, Config.LineSize + bsize(tx), bsize(ty + 1) - Config.WidePadding,
                                        bsize(tx + 1) + Config.LineSize, bsize(ty + 1) - Config.WallPadding);
                        break;
                    }
            }
        }

        private void drawNormalCorridor(int tx, int ty, Graphics g, Pen pen)
        {
            Tile tile = tiles[tx, ty];
            int hash = GetTileCorridorHash(tile);

            // vertical in corner
            if (bit(hash,0))
                g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty),
                                Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding);

            if (bit(hash, 1))
                g.DrawLine(pen, bsize(tx + 1) - Config.WallPadding, Config.LineSize + bsize(ty),
                                bsize(tx + 1) - Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding);

            if (bit(hash, 2))
                g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WallPadding, bsize(ty + 1) - Config.WallPadding,
                                Config.LineSize + bsize(tx) + Config.WallPadding, bsize(ty + 1) + Config.LineSize);

            if (bit(hash, 3))
                g.DrawLine(pen, bsize(tx + 1) - Config.WallPadding, bsize(ty + 1) - Config.WallPadding,
                                bsize(tx + 1) - Config.WallPadding, bsize(ty + 1) + Config.LineSize);

            // horizontal in corner
            if (bit(hash, 4))
                g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize + bsize(ty) + Config.WallPadding,
                                Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding);
            
            if (bit(hash, 5))
                g.DrawLine(pen, bsize(tx + 1) - Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding,
                                bsize(tx + 1) + Config.LineSize, Config.LineSize + bsize(ty) + Config.WallPadding);
             
            if (bit(hash, 6))
                g.DrawLine(pen, Config.LineSize + bsize(tx), bsize(ty + 1) - Config.WallPadding,
                                Config.LineSize + bsize(tx) + Config.WallPadding, bsize(ty + 1) - Config.WallPadding);

            if (bit(hash, 7))
                g.DrawLine(pen, bsize(tx + 1) - Config.WallPadding, bsize(ty + 1) - Config.WallPadding,
                                bsize(tx + 1) + Config.LineSize, bsize(ty + 1) - Config.WallPadding);

            // square in the middle
            if (bit(hash, 8))
                g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding,
                                Config.LineSize + bsize(tx) + Config.WallPadding, bsize(ty + 1) - Config.WallPadding);

            if (bit(hash, 9))
                g.DrawLine(pen, bsize(tx + 1) - Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding,
                                bsize(tx + 1) - Config.WallPadding, bsize(ty + 1) - Config.WallPadding);

            if (bit(hash, 10))
                g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding,
                                bsize(tx + 1) - Config.WallPadding, Config.LineSize + bsize(ty) + Config.WallPadding);

            if (bit(hash, 11))
                g.DrawLine(pen, Config.LineSize + bsize(tx) + Config.WallPadding, bsize(ty + 1) - Config.WallPadding,
                                bsize(tx + 1) - Config.WallPadding, bsize(ty + 1) - Config.WallPadding);
        }

        private void updateBlock(int tx, int ty, int dir)
        {
            Graphics g = box.CreateGraphics();
            Pen pen = tiles[tx, ty].GetBlock(dir) ? getBlockPen() : getLinePen();
            drawBlock(tx, ty, dir, g, pen);
            pen.Dispose();
        }

        private void drawBlock(int tx, int ty, int dir, Graphics g, Pen pen)
        {
            switch (dir)
            {
                case Directions.North:
                    {
                        g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize / 2 + bsize(ty),
                            bsize(tx + 1), Config.LineSize / 2 + bsize(ty));
                        break;
                    }
                case Directions.South:
                    {
                        g.DrawLine(pen, Config.LineSize + bsize(tx), Config.LineSize / 2 + bsize(ty + 1),
                            bsize(tx + 1), Config.LineSize / 2 + bsize(ty + 1));
                        break;
                    }
                case Directions.West:
                    {
                        g.DrawLine(pen, Config.LineSize / 2 + bsize(tx), Config.LineSize + bsize(ty),
                            Config.LineSize / 2 + bsize(tx), bsize(ty + 1));
                        break;
                    }
                case Directions.East:
                    {
                        g.DrawLine(pen, Config.LineSize / 2 + bsize(tx + 1), Config.LineSize + bsize(ty),
                            Config.LineSize / 2 + bsize(tx + 1), bsize(ty + 1));
                        break;
                    }
            }
        }

        #endregion

        #region Config information retrieval

        private Pen getLinePen()
        {
            return new Pen(Config.LineColor, Config.LineSize);
        }

        private Pen getWallPen()
        {
            return new Pen(Config.WallColor, Config.WallSize);
        }

        private Pen getBlockPen()
        {
            return new Pen(Config.BlockColor, Config.LineSize);
        }

        private SolidBrush getTileBrush(bool filled)
        {
            Color color = Config.TileColor;
            if (!filled) color = Config.BackgroundColor;
            return new SolidBrush(color);
        }

        private SolidBrush getVariantFontBrush()
        {
            return new SolidBrush(Config.VariantTextColor);
        }

        private SolidBrush getScrollblockerFontBrush()
        {
            return new SolidBrush(Config.ScrollblockerTextColor);
        }

        private Font getFont()
        {
            return Config.Font;
        }

        #endregion
    }
}