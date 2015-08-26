namespace Problem_1_4
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D pointO; // task 2

        private double x;    // Task 1
        private double y;    // Task 1
        private double z;    // Task 1

        public static Point3D O // Task 2
        {
            get {return pointO;}
        }
        
        static Point3D()  //Task 2
        {
            pointO = new Point3D(0,0,0);
        }
        
        public double X //Task 1
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y   //Task 1
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public double Z  //Task 1
        {
            get { return this.z; }
            private set { this.z = value; }
        }

        public Point3D(double x, double y, double z) : this() //Task 1
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()   //Task 1
        {
            return string.Format("X = {0}, Y = {1}, Z = {2}", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}