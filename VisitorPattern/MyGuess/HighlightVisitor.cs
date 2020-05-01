using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class HighlightVisitor : Visitor
    {
        public override void ProcessAnchor(AnchorHtmlNode node)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("a");
            Console.ResetColor();
        }

        public override void ProcessHeading(HeadingHtmlNode node)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("head");
            Console.ResetColor();
        }
    }
}
