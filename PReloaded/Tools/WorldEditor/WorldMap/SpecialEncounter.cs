using System.Collections.Generic;

using FOCommon.WMLocation;

namespace WorldEditor
{
    public class SpecialEncounter
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public double Chance { get; set; } // Saved as random(1,x) value, converted to/from percentage
        public List<Condition> Conditions = new List<Condition>();
        public List<Result> Results = new List<Result>();

        public SpecialEncounter(string Name, string Description, Location Location, int Chance)
        {
            this.Name = Name;
            this.Description = Description;
            this.Location = Location;
            this.Chance = Chance;
        }

        public void AddCondition(ConditionType Type, string Variable, string Op, int Value)
        {
            Conditions.Add(new Condition(Type, Variable, Op, Value));
        }

        public void AddResult(ConditionType Type, string Variable, string Op, int Value)
        {
            Results.Add(new Result(Type, Variable, Op, Value));
        }
    }

    public static class SpecialEncounterFormat
    {
        public static List<SpecialEncounter> LoadSpecialEncounters(string FileName)
        {
            return null;
        }

        public static void SaveSpecialEncounters(string FileName, List<SpecialEncounter> SpecialEncounters)
        {

        }
    }
}
