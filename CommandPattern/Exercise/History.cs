using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class History
    {
        private Stack<VideoEditorState> previous;

        public History()
        {
            previous = new Stack<VideoEditorState>();
        }

        public void Push(VideoEditorState state)
        {
            previous.Push(state);
        }

        public VideoEditorState Pop()
        {
            if (previous.Count > 0)
                return previous.Pop();
            return null;
        }

        public bool IsEmpty()
        {
            return previous.Count == 0;
        }
    }
}
