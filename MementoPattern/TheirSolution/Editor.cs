using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Editor
    {
        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; } 
        }

        public Editor()
        {

        }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState state)
        {
            content = state.Content;
        }
    }
}
