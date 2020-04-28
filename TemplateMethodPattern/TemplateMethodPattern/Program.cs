using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunTheirSolution();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.AuditTrail auditTrail = new MyGuess.AuditTrail();
            MyGuess.BankingTask task = new MyGuess.TransferMoneyTask(auditTrail);
            MyGuess.BankingTask task2 = new MyGuess.GenerateReportTask(auditTrail);

            task.Execute();
            task2.Execute();
        }

        private static void RunTheirSolution()
        {
            MyGuess.AuditTrail auditTrail = new MyGuess.AuditTrail();
            MyGuess.BankingTask task = new MyGuess.TransferMoneyTask(auditTrail);
            MyGuess.BankingTask task2 = new MyGuess.GenerateReportTask(auditTrail);

            task.Execute();
            task2.Execute();
        }
    }
}
