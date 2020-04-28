using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PullStyle
{
    public abstract class PullSubject
    {
        private List<IPullObserver> observers;

        public PullSubject()
        {
            observers = new List<IPullObserver>();
        }

        public void AttachObserver(IPullObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IPullObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IPullObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
