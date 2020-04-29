using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.WithObserverPattern
{
    public class TextBox : UIControl
    {
        public TextBox() : base()
        {

        }

        private string content;

        public string Content
        {
            get { return content; }
            set
            { 
                content = value;
                NotifyObservers();
            }
        }

    }
}
