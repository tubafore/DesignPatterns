using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class HeadingNode : HtmlNode
    {
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}
