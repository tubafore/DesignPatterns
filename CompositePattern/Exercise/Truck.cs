﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Truck : IDeployable
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a truck");
        }
    }
}
