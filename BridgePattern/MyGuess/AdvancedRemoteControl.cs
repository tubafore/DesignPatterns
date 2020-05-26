using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Manufacturer manufacturer) : base(manufacturer)
        {

        }

        public void SetChannel(int channel)
        {
            manufacturer.SetChannel(channel);
        }
    }
}
