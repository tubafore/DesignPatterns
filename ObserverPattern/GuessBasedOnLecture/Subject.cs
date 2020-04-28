using System;
using System.Collections.Generic;

namespace GuessBasedOnLecture
{
    public abstract class Subject
    {
        private List<IObserver> observers;

        public Subject()
        {
            observers = new List<IObserver>();
        }

        public void AttachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
