namespace FOCommon.Critter
{
    public class CritterProto : ISelectable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CritterProto(int id)
        {
            this.Id = id;
        }

        public CritterProto(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
