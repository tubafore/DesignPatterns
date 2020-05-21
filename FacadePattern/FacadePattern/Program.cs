using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunExercise();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.NotificationService service = new MyGuess.NotificationService();
            service.SendMessage("Hello World", "192.168.1.1");
        }

        private static void RunExercise()
        {
            Exercise.TwitterService service = new Exercise.TwitterService("appKey", "appSecret");
            service.GetLatestTweets();
        }
    }
}
