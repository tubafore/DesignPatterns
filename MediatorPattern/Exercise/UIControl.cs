using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public abstract class UIControl
    {
        private List<EventHandler> eventHandlers;

        public UIControl()
        {
            eventHandlers = new List<EventHandler>();
        }

        public void AddEventHandler(EventHandler eventHandler)
        {
            eventHandlers.Add(eventHandler);
        }

        protected void Notify()
        {
            foreach (var handler in eventHandlers)
            {
                handler.Invoke();
            }
        }
    }
}
