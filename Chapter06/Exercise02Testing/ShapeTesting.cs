using System;
using Xunit;
using Exercise02;

namespace Exercise02Testing
{
    public class ShapeTesting
    {
        [Theory]
        [InlineData(59.28, 41.74)]
        [InlineData(34.44, 69.05)]
        [InlineData(69.71, 31.75)]
        public void TestRectangle(double height, double width)
        {
            // arrange
            double expectedArea = width * height; // A = wl

            // act
            var actual = new Rectangle(height, width);

            // assert
            Assert.Equal(expectedArea, actual.Area);
        }
        
        [Theory]
        [InlineData(13.37)]
        [InlineData(94.69)]
        [InlineData(74.33)]
        public void TestSquare(double side)
        {
            // arrange
            double expectedArea = Math.Pow(side, 2); // A = a^2

            // act
            var actual = new Square(side);

            // assert
            Assert.Equal(expectedArea, actual.Area);
        }

        [Theory]
        [InlineData(33.24)]
        [InlineData(93.33)]
        [InlineData(96.17)]
        public void TestCircle(double radius)
        {
            // arrange
            double expectedArea = Math.PI * Math.Pow(radius, 2); // A = πr^2

            // act
            var actual = new Circle(radius);

            // assert
            Assert.Equal(expectedArea, actual.Area);
        }
    }
}
