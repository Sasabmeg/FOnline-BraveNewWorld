using System.Drawing;
using System.Drawing.Drawing2D;

using FOCommon.WMLocation;

namespace WorldEditor
{
    public static class Drawing
    {
        public static Color SelectedColor, ModifiedColor, ImplementedColor, FilteredColor, BrushedColor = new Color();

        private static Pen pen = new Pen(Brushes.Black);
        private static Graphics surface;

        public static void SetSurface(Graphics g)
        {
            surface = g;
        }

        public static void DrawZone(Graphics g, Color color, int x, int y)
        {
            if (pen.Color != color)
                pen = new Pen(color, 2.0f);

            g.DrawRectangle(pen, new Rectangle(Display.ZoneCoordToPixel(x), Display.ZoneCoordToPixel(y), (int)Display.ZoneSize, (int)Display.ZoneSize));
        }

        public static void DrawLocation(Graphics g, Color color, Location loc, int x, int y)
        {
            loc.X = x;
            loc.Y = y;
            DrawLocation(surface, color, loc);
        }

        static GraphicsPath GetStringPath(string s, float dpi, Point p, Font font, StringFormat format)
        {
            GraphicsPath path = new GraphicsPath();
            // Convert font size into appropriate coordinates
            float emSize = dpi * font.SizeInPoints / 72;
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, p, format);

            return path;
        }

        public static void DrawOutlinedText(Graphics g, string Text, Font tfont,  Brush Fill, PointF p, Brush Outline)
        {
            
            g.DrawString(Text, tfont, Outline, p.X-1, p.Y-1);
            g.DrawString(Text, tfont, Outline, p.X - 1, p.Y + 1);
            g.DrawString(Text, tfont, Outline, p.X + 1, p.Y - 1);
            g.DrawString(Text, tfont, Outline, p.X + 1, p.Y + 1);
            g.DrawString(Text, tfont, Fill, p.X, p.Y);
        }

        public static void DrawLocation(Graphics g, Color color, Location loc)
        {
            pen = new Pen(color, 1.5f);

            float offset;
            offset = (loc.Size/2)+0.08f;

            Color cl = new Color();
            cl = Color.FromArgb(125, color);
            SolidBrush brush = new SolidBrush(cl);
            g.FillEllipse(brush, (Display.GameCoordsToPixel(loc.X)) - offset, Display.GameCoordsToPixel(loc.Y) - offset, loc.Size, loc.Size);
            g.DrawEllipse(pen, Display.GameCoordsToPixel(loc.X) - offset, Display.GameCoordsToPixel(loc.Y) - offset, loc.Size, loc.Size);

            if (Config.ShowLocationNames)
            {
                brush = new SolidBrush(Color.WhiteSmoke);
                Font font = new Font(FontFamily.GenericSansSerif, 7.0f);
                DrawOutlinedText(g, loc.WorldMapName, font, brush, new PointF(Display.GameCoordsToPixel(loc.X) - (loc.Size / 2), Display.GameCoordsToPixel(loc.Y) + (loc.Size / 2)), Brushes.Black);
            }
        }

        public static void DrawZoneDisplay(Graphics g, Color color, int x, int y, string Text, Font Font)
        {
            SolidBrush brush = new SolidBrush(color);
            g.DrawString(Text, Font, brush, Display.ZoneCoordToPixel(x) + 3, Display.ZoneCoordToPixel(y) + 3, StringFormat.GenericDefault);
        }

    }
}
