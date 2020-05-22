using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class IconStore
    {
        private List<Icon> icons;

        public IconStore()
        {
            icons = new List<Icon> { new Icon(), new Icon(), new Icon(), new Icon(), new Icon() };
        }

        public Icon this[int index]
        {
            get { return icons[index]; }
        }
    }
}
