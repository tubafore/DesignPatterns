using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunGuessBasedOnLecture();
            RunPushStyle();
            RunPullStyle();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.DataSource source = new MyGuess.DataSource();
            MyGuess.Chart chart = new MyGuess.Chart();
            MyGuess.SpreadSheet spreadSheet = new MyGuess.SpreadSheet();

            source.OnValueChanged += chart.ReportValueChanged;
            source.OnValueChanged += spreadSheet.ReportValueChanged;

            source.Value = 17;
            source.Value = 3;
        }

        private static void RunGuessBasedOnLecture()
        {
            GuessBasedOnLecture.DataSource source = new GuessBasedOnLecture.DataSource();
            GuessBasedOnLecture.Spreadsheet spreadsheet = new GuessBasedOnLecture.Spreadsheet();
            GuessBasedOnLecture.Chart chart = new GuessBasedOnLecture.Chart();
            source.AttachObserver(spreadsheet);
            source.AttachObserver(chart);
            source.Value = 17;
            source.Value = 3;
        }

        private static void RunPushStyle()
        { 
            GuessBasedOnLecture.PushStyle.PushDataSource source = new GuessBasedOnLecture.PushStyle.PushDataSource();
            GuessBasedOnLecture.PushStyle.PushSpreadSheet spreadsheet = new GuessBasedOnLecture.PushStyle.PushSpreadSheet();
            GuessBasedOnLecture.PushStyle.PushChart chart = new GuessBasedOnLecture.PushStyle.PushChart();
            source.AttachObserver(spreadsheet);
            source.AttachObserver(chart);
            source.Value = 17;
            source.Value = 3;
            
        }

        private static void RunPullStyle()
        {
            GuessBasedOnLecture.PullStyle.PullDataSource source = new GuessBasedOnLecture.PullStyle.PullDataSource();
            GuessBasedOnLecture.PullStyle.PullSpreadSheet spreadsheet = new GuessBasedOnLecture.PullStyle.PullSpreadSheet(source);
            GuessBasedOnLecture.PullStyle.PullChart chart = new GuessBasedOnLecture.PullStyle.PullChart(source);
            source.AttachObserver(spreadsheet);
            source.AttachObserver(chart);
            source.Value = 17;
            source.Value = 3;

        }
    }
}
