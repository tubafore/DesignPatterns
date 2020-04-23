using System;

namespace GuessBasedOnLecture
{
    public interface IIterator<T>
    {
        T Current();
        void Next();
        bool Done();
    }
}
