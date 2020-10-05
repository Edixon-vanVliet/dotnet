using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // arange
            double a = 2;
            double b = 2;
            double expected = 4;

            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
