using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.UndoableCommands
{
    public interface IUndoableCommand
    {
        void Unexecute();
    }
}
