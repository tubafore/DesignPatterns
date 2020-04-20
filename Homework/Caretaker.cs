using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Caretaker
    {
        private List<Memento> states;
        private int index;

        public Caretaker()
        {
            states = new List<Memento>();
            index = -1;
        }

        private void Push(Memento state)
        {
            if (index >= 0 && index != states.Count - 1)
            {
                //Clear out the "redo" states
                states.RemoveRange(index, states.Count - index);
            }
            states.Add(state);
            index++;
        }

        private Memento Pop()
        {
            if (index < 0)
                return null;

            return states[--index];
        }

        public void SaveState(Memento memento)
        {
            Push(memento);
        }

        public Memento Undo()
        {
            return Pop();
        }

        public Memento Redo()
        {
            if (index + 1 < states.Count)
            {
                return states[++index];
            }
            return null;
        }
    }
}
