using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class Originator
    {
        private string content; 

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                CaretakerManager.Instance[this].SaveState(new Memento(this));
            }
        }

        public Originator()
        {
            CaretakerManager.Instance[this] = new Caretaker();
        }

        private void LoadState(Memento memento)
        {
            content = memento.Content;
        }

        public Originator ShallowCopy()
        {
            return (Originator)this.MemberwiseClone();
        }

        public void Undo()
        {
            Memento m = CaretakerManager.Instance[this].Undo();
            if (m != null)
            {
                LoadState(m);
            }
        }

        public void Redo()
        {
            Memento m = CaretakerManager.Instance[this].Redo();
            if (m != null)
            {
                LoadState(m);
            }
        }

        public override string ToString()
        {
            return content;
        }
    }
}
