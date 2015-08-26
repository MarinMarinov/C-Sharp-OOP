//Task 3

namespace Problem_1_4
{
    using System;

    public static class Distance3D 
    {
        public static double Calculate(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt
                ((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) + 
                (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) + 
                (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
            
            return distance;
        }
    }
}