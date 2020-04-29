using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public class Button : UIControl
    {
        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                ValueChangedEventArgs args = new ValueChangedEventArgs { NewValue = value, OldValue = enabled };
                enabled = value; 
                if (OnValueChanged != null)
                {
                    OnValueChanged.Invoke(this, args);
                }
            }
        }


        public event OnValueChangedHandler OnValueChanged;
    }
}
