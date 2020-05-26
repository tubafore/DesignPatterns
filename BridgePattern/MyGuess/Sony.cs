using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Sony : Manufacturer
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony - turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony - turn off");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Sony - setting channel to {channel}");
        }
    }
}
