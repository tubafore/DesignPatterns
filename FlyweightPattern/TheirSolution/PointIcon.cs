using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class PointIcon
    {
        private readonly PointType type;
        private readonly byte[] icon;

        public PointType Type { get { return type; } }
        public byte[] IconBytes { get { return icon; } }

        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }
    }
}
