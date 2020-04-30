using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compressing");
            return true;
        }
    }
}
