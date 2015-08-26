namespace Problem_1_4
{
    using System;
    using System.Collections.Generic;

    class TheMain
    {
        static void Main()
        {
            
            Point3D firstDot = new Point3D(3, 4, 5);
            Console.WriteLine(firstDot.ToString());

            Console.WriteLine(Point3D.O.ToString());

            Point3D secondDot = new Point3D(4, 5, 6);

            Console.WriteLine(Distance3D.Calculate(firstDot, secondDot));

            Path newPath = new Path();
            newPath.AddPoint(firstDot);
            newPath.AddPoint(secondDot);

            Console.WriteLine(newPath.PointList.IndexOf(firstDot));
            Console.WriteLine(newPath.PointList.Contains(secondDot));

            Point3D point1 = new Point3D(1.5, 2.5, 3.5);
            Point3D point2 = new Point3D(-1, -4, 7);
            Point3D point3 = new Point3D(1, 2, 3);
            Point3D point4 = new Point3D(-1, -2, 3);
            Point3D point5 = new Point3D(1.25, 2.375, 3.8);

            Path testPath = new Path();

            testPath.AddPoint(point1);
            testPath.AddPoint(point2);
            testPath.AddPoint(point3);
            testPath.AddPoint(point4);
            testPath.AddPoint(point5);

            PathStorage.SavePath(testPath, "sample"); //saving the test points to the file "pathSample.txt"

            Path loadedPath = PathStorage.LoadPath(@"../../pathsample.txt"); //loading the saved file and printing the points

            for (int i = 0; i < loadedPath.PointList.Count; i++)
            {
                Console.WriteLine(loadedPath.PointList[i]);
            }
        }
    }
}