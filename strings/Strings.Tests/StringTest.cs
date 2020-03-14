using System;
using Xunit;

namespace Strings.Tests
{
    public class StringTest
    {
        [Fact]
        public void GetZeroFromEmptyString() {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.Equal(0, stringCalculator.Add(""));
        }

        [Fact]
        public void GetNumberFromStringWithOneNumber()
        {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.Equal(1, stringCalculator.Add("1"));
        }

        [Fact]
        public void GetAddedNumberFromStringWithTwoNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();

            var result = stringCalculator.Add("1,2");
            Assert.Equal(3, result);
        }

        [Fact]
        public void GetAddedNumberFromStringWithUknownAmountOfNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();

            var result = stringCalculator.Add("1,2,3,4");
            Assert.Equal(10, result);
        }
        
        [Fact]
        public void GetExcpetionWithNegativeNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var ex = Assert.Throws<NegativeNumbersException>(() => stringCalculator.Add("1,-2,3,-4"));
            Assert.Equal("Negative numbers are not allowed: -2 -4", ex.Message);
        }


    }
}
