using System;

namespace MyGuess
{
    /// <summary>
    /// Adding this just to implement my own collection of objects.
    /// 
    /// Gonna do a doubly-linked list, not that System.Collections.Generic doesn't have one.
    /// 
    /// I just wanted to make sure Linq wouldn't help me.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T> : Collection<T>
    {
        public Node<T> Head { get; set; }

        public DoublyLinkedList()
        {

        }

        public void Add(T item)
        {
            Node<T> current = GetTail();
            Node<T> newNode = new Node<T> { Value = item };
            
            newNode.Previous = current;
            if (current == null)
            {
                Head = newNode;
            }
            else
            {
                current.Next = newNode;
            }

            Count++;
        }

        public void InsertAt(int index, T item)
        {
            if (index > Count)
                throw new IndexOutOfRangeException();

            Node<T> current = GetNodeAt(index);
            Node<T> previous = current.Previous;

            Node<T> newNode = new Node<T> { Value = item };
            if (previous != null)
            {
                previous.Next = newNode;
            }
            newNode.Previous = previous;
            newNode.Next = current;
            if (current != null)
            {
                current.Previous = newNode;
            }
            Count++;
        }

        private Node<T> GetTail()
        {
            Node<T> current = Head;

            while (current != null && current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        private Node<T> GetNodeAt(int index)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();
            
            Node<T> current = Head;

            if (Count == 0)
                return current;

            
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            return current;
            
            throw new IndexOutOfRangeException();
        }

        public T GetItemAt(int index)
        {
            return GetNodeAt(index).Value;
        }

        public override Iterator<T> GetIterator()
        {
            Iterator<T> results = new Iterator<T>(Count);
            Node<T> current = Head;
            if (current != null)
            {
                while (current != null)
                {
                    results.AddItem(current.Value);
                    current = current.Next;
                }
            }
            return results;
        }
    }
}
