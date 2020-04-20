using System;
using System.Collections.Generic;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();

            RunLectureGuess();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            Console.WriteLine("Running My Guess -----------------------------------------");
            MyGuess.Canvas canvas = new MyGuess.Canvas();

            foreach (var value in Enum.GetValues(typeof(MyGuess.ToolType)))
            {
                Console.WriteLine($"Current tool type is {Enum.GetName(typeof(MyGuess.ToolType), value)}");
                canvas.CurrentTool = (MyGuess.ToolType)value;
                canvas.MouseDown();
                canvas.MouseUp();
            }
        }

        private static void RunLectureGuess()
        {
            Console.WriteLine("Running My Lecture-based Guess ---------------------------");
            GuessBasedOnLecture.Canvas canvas = new GuessBasedOnLecture.Canvas();

            List<GuessBasedOnLecture.ITool> tools = new List<GuessBasedOnLecture.ITool>
            {
                null,
                new GuessBasedOnLecture.BrushTool(),
                new GuessBasedOnLecture.SelectionTool(),
                new GuessBasedOnLecture.EraserTool()
            };

            foreach (var tool in tools)
            {
                Console.WriteLine($"Current tool type is { (tool != null ? tool.GetType().Name : "null")}");
                canvas.CurrentTool = tool;
                canvas.MouseDown();
                canvas.MouseUp();
            }
        }
    }
}
