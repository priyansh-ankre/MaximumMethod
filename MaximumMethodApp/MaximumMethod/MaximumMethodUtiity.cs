using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumMethod
{
    public class MaximumMethodUtiity
    {
       public E findMaximum<E>(E first,E second,E third) where E : IComparable
        {
            E maximum = first;
            if (second.CompareTo(maximum) > 0)
            {
                maximum = second;
            }
            if (third.CompareTo(maximum) > 0)
            {
                maximum = third;
            }
            return maximum;
        }

    }
}
