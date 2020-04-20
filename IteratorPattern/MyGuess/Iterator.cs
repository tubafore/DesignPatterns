using System;
using System.Text;

namespace MyGuess
{
    public class Iterator<T>
    {
        private T[] items;
        private int insertIndex;
        private int iteratorIndex;

        public int Count { get; private set; }

        public Iterator(int count)
        {
            Count = count;
            items = new T[Count];
        }

        public void AddItem(T item)
        {
            if (insertIndex < items.Length)
                items[insertIndex++] = item;
        }

        public T GetNextItem()
        {
            return items[iteratorIndex++];
        }

        public T GetPreviousItem()
        {
            return items[iteratorIndex--];
        }

        public void ResetIndex()
        {
            iteratorIndex = 0;
        }
    }
}
