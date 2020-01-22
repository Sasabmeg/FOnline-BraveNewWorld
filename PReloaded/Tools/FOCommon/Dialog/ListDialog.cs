using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Dialog
{
    public class ListDialog : ISelectable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        public ListDialog(int id)
        {
            this.Id = id;
        }

        public ListDialog(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ListDialog(int id, string name, bool enabled)
        {
            this.Id = id;
            this.Name = name;
            this.Enabled = enabled;
        }
    }
}
