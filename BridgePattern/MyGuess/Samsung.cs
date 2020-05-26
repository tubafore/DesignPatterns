using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Samsung : Manufacturer
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung - turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung - turn off");
        }
        public void SetChannel(int channel)
        {
            Console.WriteLine($"Samsung - setting channel to {channel}");
        }

    }
}
