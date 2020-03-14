using System;
using System.Collections.Generic;

namespace Strings
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int result = 0;

            switch (numbers.Length)
            {
                case 0:
                    result = 0;
                    break;
                case 1:
                    result = int.Parse(numbers);
                    break;
                case 3:

                    var numbersArrayString = numbers.Split(',');
                    result = (int.Parse(numbersArrayString[0]) + int.Parse(numbersArrayString[1]));
                    break;
            }
            return result;

        }
    }
}