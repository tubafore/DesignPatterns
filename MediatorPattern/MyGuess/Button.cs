using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Button : UIControl
    {
        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set
            { 
                enabled = value;
                Console.WriteLine($"Button is {(enabled ? "" : "not" )} enabled");
                Parent.Changed(this);
            }
        }


        public Button(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
