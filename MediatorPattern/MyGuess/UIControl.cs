using System;

namespace MyGuess
{
    public class UIControl
    {
        protected readonly DialogBox Parent;

        public UIControl(DialogBox dialogBox)
        {
            Parent = dialogBox;
        }
    }
}
