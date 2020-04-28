using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PushStyle
{
    public class PushDataSource : PushSubject
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
                this.value = value;
                Notify(value);
            }
        }

        public PushDataSource() : base()
        {

        }
    }
}
