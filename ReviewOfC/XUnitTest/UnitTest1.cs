using System;
using Xunit;
using static ReviewOfC.Program;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("7 4 1", 28)]
        [InlineData("10 8 3", 240)]

        public void CalculateCorrectProducts(string input, int expected)
        {
            int result = ProductString(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 4", 0)]
        [InlineData("5 10 6 4", 300)]
        public void ProductCanHandleDifferentSizes(string input, int expected)
        {
            int result = ProductString(input);
            Assert.Equal(expected, result);
        }
    }
}
