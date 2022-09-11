using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Params
{
    public class Params
    {
        //REF
        // public static void Triple(ref int x)
        // {
        //     x = x * 3;
        // }
        //OUT
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
