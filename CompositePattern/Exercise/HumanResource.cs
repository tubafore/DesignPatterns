using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class HumanResource : IDeployable
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a human resource");
        }
    }
}
