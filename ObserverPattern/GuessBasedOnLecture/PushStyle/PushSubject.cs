using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PushStyle
{
    public abstract class PushSubject
    {
        private List<IPushObserver> observers;

        public PushSubject()
        {
            observers = new List<IPushObserver>();
        }

        public void AttachObserver(IPushObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IPushObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(int value)
        {
            foreach (IPushObserver o in observers)
            {
                o.Update(value);
            }
        }
    }
}
