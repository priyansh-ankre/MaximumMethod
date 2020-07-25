using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MaximumMethod
{
    public class MaximumMethodUtility
    {
        public static object findMaximum(params object[] input)
        {
            Array.Sort(input);
            return input[input.Length-1];
        }
    }
}
