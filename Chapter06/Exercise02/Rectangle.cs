namespace Exercise02
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            Area = CalculateArea();
        }

        private double CalculateArea()
        {
            return Width * Height;
        }
    }
}