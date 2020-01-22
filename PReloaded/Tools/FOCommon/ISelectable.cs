using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon
{
    // Classes that implements this can be used in a selection form
    public interface ISelectable
    {
        string Name { get; set; }
        int Id { get; set; }
    }
}
