using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class SpreadSheet
    {
        public SpreadSheet()
        {

        }

        public void ReportValueChanged(object sender, ValueChangedEventArgs args)
        {
            Console.WriteLine($"Spreadsheet sees a value change from {args.OldValue} to {args.NewValue}");
        }
    }
}
