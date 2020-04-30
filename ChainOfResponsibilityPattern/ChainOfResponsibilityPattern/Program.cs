using System;

namespace ChainOfResponsibilityPattern
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
            MyGuess.Handler pipeline = new MyGuess.Authenticator();
            pipeline.Next = new MyGuess.Compressor();
            pipeline.Next.Next = new MyGuess.Logger();

            MyGuess.WebServer webServer = new MyGuess.WebServer(pipeline);
            MyGuess.HttpRequest request = new MyGuess.HttpRequest { UserName = "Dave", Password = "LetMeIn" };

            webServer.Handle(request);
            request.UserName = "Admin";
            webServer.Handle(request);
            request.Password = "1234";
            webServer.Handle(request);
        }

        private static void RunTheirSolution()
        {
            TheirSolution.Compressor compressor = new TheirSolution.Compressor(null);
            TheirSolution.Logger logger = new TheirSolution.Logger(compressor);
            TheirSolution.Authenticator authenticator = new TheirSolution.Authenticator(logger);

            TheirSolution.WebServer webServer = new TheirSolution.WebServer(authenticator);
            TheirSolution.HttpRequest request = new TheirSolution.HttpRequest { UserName = "Dave", Password = "LetMeIn" };

            webServer.Handle(request);
            request.UserName = "Admin";
            webServer.Handle(request);
            request.Password = "1234";
            webServer.Handle(request);
        }

        private static void RunExercise()
        {
            Exercise.QuickBooksDataReader quick = new Exercise.QuickBooksDataReader(null);
            Exercise.NumbersDataReader numbers = new Exercise.NumbersDataReader(quick);
            Exercise.ExcelDataReader excel = new Exercise.ExcelDataReader(numbers);

            excel.Read(@"C:\temp\book.txt");
            excel.Read(@"C:\temp\book.xls");
            excel.Read(@"C:\temp\book.numbers");
            excel.Read(@"C:\temp\book.qbw");
        }
    }
}
