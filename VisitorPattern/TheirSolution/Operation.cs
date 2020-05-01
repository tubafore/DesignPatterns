using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public interface Operation
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }
}
