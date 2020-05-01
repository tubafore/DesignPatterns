using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ReduceNoiseOperation : Operation
    {
        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Reducing noise on Fact Segment");
        }

        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Reducing noise on Format Segment");
        }
    }
}
