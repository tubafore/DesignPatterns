using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class TextBox : UIControl
    {
        private string content;

        public string Content
        {
            get { return content; }
            set
            { 
                content = value;
                Notify();
            }
        }

        public TextBox() : base()
        {

        }
    }
}
