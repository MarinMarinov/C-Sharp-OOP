//Task 4
namespace Problem_1_4
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointList;

        public List<Point3D> PointList
        {
            get { return this.pointList; }
            private set { this.pointList = value; }
        }

        public Path()
        {
            this.PointList = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.PointList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.PointList.Remove(point);
        }
    }
}