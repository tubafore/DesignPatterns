using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Logging");
            return false;
        }
    }
}
