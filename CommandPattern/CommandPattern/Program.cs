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
            RunCompositeCommands();
            RunUndoCommand();
            RunTheirUndoCommand();
            RunExercise();

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

        private static void RunCompositeCommands()
        {
            TheirSolution.CustomerService service = new TheirSolution.CustomerService();
            TheirSolution.CompositeCommands.CompositeCommand cCommand = new TheirSolution.CompositeCommands.CompositeCommand();
            cCommand.Add(new TheirSolution.CompositeCommands.ResizeCommand());
            cCommand.Add(new TheirSolution.CompositeCommands.CropCommand());
            TheirSolution.Button button = new TheirSolution.Button(cCommand);
            button.Click();
        }

        private static void RunUndoCommand()
        {
            GuessBasedOnLecture.UndoableCommands.Document document = new GuessBasedOnLecture.UndoableCommands.Document();
            GuessBasedOnLecture.UndoableCommands.History history = new GuessBasedOnLecture.UndoableCommands.History();
            GuessBasedOnLecture.UndoableCommands.BoldCommand bold = new GuessBasedOnLecture.UndoableCommands.BoldCommand(document);
            GuessBasedOnLecture.Button button = new GuessBasedOnLecture.Button(bold);
            GuessBasedOnLecture.UndoableCommands.UndoCommand undo = new GuessBasedOnLecture.UndoableCommands.UndoCommand(history);
            GuessBasedOnLecture.Button undoButton = new GuessBasedOnLecture.Button(undo);

            document.Content = "Something pretty to look at while testing.";
            document.PrintToConsole();
            button.Click();
            history.Push(bold);
            document.PrintToConsole();
            undoButton.Click();
            document.PrintToConsole();
        }

        private static void RunTheirUndoCommand()
        {
            TheirSolution.UndoableCommands.History history = new TheirSolution.UndoableCommands.History();
            TheirSolution.UndoableCommands.HtmlDocument document = new TheirSolution.UndoableCommands.HtmlDocument { Content = "Hello World!" };

            TheirSolution.UndoableCommands.BoldCommand boldCommand = new TheirSolution.UndoableCommands.BoldCommand(document, history);
            TheirSolution.UndoableCommands.UndoCommand undoCommand = new TheirSolution.UndoableCommands.UndoCommand(history);
            boldCommand.Execute();
            Console.WriteLine(document.Content);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
        }

        private static void RunExercise()
        {
            Exercise.VideoEditor videoEditor = new Exercise.VideoEditor();
            Exercise.History history = new Exercise.History();

            history.Push(videoEditor.CreateState());
            videoEditor.Contrast = 0.6f;
            Console.WriteLine(videoEditor);

            history.Push(videoEditor.CreateState());
            videoEditor.Text = "Super Label!";
            Console.WriteLine(videoEditor);

            videoEditor.LoadState(history.Pop());
            Console.WriteLine(videoEditor);
        }
    }
}
