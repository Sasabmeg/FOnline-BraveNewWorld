using System;
using System.Collections.Generic;
using System.Text;

namespace TiledMapper
{
    public class Pair<X, Y>
    {
        public X First;
        public Y Second;

        public Pair(X first, Y second)
        {
            First = first;
            Second = second;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            Pair<X, Y> other = obj as Pair<X, Y>;
            if (other == null)
                return false;

            return
                (((First == null) && (other.First == null))
                    || ((First != null) && First.Equals(other.First)))
                  &&
                (((Second == null) && (other.Second == null))
                    || ((Second != null) && Second.Equals(other.Second)));
        }

        public override int GetHashCode()
        {
            int hashcode = 0;
            if (First != null)
                hashcode += First.GetHashCode();
            if (Second != null)
                hashcode += Second.GetHashCode();

            return hashcode;
        }
    }

}
