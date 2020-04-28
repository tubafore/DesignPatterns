using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
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
                Console.WriteLine($"TextBox content changed to {content}");
                Parent.Changed(this);
            }
        }

        public TextBox(DialogBox dialogBox) : base(dialogBox)
        {
        }
    }
}
