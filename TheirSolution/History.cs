using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class History
    {
        private List<EditorState> states;

        public History()
        {
            states = new List<EditorState>();
        }

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            int lastIndex = states.Count - 1;
            EditorState state = states[lastIndex - 1];
            states.RemoveAt(lastIndex);
            return state;
        }
    }
}
