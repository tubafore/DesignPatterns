using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class GenerateReportTask : BankingTask
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Generating Report");
        }
    }
}
