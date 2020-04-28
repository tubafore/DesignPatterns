using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.UndoableCommands
{
    public class BoldCommand : ICommand, IUndoableCommand
    {
        private ConsoleColor previousForegroundColor, previousBackgroundColor;
        private Document document;

        public BoldCommand(Document document)
        {
            this.document = document;
        }
        
        public void Execute()
        {
            previousBackgroundColor = document.BackgroundColor;
            previousForegroundColor = document.ForegroundColor;
            document.ForegroundColor = ConsoleColor.White;
            document.BackgroundColor = ConsoleColor.Blue;
        }

        public void Unexecute()
        {
            document.ForegroundColor = previousForegroundColor;
            document.BackgroundColor = previousBackgroundColor;
        }
    }
}
