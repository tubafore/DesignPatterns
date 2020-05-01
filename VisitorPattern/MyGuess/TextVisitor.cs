using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class TextVisitor : Visitor
    {
        public override void ProcessAnchor(AnchorHtmlNode node)
        {
            Console.WriteLine("Printing anchor text");
        }

        public override void ProcessHeading(HeadingHtmlNode node)
        {
            Console.WriteLine("Printing heading text");
        }
    }
}
