using System;
using System.Collections.Generic;

namespace FOCommon.Dialog
{
    public class Answer
    {
        public Dictionary<String, String> Text; // language, text
        public List<Demand> Demands;
        public List<Result> Results;
        public int ToNode { get; set; } // 0 = Exit Dialog
                                        // 65505 = Go back to previous node
                                        // 65506 = Barter
                                        // 65507 = Attack

        public Answer()
        {
            Demands = new List<Demand>();
            Results = new List<Result>();
            Text = new Dictionary<string, string>();
        }
    }
}
