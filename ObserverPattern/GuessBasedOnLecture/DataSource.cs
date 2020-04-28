using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class DataSource : Subject
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

        public DataSource() : base()
        {

        }
    }
}
