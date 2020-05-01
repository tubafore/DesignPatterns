using System;
using System.Collections.Generic;

namespace GuessBasedOnLecture
{
    public abstract class HtmlNode
    {
        public HtmlNode Parent { get; set; }
        public List<HtmlNode> Children { get; set; }
        public string Text { get; set; }

        public HtmlNode()
        {
            Children = new List<HtmlNode>();
        }

        public HtmlNode(HtmlNode parent) : this()
        {
            this.Parent = parent;
            if (parent != null)
                parent.Children.Add(this);
        }

        public abstract void Execute(Operation operation);
    }
}
