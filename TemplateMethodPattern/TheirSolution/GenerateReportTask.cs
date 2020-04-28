using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class GenerateReportTask : BankingTask
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generating Report");
        }
    }
}
