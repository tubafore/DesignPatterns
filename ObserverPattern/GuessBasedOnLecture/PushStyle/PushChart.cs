using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PushStyle
{
    public class PushChart : IPushObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"PushChart detected a change to {value}");
        }
    }
}
