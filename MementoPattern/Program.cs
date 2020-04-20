using GuessBasedOnLecture;
using Homework;
using MySolution;
using System;
using TheirSolution;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWay();

            MyGuess();

            TheirWay();

            RunHomework();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void MyWay()
        {
            MySolution.Editor editor = new MySolution.Editor();

            Console.WriteLine($"Default editor state is {editor}");

            editor.Undo();

            Console.WriteLine($"After calling undo on an empty value, editor state is {editor}");
            editor.Content = "a";
            editor.Content = "b";
            editor.Content = "c";
            editor.Undo();

            Console.WriteLine($"After setting a few values, editor state is {editor}");
        }

        private static void MyGuess()
        {
            Originator originator = new Originator();
            Console.WriteLine($"Default originator state is {originator}");

            originator.Undo();
            Console.WriteLine($"After calling undo on an empty value, originator state is {originator}");

            originator.Content = "a";
            originator.Content = "b";
            originator.Content = "c";
            originator.Undo();
            originator.Undo();
            Console.WriteLine($"After setting a few values and undoing twice, originator state is {originator}");
            
            originator.Redo();
            Console.WriteLine($"After redoing once, originator state is {originator}");

            originator.Content = "d";
            originator.Redo();
            Console.WriteLine($"After redoing again, originator state is {originator}");
        }

        private static void TheirWay()
        {
            TheirSolution.Editor editor = new TheirSolution.Editor();
            History history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());
            editor.Content = "b";
            history.Push(editor.CreateState());
            editor.Content = "c";
            history.Push(editor.CreateState());

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);
        }

        private static void RunHomework()
        {
            Document d = new Document();
            d.FontSize = 14.0;
            d.FontName = "Times New Roman";
            d.Content = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo.";

            Console.WriteLine(d);
            d.Undo();
            Console.WriteLine(d);
            d.Undo();
            Console.WriteLine(d);
            d.Redo();
            Console.WriteLine(d);
            d.Redo();
            Console.WriteLine(d);
        }
    }
}
