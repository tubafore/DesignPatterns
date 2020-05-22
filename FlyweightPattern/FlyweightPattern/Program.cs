using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunTheirSolution();
            RunExercise();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.PointService service = new MyGuess.PointService();
            service.GetPoints();
        }

        private static void RunTheirSolution()
        {
            TheirSolution.PointService service = new TheirSolution.PointService();
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }

        private static void RunExercise()
        {
            var sheet = new Exercise.SpreadSheet();
            sheet.SetContent(0, 0, "Hello");
            sheet.SetContent(1, 0, "World");
            sheet.SetFontFamily(0, 0, "Arial");
            sheet.Render();
        }
    }
}
