using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MaximumMethod
{
    public class MaximumMethodUtility<E> where E : IComparable<E>
    {
        E first;
        E second;
        E third;
        public MaximumMethodUtility(E first, E second, E third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public E findMaximum()
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
