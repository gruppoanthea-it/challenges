using System;
using System.Collections.Generic;

namespace Strings
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int result=0;

            if (numbers.Length == 0)
                return result;
            else if (numbers.Length == 1)
                return int.Parse(numbers);
            else
                return result;
        }
    }
}