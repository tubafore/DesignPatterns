using System;

namespace MySolution
{
    public class Editor
    {
        private Memento<string> content;

        public string Content
        {
            get
            {
                return content.Value;
            }
            set
            {
                content.Value = value;
            }
        }

        public Editor()
        {
            content = new Memento<string>();
        }

        public void Undo()
        {
            content.Undo();
        }

        public override string ToString()
        {
            return content.ToString();
        }
    }
}
