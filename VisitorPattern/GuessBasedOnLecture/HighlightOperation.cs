using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class HighlightOperation : Operation
    {
        public override void Apply(AnchorHtmlNode node)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("a");
            Console.ResetColor();
        }

        public override void Apply(HeadingHtmlNode node)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("head");
            Console.ResetColor();
        }
    }
}
