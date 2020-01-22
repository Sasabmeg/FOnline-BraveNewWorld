using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon
{
    public enum GameVariableType
    {
        Global,
        Local,
        Unicum,
        LocalLocation,
        LocalMap,
        LocalItem
    };

    public class GameVariable
    {
        public String Name;
        public int Id;
        public string Description;
        public GameVariableType Type;
        public int StartValue;
        public int MaxValue;
        public int MinValue;
        public bool Quest;
        public bool Random;
        public bool NoLimit;
    }
}
