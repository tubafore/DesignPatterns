using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.UndoableCommands
{
    public class UndoCommand : ICommand
    {
        private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.HasItems())
                history.Pop().Unexecute();
        }
    }
}
