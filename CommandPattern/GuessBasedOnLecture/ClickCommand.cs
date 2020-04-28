using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class ClickCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Click executed");
        }
    }
}
