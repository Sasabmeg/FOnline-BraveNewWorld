using System;
using System.Collections.Generic;
using System.Text;

namespace FOCommon.Items
{
    public class Item
    {
        public int Pid { get; set; }
        public string Define { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(int pid)
        {
            this.Pid = pid;
        }

        public Item(int pid, string define)
        {
            this.Pid = pid;
            this.Define = define;
        }
    }
}
