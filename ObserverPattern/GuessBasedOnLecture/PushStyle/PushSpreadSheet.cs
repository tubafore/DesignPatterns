using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PushStyle
{
    public class PushSpreadSheet : IPushObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"PushSpreadsheet detected a change to {value}");
        }
    }
}
