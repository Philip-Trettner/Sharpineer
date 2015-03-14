using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Helper
{
    public static class NumberExtensions
    {
        public static bool IsPowerOfTwo(this long v)
        {
            return v >= 0 && ((ulong)v).IsPowerOfTwo();
        }

        public static bool IsPowerOfTwo(this ulong v)
        {
            return (v & (v - 1)) == 0;
        }
    }
}
