using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.WithObserverPattern
{
    public class ListBox : UIControl
    {
        public ListBox() : base()
        {
            Items = new List<string>();
        }

        public List<string> Items { get; private set; }

        private int selectedIndex;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set 
            { 
                selectedIndex = value;
                NotifyObservers();
            }
        }

        public string SelectedItem { get { return Items[selectedIndex]; } }

    }
}
