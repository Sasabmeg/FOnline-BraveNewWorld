namespace FOCommon.WMLocation
{
    public class EntryPoint
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string MapName { get; set; }
        public int Entire { get; set; }

        public EntryPoint(string name, int x, int y)
        {
            this.Name = name;
            this.Entire = 0;
            this.X = x;
            this.Y = y;
        }

        public EntryPoint() { }
    }
}
