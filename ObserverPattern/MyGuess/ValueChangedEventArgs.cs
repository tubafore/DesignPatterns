using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class ValueChangedEventArgs : EventArgs
    {
        public int OldValue { get; set; }
        public int NewValue { get; set; }
    }
}
