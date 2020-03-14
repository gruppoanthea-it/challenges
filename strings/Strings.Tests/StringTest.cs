using System;
using Xunit;

namespace Strings.Tests
{
    public class StringTest
    {

        [Fact]
        public void GetAddedNumberFromStringWithTwoNumber()
        {
            StringCalculator stringCalculator = new StringCalculator();

            var result = stringCalculator.add("1,2");
            Assert.Same(3, result);
        }
    }
}
