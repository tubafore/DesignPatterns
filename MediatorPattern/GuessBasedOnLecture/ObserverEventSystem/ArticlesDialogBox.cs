using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.ObserverEventSystem
{
    public class ArticlesDialogBox : DialogBox
    {
        public Button Button { get; private set; }
        public TextBox TextBox { get; private set; }
        public ListBox ListBox { get; private set; }

        public ArticlesDialogBox() : base()
        {
            Button = new Button();
            Button.OnValueChanged += ArticlesDialogBox_OnValueChanged;

            TextBox = new TextBox();
            TextBox.OnValueChanged += TextBox_OnValueChanged;

            ListBox = new ListBox();
            ListBox.OnValueChanged += ListBox_OnValueChanged;


        }

        private void ListBox_OnValueChanged(object sender, ValueChangedEventArgs args)
        {
            TextBox.Content = ListBox.SelectedItem;
        }

        private void TextBox_OnValueChanged(object sender, ValueChangedEventArgs args)
        {
            Console.WriteLine($"TextBox content set to {TextBox.Content}");
            Button.Enabled = true;
        }

        private void ArticlesDialogBox_OnValueChanged(object sender, ValueChangedEventArgs args)
        {
            Console.WriteLine($"Button is {(Button.Enabled ? "" : "not ")}enabled");
        }
    }
}
