using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FOCommon.Worldmap
{
    public interface IWorldMapDrawable
    {
        string ToolTipDescription { get; }
        bool DisplayObject { get; set; }
        void Draw(System.Drawing.Graphics g);
    }
}
