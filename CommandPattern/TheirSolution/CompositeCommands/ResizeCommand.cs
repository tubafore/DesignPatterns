using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.CompositeCommands
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resizing");
        }
    }
}
