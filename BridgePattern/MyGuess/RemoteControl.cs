using System;

namespace MyGuess
{
    public class RemoteControl
    {
        protected Manufacturer manufacturer;

        public RemoteControl(Manufacturer manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void TurnOn()
        {
            manufacturer.TurnOn();
        }

        public void TurnOff()
        {
            manufacturer.TurnOff();
        }
    }
}
