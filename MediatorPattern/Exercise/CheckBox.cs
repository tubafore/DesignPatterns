using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class CheckBox : UIControl
    {
        private bool @checked;

        public bool Checked
        {
            get { return @checked; }
            set
            {
                @checked = value;
                Notify();
            }
        }


        public CheckBox() : base()
        {

        }
    }
}
