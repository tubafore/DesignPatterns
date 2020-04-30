using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            bool stopChain = (httpRequest.Password != "1234" || httpRequest.UserName != "Admin");
            if (stopChain)
                Console.WriteLine("Authentication failed");
            else
                Console.WriteLine("Authentication succeeded");
            return stopChain;
        }
    }
}
