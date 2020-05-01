using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class AnchorHtmlNode : HtmlNode
    {
        public AnchorHtmlNode() : base()
        {

        }

        public AnchorHtmlNode(HtmlNode parent) : base(parent)
        {

        }

        public override void Accept(Visitor visitor)
        {
            visitor.ProcessAnchor(this);
        }
    }
}
