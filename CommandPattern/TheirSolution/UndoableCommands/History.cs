using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.UndoableCommands
{
    public class History
    {
        private Stack<IUndoableCommand> commands;

        public History()
        {
            commands = new Stack<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command)
        {
            commands.Push(command);
        }

        public bool HasItems()
        {
            return commands.Count > 0;
        }

        public IUndoableCommand Pop()
        {
            return commands.Pop();
        }
    }
}
