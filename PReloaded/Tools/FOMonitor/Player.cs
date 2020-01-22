using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FOMonitor
{
    class Player
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string Map { get; set; }
        public string FromFile { get; set; }
        public string TimeStamp { get; set; }
        public int MapId { get; set; }
        public int MapPid { get; set; }
        public string Location { get; set; }
        public int LocationId { get; set; }
        public int LocationPid { get; set; }
        public string MapString { get; set; }
        public string NetState { get; set; }
        public string Cond { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Level { get; set; }
    }
}
