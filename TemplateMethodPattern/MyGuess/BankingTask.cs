using System;

namespace MyGuess
{
    public abstract class BankingTask
    {
        protected AuditTrail auditTrail;

        public BankingTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public virtual void Execute()
        {
            auditTrail.Record(this);
        }
    }
}
