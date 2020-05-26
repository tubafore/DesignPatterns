using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public interface Manufacturer
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
}
