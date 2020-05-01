using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class HeadingHtmlNode : HtmlNode
    {
        public HeadingHtmlNode() : base()
        {

        }

        public HeadingHtmlNode(HtmlNode parent) : base(parent)
        {

        }

        public override void Execute(Operation visitor)
        {
            visitor.Apply(this);
        }
    }
}
