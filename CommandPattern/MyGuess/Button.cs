using System;

namespace MyGuess
{
    public class Button
    {
        public string Label { get; set; }

        public event ClickHandler OnClick;

        public void Click()
        {
            if (OnClick != null)
                OnClick.Invoke(this, EventArgs.Empty);
        }
    }
}
