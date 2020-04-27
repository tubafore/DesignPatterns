using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.CompositeCommands
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> commands;

        public CompositeCommand()
        {
            commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach(ICommand command in commands)
            {
                command.Execute();
            }
        }
    }
}
