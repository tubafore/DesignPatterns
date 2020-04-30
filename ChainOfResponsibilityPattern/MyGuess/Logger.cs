using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Logger : Handler
    {
        public override void Handle(HttpRequest httpRequest)
        {
            Console.WriteLine("Logging request");
            if (Next != null)
            {
                Next.Handle(httpRequest);
            }
        }
    }
}
