using System.Collections.Generic;
using System.Linq;
using FOCommon.Worldmap;
using FOCommon.Worldmap.EncounterGroup;

namespace WorldEditor
{
    public class ZoneStatistics
    {
        private IZoneProperty zoneProperty;
        public int ZoneCount { get; set; }
        public int ZoneDiffAvg { get; set; }
        public int ZoneDiffMed { get; set; }
        public int ZoneDiffMin { get; set; }
        public int ZoneDiffMax { get; set; }

        public ZoneStatistics(IZoneProperty property)
        {
            this.zoneProperty = property;
        }

        public void CalculateZoneStatistics(List<IZone> Zones)
        {
            ZoneCount = 0;
            List<int> diffs = new List<int>();
            foreach (Zone zone in Zones)
            {
                if (zoneProperty is EncounterGroup)
                {
                    EncounterGroup group = (EncounterGroup)zoneProperty;

                    if (zone.EncounterGroups == null)
                        continue;

                    foreach (EncounterZoneGroup grp in zone.EncounterGroups)
                        if (grp.Name == group.Name)
                        {
                            ZoneCount++;
                            diffs.Add(zone.Difficulty);
                            break;
                        }
                }
            }
            if (diffs.Count == 0)
                return;

            this.ZoneDiffAvg = diffs.Sum() / diffs.Count;
            this.ZoneDiffMin = diffs.Min();
            this.ZoneDiffMax = diffs.Max();
            diffs.Sort();
            if (diffs.Count % 2 == 0)
            {
                if (diffs.Count == 2)
                    this.ZoneDiffMed = this.ZoneDiffAvg;
                else
                    this.ZoneDiffMed = (diffs[diffs.Count / 2] + diffs[(diffs.Count / 2) + 1]) / 2;
            }
            else
                this.ZoneDiffMed = diffs[diffs.Count / 2];

        }
    }
}
