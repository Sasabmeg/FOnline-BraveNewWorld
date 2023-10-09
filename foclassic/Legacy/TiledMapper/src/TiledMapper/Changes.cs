using System;
using System.Collections.Generic;
using System.Text;

namespace TiledMapper
{
    /// <summary>
    /// The base class for all undoable and redoable actions in the editor
    /// </summary>
    public class BaseChange
    {
        public readonly ChangeType Type;
        public bool StopUndo;
        public bool StopRedo;
        protected BaseChange(ChangeType type)
        {
            Type = type;
            StopUndo = true;
            StopRedo = true;
        }
    }

    /// <summary>
    /// The class representing a single map resizing step.
    /// </summary>
    public class ChangeInternalResize : BaseChange
    {
        public readonly int Dir;
        public readonly int Size;
        public readonly Tile[,] Tiles;
        public ChangeInternalResize(int dir, int size, Tile[,] tiles) : base(ChangeType.InternalResize)
        {
            Dir = dir;
            Size = size;
            Tiles = tiles;
            if (dir != Directions.North) StopUndo = false;
            if (dir != Directions.West) StopRedo = false;
        }
    }

    /// <summary>
    /// The class representing toggling a single tile.
    /// </summary>
    public class ChangeToggleTile : BaseChange
    {
        public readonly int X;
        public readonly int Y;
        public readonly int PreviousVariant;
        public ChangeToggleTile(int x, int y, int previousVariant) : base(ChangeType.ToggleTile)
        {
            X = x;
            Y = y;
            PreviousVariant = previousVariant;
        }
    }

    /// <summary>
    /// The class representing toggling a single tile wall.
    /// </summary>
    public class ChangeToggleBlock : BaseChange
    {
        public readonly int X;
        public readonly int Y;
        public readonly int Dir;
        public ChangeToggleBlock(int x, int y, int dir) : base(ChangeType.ToggleBlock)
        {
            X = x;
            Y = y;
            Dir = dir;
        }
    }

    /// <summary>
    /// The class representing change of the tile's variant.
    /// </summary>
    public class ChangeSetVariant : BaseChange
    {
        public readonly int X;
        public readonly int Y;
        public readonly int From;
        public readonly int To;
        public ChangeSetVariant(int x, int y, int from, int to)
            : base(ChangeType.SetVariant)
        {
            X = x;
            Y = y;
            From = from;
            To = to;
        }
    }

    /// <summary>
    /// The class representing toggling corridor's width.
    /// </summary>
    public class ChangeToggleWide : BaseChange
    {
        public readonly int X;
        public readonly int Y;
        public readonly bool From;
        public readonly bool To;
        public ChangeToggleWide(int x, int y, bool from, bool to)
            : base(ChangeType.ToggleWide)
        {
            X = x;
            Y = y;
            From = from;
            To = to;
        }
    }

    /// <summary>
    /// The class representing placement or deletion of scrollblock marker.
    /// </summary>
    public class ChangeSetScrollBlockers : BaseChange
    {
        public readonly int X;
        public readonly int Y;
        public readonly int Index;
        public ChangeSetScrollBlockers(int x, int y, int index)
            : base(ChangeType.SetScrollblockers)
        {
            X = x;
            Y = y;
            Index = index;
        }
    }

    /// <summary>
    /// The class representing toggling between edit modes.
    /// </summary>
    public class ChangeConvert : BaseChange
    {
        public readonly bool Forward;
        public ChangeConvert(bool forward) : base(ChangeType.Convert)
        {
            Forward = forward;
        }
    }

    /// <summary>
    /// The dummy guardian change class.
    /// </summary>
    public class ChangeDummy : BaseChange
    {
        public ChangeDummy()
            : base(ChangeType.Dummy)
        {
        }
    }
}
