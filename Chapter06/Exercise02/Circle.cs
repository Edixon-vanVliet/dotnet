using System;

namespace Exercise02
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Height = Width = radius;
            Area = CalculateArea();
        }

        private double CalculateArea() => Math.PI * Math.Pow(Height, 2);
    }
}