using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution.WithObserverPattern
{
    public class ArticlesDialogBox 
    {
        public ListBox ArticlesListBox { get; private set; }
        public TextBox TitleTextBox { get; private set; }
        public Button SaveButton { get; private set; }

        public ArticlesDialogBox()
        {
            ArticlesListBox = new ListBox();
            ArticlesListBox.Attach(ArticleSelected);

            TitleTextBox = new TextBox();
            TitleTextBox.Attach(TitleTextBoxChanged);

            SaveButton = new Button();

        }

        private void ArticleSelected()
        {
            if (!string.IsNullOrEmpty(ArticlesListBox.SelectedItem))
            {
                TitleTextBox.Content = ArticlesListBox.SelectedItem;
            }
            else
            {
                TitleTextBox.Content = "";
            }
            Console.WriteLine($"TitleTextBox.Content set to {TitleTextBox.Content}");
        }

        private void TitleTextBoxChanged()
        {
            if (!string.IsNullOrEmpty(TitleTextBox.Content))
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
            Console.WriteLine($"Save Button is {(SaveButton.Enabled ? "" : "not ")}enabled");
        }
    }
}
