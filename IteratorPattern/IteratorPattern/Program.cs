using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();

            RunLectureGuess();

            RunTheirSolution();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            Console.WriteLine("My guess");
            MyGuess.DoublyLinkedList<int> collection = new MyGuess.DoublyLinkedList<int>();

            Random random = new Random(5);
            for (int i = 0; i < 10; i++)
            {
                collection.Add(random.Next(0, 100));
            }

            MyGuess.Iterator<int> iterator = collection.GetIterator();

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

        private static void RunLectureGuess()
        {
            Console.WriteLine("Lecture guess");
            GuessBasedOnLecture.List<int> collection = new GuessBasedOnLecture.List<int>();

            Random random = new Random(5);
            for (int j = 0; j < 10; j++)
            {
                collection.Add(random.Next(0, 100));
            }

            GuessBasedOnLecture.IIterator<int> iterator = collection.GetIterator();

            int i = 0;
            while (!iterator.Done())
            {
                Console.WriteLine($"Item {i++ + 1}: {iterator.Current()}");
                iterator.Next();
            }
        }

        private static void RunTheirSolution()
        {
            Console.WriteLine("Their solution");
            TheirSolution.BrowseHistory history = new TheirSolution.BrowseHistory();

            Random random = new Random(5);
            for (int j = 0; j < 10; j++)
            {
                history.Push($"{random.Next(0, 100)}");
            }

            TheirSolution.IIterator<string> iterator = history.GetIterator();

            int i = 0;
            while (iterator.HasNext())
            {
                Console.WriteLine($"Item {i++ + 1}: {iterator.Current()}");
                iterator.Next();
            }
        }
    }
}
