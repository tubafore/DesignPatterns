using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture.PullStyle
{
    public class PullChart : IPullObserver
    {
        private PullDataSource dataSource;

        public PullChart(PullDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"PullChart detected a change to {dataSource.Value}");
        }
    }
}
