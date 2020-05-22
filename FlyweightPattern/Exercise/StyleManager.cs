using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise
{
    public class StyleManager
    {
        private List<Style> styles;
        private readonly Style defaultStyle;

        public StyleManager(Style defaultStyle)
        {
            styles = new List<Style>();
            this.defaultStyle = defaultStyle;
        }

        public Style DefaultStyle
        {
            get { return defaultStyle; }
        }

        public Style this[int hashCode]
        {
            get { return GetStyleByHashCode(hashCode); }
            set { styles.Add(value); }
        }

        private Style GetStyleByHashCode(int hashCode)
        {
            Style style = (from s in styles
                           where s.GetHashCode() == hashCode
                           select s).FirstOrDefault();
            return style;
        }

        public bool Contains(Style style)
        {
            return styles.Contains(style);
        }
    }
}
