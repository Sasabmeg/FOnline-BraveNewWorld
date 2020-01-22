
namespace WorldEditor
{
    public enum ConditionType
    {
        Parameter,
        LocalVariable,
        GlobalVariable,
        Item,
        Flag
    }

    public class Result
    {
        public Result(ConditionType Type, string Variable, string Op, int Value)
        {
            this.Type = Type;
            this.Variable = Variable;
            this.Op = Op;
            this.Value = Value;
        }

        public ConditionType Type { get; set; }
        public string Variable { get; set; }
        public string Op { get; set; }
        public int Value { get; set; }
    }

    public class Condition
    {
        public Condition(ConditionType Type, string Variable, string Op, int Value)
        {
            this.Type = Type;
            this.Variable = Variable;
            this.Op = Op;
            this.Value = Value;
        }

        public ConditionType Type { get; set; }
        public string Variable { get; set; }
        public string Op { get; set; }
        public int Value { get; set; }
    }
}
