using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunGuessBasedOnLecture();
            RunTheirSolution();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.Button button = new MyGuess.Button();
            button.OnClick += Button_OnClick;
            button.Click();
        }

        private static void Button_OnClick(object owner, EventArgs arg)
        {
            Console.WriteLine("Button was clicked");
        }

        private static void RunGuessBasedOnLecture()
        {
            GuessBasedOnLecture.Button button = new GuessBasedOnLecture.Button(new GuessBasedOnLecture.ClickCommand());
            button.Click();
        }

        private static void RunTheirSolution()
        {
            TheirSolution.CustomerService service = new TheirSolution.CustomerService();
            TheirSolution.AddCustomerCommand command = new TheirSolution.AddCustomerCommand(service);
            TheirSolution.Button button = new TheirSolution.Button(command);
            button.Click();
        }
    }
}
