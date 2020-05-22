using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Point
    {
        private int x, y;
        private PointIcon icon;

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{Enum.GetName(typeof(PointType), icon.Type)} at ({x}, {y})");
        }
    }
}
