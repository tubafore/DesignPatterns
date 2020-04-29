using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.WithObserverPattern
{
    public class Button : UIControl
    {
        public Button() : base()
        {

        }

        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set
            { 
                enabled = value;
                NotifyObservers();
            }
        }

    }
}
