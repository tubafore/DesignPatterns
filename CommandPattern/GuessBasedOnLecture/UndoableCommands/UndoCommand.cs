using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.UndoableCommands
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
            history.Pop().Unexecute();
        }
    }
}
