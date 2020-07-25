using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MaximumMethod
{
    public class MaximumMethodUtility
    {
        object[] input;
        public MaximumMethodUtility(params object[] input)
        {
            this.input = input;
        }
        public object findMaximum()
        {
            Array.Sort(input);
            return input[input.Length-1];
        }
        public void toPrint()
        {
            Console.WriteLine(input[input.Length-1]);
        }
    }
}
