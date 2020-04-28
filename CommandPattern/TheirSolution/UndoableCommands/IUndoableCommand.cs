using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.UndoableCommands
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
