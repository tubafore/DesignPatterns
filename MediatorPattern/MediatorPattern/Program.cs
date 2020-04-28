using System;

namespace MediatorPattern
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
            MyGuess.ArticleDialogBox dialogBox = new MyGuess.ArticleDialogBox();
            dialogBox.ArticlesListBox.Items.Add("Interesting Title");
            dialogBox.ArticlesListBox.Items.Add("Uninteresting blurb");
            dialogBox.ArticlesListBox.Items.Add("Amusing Anecdote");
            dialogBox.ArticlesListBox.Select(2);
            
        }
    }
}
