using System;
using System.Collections.Generic;

namespace FOCommon.Dialog
{
    // TODO: Improve API so that it becomes easier to add new dialog content, it's currently a bit too low-level.

    public class Dialog
    {
        public const int Exit = 0;
        public const int Back = 65505;
        public const int Barter = 65506;
        public const int Attack = 65507;


        public static string GetOperator(String str)
        {
            if (str == "}") str = ">=";
            if (str == "{") str = "<=";
            if (str == "!") str = "!=";
            return str;
        }

        public static string SetOperator(String str)
        {
            if (str == ">=") str = "}";
            if (str == "<=") str = "{";
            if (str == "!=") str = "!";
            return str;
        }


        // Metadata, only used by editor, subclass (?)
        public string FileName;

        //               Language, Value(s)

        public Dictionary<String, String> NpcName;// { get; set; }
        public string Comment;// { get; set; }
        public Dictionary<String, List<String>> DescriptionAlive { get; set; }
        public Dictionary<String, List<String>> DescriptionAliveFull { get; set; }
        public Dictionary<String, List<String>> DescriptionKnocked { get; set; }
        public Dictionary<String, List<String>> DescriptionKnockedFull { get; set; }
        public Dictionary<String, List<String>> DescriptionDead { get; set; }
        public Dictionary<String, List<String>> DescriptionDeadFull { get; set; }
        public Dictionary<String, List<String>> DescriptionCriticalDead { get; set; }
        public Dictionary<String, List<String>> DescriptionCriticalDeadFull { get; set; }

        public Dictionary<String, Dictionary<int, List<String>>> UserStrings { get; set; }

        public List<Node> Nodes { get; set; }
        public List<String> LanguageTrees { get; set; }

        public Dialog()
        {
            Nodes = new List<Node>();
            NpcName                     = new Dictionary<string, string>();
            DescriptionAlive            = new Dictionary<string, List<string>>();
            DescriptionAliveFull        = new Dictionary<string, List<string>>();
            DescriptionKnocked          = new Dictionary<string, List<string>>();
            DescriptionKnockedFull      = new Dictionary<string, List<string>>();
            DescriptionDead             = new Dictionary<string, List<string>>();
            DescriptionDeadFull         = new Dictionary<string, List<string>>();
            DescriptionCriticalDead     = new Dictionary<string, List<string>>();
            DescriptionCriticalDeadFull = new Dictionary<string, List<string>>();
            UserStrings                 = new Dictionary<string, Dictionary<int, List<string>>>();
        }
    }
}
