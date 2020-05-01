using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class AnchorNode : HtmlNode
    {
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}
