using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PullStyle
{
    public class PullDataSource : PullSubject
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
                Notify();
            }
        }

        public PullDataSource() : base()
        {

        }
    }
}
