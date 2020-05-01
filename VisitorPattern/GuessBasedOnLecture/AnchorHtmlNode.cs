using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class AnchorHtmlNode : HtmlNode
    {
        public AnchorHtmlNode() : base()
        {

        }

        public AnchorHtmlNode(HtmlNode parent) : base(parent)
        {

        }

        public override void Execute(Operation visitor)
        {
            visitor.Apply(this);
        }
    }
}
