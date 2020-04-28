using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class TransferMoneyTask : BankingTask
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Transfering Money");
        }
    }
}
