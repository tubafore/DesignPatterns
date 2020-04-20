using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public interface IOriginator
    {
        public void LoadState(Memento memento);

        public IOriginator ShallowCopy();

        public void Undo();

        public void Redo();
        public void SaveState();
    }
}
