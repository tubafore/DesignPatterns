using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class SignupDialogBox
    {
        public TextBox UserNameTextBox { get; private set; }
        public TextBox PasswordTextBox { get; private set; }
        public CheckBox TermsCheckBox { get; private set; }
        public Button SignupButton { get; private set; }

        public SignupDialogBox()
        {
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            TermsCheckBox = new CheckBox();
            SignupButton = new Button();

            UserNameTextBox.AddEventHandler(ShouldEnableSignupButton);
            PasswordTextBox.AddEventHandler(ShouldEnableSignupButton);
            TermsCheckBox.AddEventHandler(ShouldEnableSignupButton);
            SignupButton.AddEventHandler(CanSignup);
        }

        private void ShouldEnableSignupButton()
        {
            SignupButton.Enabled = !string.IsNullOrEmpty(UserNameTextBox.Content) && !string.IsNullOrEmpty(PasswordTextBox.Content) && TermsCheckBox.Checked;
        }

        private void CanSignup()
        {
            if (SignupButton.Enabled)
                Console.WriteLine("The user can sign up now");
            else
            {
                Console.WriteLine("The user can NOT sign up.");
            }
        }
    }
}
