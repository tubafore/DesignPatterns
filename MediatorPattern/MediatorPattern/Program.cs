using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunGuessBasedOnLectureObserver();
            RunTheirSolution();
            RunExercise();

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

        private static void RunGuessBasedOnLectureObserver()
        {
            GuessBasedOnLecture.ObserverEventSystem.ArticlesDialogBox dialogBox = new GuessBasedOnLecture.ObserverEventSystem.ArticlesDialogBox();
            dialogBox.ListBox.Items.Add("Interesting Title");
            dialogBox.ListBox.Items.Add("Uninteresting blurb");
            dialogBox.ListBox.Items.Add("Amusing Anecdote");
            dialogBox.ListBox.SelectedIndex = 2;

        }

        private static void RunTheirSolution()
        {
            TheirSolution.WithObserverPattern.ArticlesDialogBox dialogBox = new TheirSolution.WithObserverPattern.ArticlesDialogBox();
            dialogBox.ArticlesListBox.Items.Add("Interesting Title");
            dialogBox.ArticlesListBox.Items.Add("Uninteresting blurb");
            dialogBox.ArticlesListBox.Items.Add("Amusing Anecdote");
            dialogBox.ArticlesListBox.SelectedIndex = 2;
        }

        private static void RunExercise()
        {
            Exercise.SignupDialogBox dlg = new Exercise.SignupDialogBox();
            dlg.UserNameTextBox.Content = "a good username";
            dlg.PasswordTextBox.Content = "a strong password";
            dlg.TermsCheckBox.Checked = true;
        }
    }
}
