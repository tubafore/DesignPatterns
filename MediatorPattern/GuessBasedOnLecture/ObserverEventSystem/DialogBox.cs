using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public abstract class DialogBox
    {
        protected List<UIControl> controls;

        public DialogBox()
        {
            controls = new List<UIControl>();
        }

        public void AddControl(UIControl control)
        {
            controls.Add(control);
        }
    }
}
