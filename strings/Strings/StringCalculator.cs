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
                default:

                    var numbersArrayString = numbers.Split(',');
                    foreach(String number in numbersArrayString)
                    {
                        result += int.Parse(number);
                    }
                    break;
            }
            return result;

        }
    }
}