using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public class TextBox : UIControl
    {
        private string content;

        public string Content
        {
            get { return content; }
            set
            {
                ValueChangedEventArgs args = new ValueChangedEventArgs { NewValue = value, OldValue = content };
                content = value; 
                if (OnValueChanged != null)
                {
                    OnValueChanged.Invoke(this, args);
                }
            }
        }


        public event OnValueChangedHandler OnValueChanged;
    }
}
