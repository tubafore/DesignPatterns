using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.UndoableCommands
{
    public class History
    {
        private Stack<IUndoableCommand> commands;

        public History()
        {
            commands = new Stack<IUndoableCommand>();
        }

        public void Push(IUndoableCommand state)
        {
            commands.Push(state);
        }

        public IUndoableCommand Pop()
        {
            return commands.Pop();
        }
    }
}
