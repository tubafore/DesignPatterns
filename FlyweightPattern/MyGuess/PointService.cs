using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class PointService
    {
        private Random random;
        private IconStore store;
        public PointService()
        {
            random = new Random(5);
            store = new IconStore();
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < 100; i++)
                points.Add(new Point(random.Next(0, 5), random.Next(0, 5), PointType.CAFE, store[random.Next(0, 5)])); //allocates 116MB of memory
                //points.Add(new Point(random.Next(0, 5), random.Next(0, 5), PointType.CAFE, new Icon()));   //Definitely not flyweigth pattern...allocates 2GB of memory
            return points;
        }
    }
}
