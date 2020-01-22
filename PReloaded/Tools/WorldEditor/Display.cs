
namespace WorldEditor
{
    public static class Display
    {
        public static float ZoneSize;
        public static int WorldmapScale;

        public static void ZoomIn(float modifier)
        {
            ZoneSize      = (ZoneSize * modifier);
            WorldmapScale = (int)(WorldmapScale * modifier);
        }

        public static void ZoomOut(float modifier)
        {
            ZoneSize = (ZoneSize / modifier);
            WorldmapScale = (int)(WorldmapScale / modifier);
        }

        public static int PixelToZoneCoord(int pixel)
        {
            return (pixel / (int)ZoneSize);
        }

        public static int ZoneCoordToPixel(int coord)
        {
            return (coord * (int)ZoneSize);
        }

        public static int PixelToGameCoords(int pixel)
        {
            return (pixel * (50 / (int)ZoneSize));
        }

        public static int GameCoordsToPixel(int coords)
        {
            return (((int)ZoneSize) * coords / 50);
        }
    }
}
