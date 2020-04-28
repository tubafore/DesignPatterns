using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class AuditTrail
    {
        public void Record(BankingTask task)
        {
            Console.WriteLine($"Recording {task.GetType().Name} at {DateTime.Now}");
        }
    }
}
