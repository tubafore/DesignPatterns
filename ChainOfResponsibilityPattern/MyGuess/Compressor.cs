using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Compressor : Handler
    {
        public override void Handle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compressing...");
            if (Next != null)
                Next.Handle(httpRequest);
        }
    }
}
