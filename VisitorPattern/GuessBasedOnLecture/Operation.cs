using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public abstract class Operation
    {
        public abstract void Apply(AnchorHtmlNode node);
        public abstract void Apply(HeadingHtmlNode node);
    }
}
