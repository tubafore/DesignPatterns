using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class TextOperation : Operation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Retrieving heading text");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Retrieving anchor text");
        }
    }
}
