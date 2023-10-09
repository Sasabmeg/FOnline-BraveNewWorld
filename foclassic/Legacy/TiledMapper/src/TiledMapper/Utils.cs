using System;
using System.Collections.Generic;
using System.Text;

namespace TiledMapper
{
    public static class Utils
    {
        private static Random rnd = new Random((int)DateTime.Now.Ticks);

        public static int Random(int min, int max)
        {
            if (min > max)
            {
                int tmp = min;
                min = max;
                max = tmp;
            }
            return min + rnd.Next(max - min + 1);
        }

        public static string HashCode(int hash)
        {
            return Convert.ToString(hash, 2).PadLeft(8, '0');
        }
    }
}

// .net 2.0 workaround
namespace System.Runtime.CompilerServices
{
    public class ExtensionAttribute : Attribute { }
}