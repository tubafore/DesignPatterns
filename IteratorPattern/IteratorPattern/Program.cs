using MyGuess;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.DoublyLinkedList<int> collection = new MyGuess.DoublyLinkedList<int>();

            Random random = new Random(5);
            for (int i = 0; i < 10; i++)
            {
                collection.Add(random.Next(0, 100));
            }

            Iterator<int> iterator = collection.GetIterator();

            for (int i = 0; i < iterator.Count; i++)
            {
                Console.WriteLine($"Item {i + 1}: {iterator.GetNextItem()}");
            }

            collection.InsertAt(5, random.Next(0, 100));
            iterator = collection.GetIterator();
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < iterator.Count; i++)
            {
                Console.WriteLine($"Item {i + 1}: {iterator.GetNextItem()}");
            }
        }
    }
}
