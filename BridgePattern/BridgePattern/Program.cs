using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.RemoteControl[] remoteControls = new MyGuess.RemoteControl[]
            {
                new MyGuess.RemoteControl(new MyGuess.Sony()),
                new MyGuess.RemoteControl(new MyGuess.Samsung()),
                new MyGuess.AdvancedRemoteControl(new MyGuess.Sony()),
                new MyGuess.AdvancedRemoteControl(new MyGuess.Samsung())
            };

            remoteControls[0].TurnOn();
            remoteControls[1].TurnOff();
            ((MyGuess.AdvancedRemoteControl)remoteControls[2]).SetChannel(4);
            ((MyGuess.AdvancedRemoteControl)remoteControls[3]).SetChannel(7);
        }
    }
}
