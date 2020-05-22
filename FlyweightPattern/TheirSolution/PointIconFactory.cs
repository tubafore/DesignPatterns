using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons;

        public PointIcon this[PointType index]
        {
            get { return icons[index]; }
        }

        public PointIconFactory()
        {
            icons = new Dictionary<PointType, PointIcon>();
        }

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
            {
                icons[pointType] = new PointIcon(pointType, null);
            }
            return icons[pointType];
        }
    }
}
