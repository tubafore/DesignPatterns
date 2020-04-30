using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class NumbersDataReader : DataReader
    {
        public NumbersDataReader(DataReader next) : base(next)
        {
            Extension = ".numbers";
        }

        protected override bool DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Numbers spreadsheet.");
            return true;
        }
    }
}
