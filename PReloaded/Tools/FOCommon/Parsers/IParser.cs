
namespace FOCommon.Parsers
{
    public interface IParser
    {
        bool Parse(); // Loads file(s) and parses.
        bool IsParsed(); // Useful when doing multithreaded work.
        // ParseError GetError(); // TODO: Implement for all parsers, see DefineParser.cs
    }

    public class BaseParser
    {
        protected bool _IsParsed { get; set; }
        public bool IsParsed() { return _IsParsed; }
    }
}
