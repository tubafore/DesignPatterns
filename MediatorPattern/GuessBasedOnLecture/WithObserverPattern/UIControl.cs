using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.WithObserverPattern
{
    public abstract class UIControl
    {
        private List<Observer> observers;

        public UIControl()
        {
            observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update();
        }
    }
}
