using System;

namespace AdapterPattern
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
            MyGuess.Image image = new MyGuess.Image();
            MyGuess.ImageView view = new MyGuess.ImageView(image);

            view.Apply(new MyGuess.VividFilter());
            view.Apply(new MyGuess.CaramelFilter(new MyGuess.AvaFilters.Caramel()));
        }

        private static void RunExercise()
        {
            Exercise.EmailClient client = new Exercise.EmailClient();
            client.AddProvider(new Exercise.GmailEmailProvider(new Exercise.Gmail.GmailClient()));
            client.DownloadEmails();
        }
    }
}
