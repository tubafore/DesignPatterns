using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public interface UIControl
    {
        event OnValueChangedHandler OnValueChanged;
    }
}
