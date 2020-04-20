using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public abstract class Collection<T>
    {
        public int Count { get; protected set; }

        public abstract Iterator<T> GetIterator();

    }
}
