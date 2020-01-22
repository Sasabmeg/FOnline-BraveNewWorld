using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Dialog
{
    public class Node
    {
        public int Id { get; set; }
        public string ScriptString { get; set; } // None, Attack or module@func (dlg_*)
        public bool ShuffleAnswers { get; set; }
        public Dictionary<String, String> Text = new Dictionary<string, string>(); // Language, text
        public List<Answer> Answers = new List<Answer>();

        public Node() { }
        public Node(int id, string scriptString, bool shuffleAnswers)
        {
            this.Id = id;
            this.ScriptString = scriptString;
            this.ShuffleAnswers = shuffleAnswers;
        }

    }
}
