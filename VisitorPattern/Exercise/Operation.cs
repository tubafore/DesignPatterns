using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public interface Operation
    {
        void Apply(FactSegment segment);
        void Apply(FormatSegment segment);
    }
}
