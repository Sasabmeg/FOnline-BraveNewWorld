using System;
using FOCommon.Worldmap;
using FOCommon.Worldmap.EncounterGroup;

namespace WorldEditor
{
    // Thin class for working with worldmap zones.
    public class EncounterZoneGroup : IZoneProperty
    {
        readonly EncounterGroup _group;
        int _quantity;

        public float QuantityDay { get; set; }
        public float QuantityNight { get; set; }

        public string GetName() { return Name; }

        public string Name { get; set; }

        public void RefreshQuantity()
        {
            if (_group != null)
            {
                QuantityDay = _quantity * _group.QuantityDay;
                QuantityNight = _quantity * _group.QuantityNight;
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set 
            {
                _quantity = value;
                RefreshQuantity();
            }
        }


        public EncounterZoneGroup() {}
        public EncounterZoneGroup(String name, int quantity, EncounterGroup group)
        {
            Name = name;
            _quantity = quantity;
            _group = group;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            // safe because of the GetType check
            var grp = (EncounterZoneGroup)obj;

            if (Name != grp.Name) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
   }
}
