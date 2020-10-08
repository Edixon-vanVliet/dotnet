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

        private double CalculateArea()
        {
            return Math.Pow(Height, 2);
        }
    }
}