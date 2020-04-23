using System;

namespace TheirSolution
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
