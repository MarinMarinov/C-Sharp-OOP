namespace DefiningClassesHomework
{
    using System;

    public class Display
    {
        private double size; // Task 1
        private int colors; // Task 1

        public double Size // Task 5
        {
            get { return this.size; }
            set
            {
                if (value == 0 || value > 13)
                {
                    throw new ArgumentException("Please, enter valid display size!");
                }

                this.size = value;
            }
        }

        public int Colors // Task 5
        {
            get { return this.colors; }
            set
            {
                if (value < 256 || value > int.MaxValue)
                {
                    throw new ArgumentException("Please, enter valid number of colors!");
                }
                this.colors = value;
            }
        }

        public Display(double size, int colors) // Task 2 
        {
            this.Size = size;
            this.Colors = colors;            
        }

        public override string ToString()
        {
            return String.Format("Display Size: {0}, Number of colors: {1}", this.Size, this.Colors);
        }
    }
}