using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Chart
    {
        public Chart()
        {

        }

        public void ReportValueChanged(object sender, ValueChangedEventArgs args)
        {
            Console.WriteLine($"Chart sees a value change from {args.OldValue} to {args.NewValue}");
        }
    }
}
