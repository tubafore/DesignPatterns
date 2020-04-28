using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public abstract class BankingTask
    {
        private AuditTrail auditTrail;

        public BankingTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record(this);

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
