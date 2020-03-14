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
        public void GetAddedNumberFromStringWithTwoNumber()
        {
            StringCalculator stringCalculator = new StringCalculator();

            var result = stringCalculator.Add("1,2");
            Assert.Equal(3, result);
        }
    }
}
