using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.UndoableCommands
{
    public class Document
    {
        public string Content { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        public Document()
        {
            ForegroundColor = Console.ForegroundColor;
            BackgroundColor = Console.BackgroundColor;
        }

        public void PrintToConsole()
        {
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.WriteLine(Content);
        }
    }
}
