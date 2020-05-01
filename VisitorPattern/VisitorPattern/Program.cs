using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunGuessBasedOnLecture();
            RunTheirSolution();
            RunExercise();

            Console.WriteLine("Press any key to quit..");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.HtmlDocument document = new MyGuess.HtmlDocument();
            MyGuess.HeadingHtmlNode heading = new MyGuess.HeadingHtmlNode();
            MyGuess.AnchorHtmlNode anchor = new MyGuess.AnchorHtmlNode(heading);
            document.Root = heading;

            MyGuess.HighlightVisitor highlightVisitor = new MyGuess.HighlightVisitor();
            MyGuess.TextVisitor textVisitor = new MyGuess.TextVisitor();
            MyGuessRecursiveVisit(highlightVisitor, document.Root);
            MyGuessRecursiveVisit(textVisitor, document.Root);
        }

        private static void MyGuessRecursiveVisit(MyGuess.Visitor visitor, MyGuess.HtmlNode node)
        {
            if (node != null)
                visitor.VisitNode(node);

            foreach (var child in node.Children)
                MyGuessRecursiveVisit(visitor, child);
        }

        private static void RunGuessBasedOnLecture()
        {
            GuessBasedOnLecture.HtmlDocument document = new GuessBasedOnLecture.HtmlDocument();
            GuessBasedOnLecture.HeadingHtmlNode heading = new GuessBasedOnLecture.HeadingHtmlNode();
            GuessBasedOnLecture.AnchorHtmlNode anchor = new GuessBasedOnLecture.AnchorHtmlNode(heading);
            document.Root = heading;

            GuessBasedOnLecture.HighlightOperation highlightOperation = new GuessBasedOnLecture.HighlightOperation();
            GuessBasedOnLecture.TextOperation textOperation = new GuessBasedOnLecture.TextOperation();
            GuessBaseOnLectureRecursiveVisit(highlightOperation, document.Root);
            GuessBaseOnLectureRecursiveVisit(textOperation, document.Root);
        }

        private static void GuessBaseOnLectureRecursiveVisit(GuessBasedOnLecture.Operation operation, GuessBasedOnLecture.HtmlNode node)
        {
            if (node != null)
                node.Execute(operation);

            foreach (var child in node.Children)
                GuessBaseOnLectureRecursiveVisit(operation, child);
        }

        private static void RunTheirSolution()
        {
            TheirSolution.HtmlDocument document = new TheirSolution.HtmlDocument();
            document.Add(new TheirSolution.HeadingNode());
            document.Add(new TheirSolution.AnchorNode());

            TheirSolution.Operation highlight = new TheirSolution.HighlightOperation();
            TheirSolution.Operation text = new TheirSolution.TextOperation();

            document.Execute(highlight);
            document.Execute(text);
        }

        private static void RunExercise()
        {
            Exercise.WavFile wavFile = Exercise.WavFile.Read(@"C:\temp\Awesome.wav");
            wavFile.Execute(new Exercise.AddReverbOperation());
            wavFile.Execute(new Exercise.ReduceNoiseOperation());
            wavFile.Execute(new Exercise.NormalizeOperation());
        }
    }
}
