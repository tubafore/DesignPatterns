using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public class ValueChangedEventArgs : EventArgs
    {
        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
}
