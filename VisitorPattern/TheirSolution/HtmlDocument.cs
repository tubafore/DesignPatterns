using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class HtmlDocument
    {
        public List<HtmlNode> Children { get; private set; }

        public HtmlDocument()
        {
            Children = new List<HtmlNode>();
        }

        public void Add(HtmlNode node)
        {
            Children.Add(node);
        }

        public void Execute(Operation operation)
        {
            foreach (HtmlNode node in Children)
            {
                node.Execute(operation);
            }
        }
    }
}
