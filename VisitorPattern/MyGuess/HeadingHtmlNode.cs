using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class HeadingHtmlNode : HtmlNode
    {
        public HeadingHtmlNode() : base()
        {

        }

        public HeadingHtmlNode(HtmlNode parent) : base(parent)
        {

        }

        public override void Accept(Visitor visitor)
        {
            visitor.ProcessHeading(this);
        }
    }
}
