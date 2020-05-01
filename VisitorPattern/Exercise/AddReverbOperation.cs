using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class AddReverbOperation : Operation
    {
        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Adding reverb to Fact Segment");
        }

        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Adding reverb to Format Segment");
        }
    }
}
