using System;

namespace MyGuess
{
    public class DataSource
    {
        private int value;

        public int Value
        {
            get 
            {
                return value; 
            }
            set 
            {
                ValueChangedEventArgs args = new ValueChangedEventArgs { NewValue = value, OldValue = this.value };
                this.value = value;
                if (OnValueChanged != null)
                    OnValueChanged.Invoke(this, args );
            }
        }

        public event OnValueChangedHandler OnValueChanged;

        public DataSource()
        {

        }
    }
}
