using System;

using FOCommon.Worldmap;

namespace WorldEditor
{
    // Thin class for working with worldmap zones.
    public class EncounterZoneLocation : IEquatable<EncounterZoneLocation>, IZoneProperty
    {
        public string GetName() { return Name; }
        public string Name { get; set; }

        public bool Equals(EncounterZoneLocation x)
        {
            return this.Name == x.Name;
        }

        public int GetHashCode(EncounterZoneLocation obj)
        {
            return obj.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            // safe because of the GetType check
            EncounterZoneLocation loc = (EncounterZoneLocation)obj;

            if (Name != loc.Name) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
