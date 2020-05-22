using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Style
    {
        private string fontFamily;
        private int fontSize;
        private bool bold;

        public string FontFamily
        {
            get { return fontFamily; }
            set { fontFamily = value; }
        }

        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }

        public bool Bold
        {
            get { return bold; }
            set { bold = value; }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = FontFamily.GetHashCode();
                result ^= FontSize.GetHashCode();
                result ^= Bold.GetHashCode();
                return result;
            }
        }

        public Style ShallowCopy()
        {
            return (Style)MemberwiseClone();
        }
    }
}
