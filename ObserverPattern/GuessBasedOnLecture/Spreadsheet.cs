using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class Spreadsheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Spreadsheet - Value changed");
        }
    }
}
