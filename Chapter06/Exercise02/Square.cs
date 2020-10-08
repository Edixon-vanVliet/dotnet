using System;

namespace Exercise02
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Height = Width = side;
            Area = CalculateArea();
        }

        private double CalculateArea() => Math.Pow(Height, 2);
    }
}