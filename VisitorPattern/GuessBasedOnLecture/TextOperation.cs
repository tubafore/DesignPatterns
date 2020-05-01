using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class TextOperation : Operation
    {
        public override void Apply(AnchorHtmlNode node)
        {
            Console.WriteLine("Printing anchor text");
        }

        public override void Apply(HeadingHtmlNode node)
        {
            Console.WriteLine("Printing heading text");
        }
    }
}
