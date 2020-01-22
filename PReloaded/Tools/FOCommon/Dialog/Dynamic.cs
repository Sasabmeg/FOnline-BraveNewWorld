namespace FOCommon.Dialog
{
    public class Dynamic
    {
        public bool ForPlayer { get; set; }
        public Parameter Param;
        public GameVariable Var;
        public FuncCall FuncCall;
        public DialogItem Item;
        public string Operator { get; set; } // TODO: Change to enum
        public int Value { get; set; }
    }
}
