using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class HighlightOperation : Operation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Highlight heading");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Highlight anchor");
        }
    }
}
