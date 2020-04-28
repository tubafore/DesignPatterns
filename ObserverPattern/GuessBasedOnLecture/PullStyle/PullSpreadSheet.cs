using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PullStyle
{
    public class PullSpreadSheet : IPullObserver
    {
        private PullDataSource dataSource;

        public PullSpreadSheet(PullDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"PullSpreadsheet detected a change to {dataSource.Value}");
        }
    }
}
