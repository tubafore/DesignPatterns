using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class PointService
    {
        private PointIconFactory factory;

        public PointService()
        {
            factory = new PointIconFactory();
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(1, 2, factory.GetPointIcon(PointType.CAFE)));

            return points;
        }
    }
}
