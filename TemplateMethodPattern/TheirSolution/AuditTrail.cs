using System;

namespace TheirSolution
{
    public class AuditTrail
    {
        public void Record(BankingTask task)
        {
            Console.WriteLine($"Recording {task.GetType().Name} at {DateTime.Now}");
        }
    }
}
