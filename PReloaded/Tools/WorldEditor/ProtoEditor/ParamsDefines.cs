using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WorldEditor.ProtoEditor
{
    public static class ParamsDefines
    {
        private static string Filename;
        public static Dictionary<string,int> ParamNames = new Dictionary<string,int>();
        public static Dictionary<int,string> Names = new Dictionary<int,string>();
        public static List<string> Bodytypes = new List<string>();
        public static List<HashSet<int>> Depends = new List<HashSet<int>>();
        public static List<List<IntPair>> SkillFormulas = new List<List<IntPair>>();
        public static SkillAdder Add = new SkillAdder();
        public static List<string> PerksList = new List<string>();
        public static List<string> TraitsList = new List<string>();
        public static List<string> ModesList = new List<string>();

        public static bool Initialized = false;
        public static void Init(string _filename)
        {
            Filename = _filename;
            for (int i = 0; i < 30;i++ ) Bodytypes.Add("bt" + i); // TODO
            for (int i = 0; i < 18; i++) SkillFormulas.Add(new List<IntPair>());
            for (int i = 0; i < 7; i++) Depends.Add(new HashSet<int>());
            Add.Skill(Consts.SK_SMALL_GUNS).Base(5).Stat(Consts.ST_AGILITY, 4);
            Add.Skill(Consts.SK_BIG_GUNS).Stat(Consts.ST_AGILITY,2);
            Add.Skill(Consts.SK_ENERGY_WEAPONS).Stat(Consts.ST_AGILITY,2);
            Add.Skill(Consts.SK_UNARMED).Base(30).Stat(Consts.ST_AGILITY, 2).Stat(Consts.ST_STRENGTH,2);
            Add.Skill(Consts.SK_SCAVENGING).Base(0);
            Add.Skill(Consts.SK_THROWING).Stat(Consts.ST_AGILITY,4);
            Add.Skill(Consts.SK_FIRST_AID).Stat(Consts.ST_PERCEPTION, 2).Stat(Consts.ST_INTELLECT,2);
            Add.Skill(Consts.SK_DOCTOR).Base(5).Stat(Consts.ST_PERCEPTION).Stat(Consts.ST_INTELLECT);
            Add.Skill(Consts.SK_SNEAK).Base(5).Stat(Consts.ST_AGILITY, 3);
            Add.Skill(Consts.SK_LOCKPICK).Base(10).Stat(Consts.ST_PERCEPTION).Stat(Consts.ST_AGILITY);
            Add.Skill(Consts.SK_STEAL).Stat(Consts.ST_AGILITY, 3);
            Add.Skill(Consts.SK_TRAPS).Base(10).Stat(Consts.ST_PERCEPTION).Stat(Consts.ST_AGILITY);
            Add.Skill(Consts.SK_SCIENCE).Stat(Consts.ST_INTELLECT, 4);
            Add.Skill(Consts.SK_REPAIR).Stat(Consts.ST_INTELLECT, 3);
            Add.Skill(Consts.SK_SPEECH).Stat(Consts.ST_CHARISMA, 5);
            Add.Skill(Consts.SK_BARTER).Stat(Consts.ST_CHARISMA, 4);
            Add.Skill(Consts.SK_GAMBLING).Stat(Consts.ST_LUCK, 5);
            Add.Skill(Consts.SK_OUTDOORSMAN).Stat(Consts.ST_ENDURANCE, 2).Stat(Consts.ST_INTELLECT, 2);
        }
        public static bool Parse()
        {
            if (!File.Exists(Filename))
            {
                MessageBox.Show("Cannot find "+Filename);
                return false;
            }
            ParamNames.Clear();
            Names.Clear();
            char[] seps = new char[] { '\t', ' ' };
            List<string> lines = new List<string>(File.ReadAllLines(Filename));
            short base_id = 0;
            foreach (string line in lines)
            {
                line.Trim();
                string[] splittedLine = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                if (splittedLine.Length > 2 || splittedLine.Length == 0) continue;
                if(splittedLine.Length==1)
                {
                    if(splittedLine[0][0]!='*') continue;
                    if (!Int16.TryParse(splittedLine[0].Remove(0, 1), out base_id)) continue;
                }

                int id;
                if(!int.TryParse(splittedLine[0],out id)) continue;
                id += base_id;
                if (!ParamNames.ContainsKey(splittedLine[1])) ParamNames.Add(splittedLine[1], id);
                if (!Names.ContainsKey(id)) Names.Add(id, splittedLine[1]);
                if (IsPerk(splittedLine[1])) PerksList.Add(splittedLine[1]);
                else
                    if (IsMode(splittedLine[1])) ModesList.Add(splittedLine[1]);
                else
                    if (IsTrait(splittedLine[1])) TraitsList.Add(splittedLine[1]);
            }
            Initialized = true;
            return true;
        }
        public static int GetParam(string s)
        {
            if (!ParamNames.ContainsKey(s)) return -1;
            return ParamNames[s];
        }
        public static string GetParamName(int n)
        {
            if (!Names.ContainsKey(n)) return "";
            return Names[n];
        }
        private static bool IsPerk(string s)
        {
            return (String.Compare(s, 0, "PE_", 0, 3) == 0);
        }
        private static bool IsMode(string s)
        {
            return (String.Compare(s, 0, "MODE_", 0, 5) == 0);
        }
        private static bool IsTrait(string s)
        {
            return (String.Compare(s, 0, "TRAIT_", 0, 6) == 0);
        }
        public static void FillBodytypes(ComboBox box)
        {
            box.DataSource = Bodytypes;
        }
        public static void FillPerks(ComboBox box)
        {
            box.DataSource = PerksList;
        }
        public static void FillModes(ComboBox box)
        {
            box.DataSource = ModesList;
        }
        public static void FillTraits(ComboBox box)
        {
            box.DataSource = TraitsList;
        }
    }
    public class SkillAdder
    {
        public int skill;
        public SkillAdder()
        {
        }
        public SkillAdder Skill(int skill)
        {
            this.skill = skill-200;
            return this;
        }
        public SkillAdder Stat(int stat)
        {
            ParamsDefines.Depends[stat].Add(skill);
            ParamsDefines.SkillFormulas[skill].Add(new IntPair(stat,1));
            return this;
        }
        public SkillAdder Stat(int stat, int mul)
        {
            ParamsDefines.Depends[stat].Add(skill);
            ParamsDefines.SkillFormulas[skill].Add(new IntPair(stat, mul));
            return this;
        }
        public SkillAdder Base(int num)
        {
            ParamsDefines.SkillFormulas[skill].Add(new IntPair(-1, num));
            return this;
        }
    }
}
