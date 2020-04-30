using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ExcelDataReader : DataReader
    {
        public ExcelDataReader(DataReader next) : base(next)
        {
            Extension = ".xls";
        }

        protected override bool DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
            return true;
        }
    }
}
