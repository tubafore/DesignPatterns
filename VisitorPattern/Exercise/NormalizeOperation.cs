using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class NormalizeOperation : Operation
    {
        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Normalizing Fact Segment");
        }

        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Normalizing Format Segment");
        }
    }
}
