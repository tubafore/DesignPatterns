using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class ListBox : UIControl
    {
        public List<string> Items { get; set; }

        public string Selection { get; private set; }

        public ListBox(DialogBox dialogBox) : base(dialogBox)
        {
            Items = new List<string>();
        }

        public void Select(int index)
        {
            if (index < Items.Count && index >= 0)
            {
                Selection = Items[index];
                Parent.Changed(this);
            }
        }
    }
}
