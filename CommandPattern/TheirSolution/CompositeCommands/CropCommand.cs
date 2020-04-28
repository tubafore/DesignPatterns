using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.CompositeCommands
{
    public class CropCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Cropping");
        }
    }
}
