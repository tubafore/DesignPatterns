using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart - value changed");
        }
    }
}
