using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.UndoableCommands
{
    public class BoldCommand : IUndoableCommand
    {
        private string previousDocument;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            previousDocument = document.Content;
            document.MakeBold();
            history.Push(this);
        }

        public void Unexecute()
        {
            document.Content = previousDocument;
        }
    }
}
