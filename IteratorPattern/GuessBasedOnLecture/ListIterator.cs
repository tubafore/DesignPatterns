using System;
using System.Text;

namespace GuessBasedOnLecture
{
    public class ListIterator<T> : IIterator<T>
    {
        private int index;
        private List<T> collection;

        public ListIterator(List<T> collection)
        {
            this.collection = collection;
            index = 0;
        }

        public T Current()
        {
            return collection[index];
        }

        public bool Done()
        {
            return (index >= collection.Count);
        }

        public void Next()
        {
            if (index == collection.Count)
                return;
            index++;
        }
    }
}
