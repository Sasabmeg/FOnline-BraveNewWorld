namespace TiledMapper
{
    public enum MapType
    {
        Tiled = 0,
        Converted = 1
    }

    public enum TileMode
    {
        Tiles    = 0,
        Blocks   = 1,
        Scrolls  = 2,
        Variants = 3,
        Width    = 4
    }

    public enum ChangeType
    {
        InternalResize    = 0,
        ToggleTile        = 1,
        ToggleBlock       = 2,
        ToggleWide        = 3,
        SetScrollblockers = 4,
        Convert           = 5,
        Dummy             = 6,
        SetVariant        = 7
    }

    public static class Directions
    {
        public const int North = 0;
        public const int East = 1;
        public const int South = 2;
        public const int West = 3;

        public static char ToChar(int value)
        {
            switch (value)
            {
                case North: return 'n';
                case East: return 'e';
                case South: return 's';
                case West: return 'w';
                default: break;
            }
            return '?';
        }
    }
}