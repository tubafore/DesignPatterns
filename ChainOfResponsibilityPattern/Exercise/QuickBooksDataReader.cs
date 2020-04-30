using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class QuickBooksDataReader : DataReader
    {
        public QuickBooksDataReader(DataReader next) : base(next)
        {
            Extension = ".qbw";
        }

        protected override bool DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an QuickBooks spreadsheet.");
            return true;
        }
    }
}
