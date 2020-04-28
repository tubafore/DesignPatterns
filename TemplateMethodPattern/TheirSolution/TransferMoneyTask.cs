using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class TransferMoneyTask : BankingTask
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Transfering Money");
        }
    }
}
