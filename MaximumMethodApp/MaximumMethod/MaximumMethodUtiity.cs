using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumMethod
{
    public class MaximumMethodUtiity
    {
        public int findMaximum(int firstNumber,int secondNumber,int thirdNumber)
        {
            int maximum = firstNumber;
            if (secondNumber.CompareTo(maximum) > 0)
            {
                maximum = secondNumber;
            }
            if (thirdNumber.CompareTo(maximum) > 0)
            {
                maximum = thirdNumber;
            }
            return maximum;
        }
    }
}
