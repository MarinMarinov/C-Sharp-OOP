namespace Problem_1.Shapes
{
    using System;
    
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width can't be zero or negative number!");
                }
                this.width = value;
            }
        }

        public virtual double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height can't be zero or negative number!");
                }
                this.height = value;
            }
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double side)
        {
            this.Width = side;
        }

        public abstract double CalculateSurface();
    }
}
