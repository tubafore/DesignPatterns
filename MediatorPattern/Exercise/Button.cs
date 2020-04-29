using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
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
                Notify();
            }
        }


        public Button() : base()
        {

        }
    }
}
