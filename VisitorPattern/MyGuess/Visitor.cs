using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public abstract class Visitor
    {
        public void VisitNode(HtmlNode node)
        {
            node.Accept(this);
        }

        public abstract void ProcessAnchor(AnchorHtmlNode node);
        public abstract void ProcessHeading(HeadingHtmlNode node);
    }
}
