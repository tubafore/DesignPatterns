using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    /// <summary>
    /// Doubly-linked list node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
