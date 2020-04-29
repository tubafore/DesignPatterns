using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.WithObserverPattern
{
    public abstract class UIControl
    {
        private List<EventHandler> observers;

        public UIControl()
        {
            observers = new List<EventHandler>();
        }

        public void Attach(EventHandler observer)
        {
            observers.Add(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Invoke();
        }
    }
}
