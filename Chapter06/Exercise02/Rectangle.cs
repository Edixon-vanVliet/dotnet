namespace Exercise02
{
    public class Rectangle : Shape
    {
        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
            Area = CalculateArea();
        }

        private float CalculateArea()
        {
            return Width * Height;
        }
    }
}