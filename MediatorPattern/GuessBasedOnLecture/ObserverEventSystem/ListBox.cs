using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public class ListBox : UIControl
    {
        private List<string> items;
        public List<string> Items 
        {
            get { return items; }
            private set { items = value; } 
        }

        public string SelectedItem { get; private set; }


        private int selectedIndex;
        public int SelectedIndex
        {
            get
            { 
                return selectedIndex; 
            }
            set
            {
                if (value < 0 || value >= items.Count)
                    throw new IndexOutOfRangeException();

                ValueChangedEventArgs args = new ValueChangedEventArgs { OldValue = SelectedItem, NewValue = Items[value] };
                selectedIndex = value;
                SelectedItem = items[selectedIndex]; 
                if (OnValueChanged != null)
                {
                    OnValueChanged.Invoke(this, args);
                }
            }
        }

        public event OnValueChangedHandler OnValueChanged;

        public ListBox()
        {
            Items = new List<string>();
        }
    }
}
