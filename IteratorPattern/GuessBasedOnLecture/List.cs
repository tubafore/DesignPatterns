using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class List<T>
    {
        private T[] collection;
        private int maxSize = 10;

        public int Count { get; private set; }

        public List()
        {
            Count = 0;
            collection = new T[maxSize];
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException();
                return collection[index];
            }
            set
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException();
                collection[index] = value;
            }
        }

        public T GetItemAt(int index)
        {
            if (index >= Count || index < 0)
                throw new IndexOutOfRangeException();
            return collection[index];
        }

        public void SetItemAt(int index, T value)
        {
            if (index >= Count || index < 0)
                throw new IndexOutOfRangeException();
            collection[index] = value;
        }

        public void Add(T value)
        {
            if (Count == maxSize - 1)
                IncreaseSize();
            collection[Count++] = value;
        }

        private void IncreaseSize()
        {
            T[] differentCollection = new T[maxSize * 2];
            Array.Copy(collection, differentCollection, maxSize);
            maxSize *= 2;
            collection = differentCollection;
        }

        public IIterator<T> GetIterator()
        {
            ListIterator<T> iterator = new ListIterator<T>(this);
            return iterator;
        }
    }
}
