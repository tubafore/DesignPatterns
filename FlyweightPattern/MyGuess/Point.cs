using System;

namespace MyGuess
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointType PointType { get; set; }
        public Icon Icon { get; set; }

        public Point(int x, int y, PointType type, Icon icon)
        {
            X = x;
            Y = y;
            PointType = type;
            Icon = icon;
        }

        public override string ToString()
        {
            return $"There's a {Enum.GetName(typeof(PointType), PointType)} at {X}, {Y}";
        }
    }
}
