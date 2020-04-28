using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PushStyle
{
    public interface IPushObserver
    {
        void Update(int value);
    }
}
