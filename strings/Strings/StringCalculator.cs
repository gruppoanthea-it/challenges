using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int result = 0;
            var exceptionMessage = new StringBuilder();

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
                    foreach(String stringNumber in numbersArrayString)
                    {
                        int number = int.Parse(stringNumber);
                        if (number < 0)
                        {
                            exceptionMessage.Append(String.Format("{0} ", number));
                        }
                        else if (number >= 1000)
                            continue;
                        result += number;
                    }
                    break;
            }

            if (exceptionMessage.Length > 0)
            {
                throw new NegativeNumbersException(exceptionMessage.ToString().Substring(0, exceptionMessage.Length - 1));
            }
            return result;
        }
    }
}