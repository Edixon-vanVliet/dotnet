using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void TestPrimeFactorsOf4()
        {
            // arrange
            int a = 4;
            string expected = "2 x 2";

            var primeFactors = new Primes();

            // act
            string actual = primeFactors.PrimeFactors(a);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorsOf7()
        {
            // arrange
            int a = 7;
            string expected = "7";

            var primeFactors = new Primes();

            // act
            string actual = primeFactors.PrimeFactors(a);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorsOf30()
        {
            // arrange
            int a = 30;
            string expected = "5 x 3 x 2";

            var primeFactors = new Primes();

            // act
            string actual = primeFactors.PrimeFactors(a);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorsOf40()
        {
            // arrange
            int a = 40;
            string expected = "5 x 2 x 2 x 2";

            var primeFactors = new Primes();

            // act
            string actual = primeFactors.PrimeFactors(a);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorsOf50()
        {
            // arrange
            int a = 50;
            string expected = "5 x 5 x 2";

            var primeFactors = new Primes();

            // act
            string actual = primeFactors.PrimeFactors(a);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
