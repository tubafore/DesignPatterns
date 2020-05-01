using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class FactSegment : Segment
    {
        public override void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}
