using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    public class StringCalculator
    {
        public int Add(string s)
        {
            if (!s.StartsWith('/'))
            {
                s = "//[,]//" + s;
            }

            int result = 0;
            var exceptionMessage = new StringBuilder();
            var globalPattern = @"^(\/{2})(\[.*\])(\/{2})(.*)$";
            var delimitersMatches = Regex.Matches(s, @"\[(.*?)\]");
            var splittedString = Regex.Split(s, globalPattern);
            var numbers = splittedString[^2];

            foreach (var match in delimitersMatches)
                numbers = numbers.Replace(match.ToString()[1..^1], ",");
            

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