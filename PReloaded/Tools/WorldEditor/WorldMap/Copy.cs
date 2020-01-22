
namespace WorldEditor
{
    public interface ICopy
    {
        bool CopyChance { get; set; }
        bool CopyTerrain { get; set; }
        bool CopyDifficulty { get; set; }
        bool CopyGroups { get; set; }
        bool CopyFlags { get; set; }
        bool CopyLocations { get; set; }
        bool Overwrite { get; set; }
    }

    public class Copy : ICopy
    {
       public bool CopyChance { get; set; }
       public bool CopyTerrain { get; set; }
       public bool CopyDifficulty { get; set; }
       public bool CopyGroups { get; set; }
       public bool CopyFlags { get; set; }
       public bool CopyLocations { get; set; }
       public bool Overwrite { get; set; }
    }
}
