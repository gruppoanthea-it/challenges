using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class NegativeNumbersException : Exception
    {
        public NegativeNumbersException()
        {

        }

        public NegativeNumbersException(string numbers) 
            : base("Negative numbers are not allowed: " + numbers)
        {
        }
    }
}
