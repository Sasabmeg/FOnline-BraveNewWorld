using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Parsers
{
    public class ParseError
    {
        public string File { get; set; }
        public Exception Exception { get; set; }
        public string ErrorLine { get; set; }
    }
}
