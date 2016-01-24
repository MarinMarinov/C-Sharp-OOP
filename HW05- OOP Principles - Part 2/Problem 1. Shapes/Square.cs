namespace Problem_1.Shapes
{
    public class Square: Shape
    {
        public Square(double side) : base(side)
        {
        }        

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
