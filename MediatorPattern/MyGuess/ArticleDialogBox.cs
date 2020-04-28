using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class ArticleDialogBox : DialogBox
    {
        public ListBox ArticlesListBox { get; private set; }
        public TextBox TitleTextBox { get; private set; }
        public Button SaveButton { get; private set; }

        public ArticleDialogBox() : base()
        {
            ArticlesListBox = new ListBox(this);
            TitleTextBox = new TextBox(this);
            SaveButton = new Button(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == ArticlesListBox)
            {
                ArticleSelected();
            }
            else if (control == TitleTextBox)
            {
                TitleTextBoxChanged();
            }
        }

        private void ArticleSelected()
        {
            if (!string.IsNullOrEmpty(ArticlesListBox.Selection))
            {
                TitleTextBox.Content = ArticlesListBox.Selection;
            }
            else
            {
                TitleTextBox.Content = "";
            }
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
        }
    }
}