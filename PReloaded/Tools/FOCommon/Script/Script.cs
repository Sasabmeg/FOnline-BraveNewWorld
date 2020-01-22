using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Script
{
    public enum ScriptApp
    {
        Client,
        Server,
        Mapper
    };

    public enum ScriptType
    {
        Module, // AS
        Bind // Reserved functions
    };

    public class ScriptDeclaration
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public ScriptType Type { get; set; }
        public ScriptApp App { get; set; }
        public string Description { get; set; }
        public string ReservedPlace { get; set; } // main, *.dll etc.

        public ScriptDeclaration(string Name, ScriptApp App, ScriptType Type, bool Enabled)
        {
            this.Name = Name;
            this.App = App;
            this.Type = Type;
            this.Enabled = Enabled;
        }
    }
}
