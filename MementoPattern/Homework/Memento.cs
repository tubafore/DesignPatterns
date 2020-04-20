using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Memento
    {
        public IOriginator Content { get; private set; }

        public Memento(IOriginator originator)
        {
            Content = originator.ShallowCopy();
        }
    }
}
