using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Authenticator : Handler
    {
        public override void Handle(HttpRequest httpRequest)
        {
            bool continueChain = (httpRequest.Password == "1234" && httpRequest.UserName == "Admin");
            if (continueChain && Next != null)
            {
                Console.WriteLine("Authentication succeeded");
                Next.Handle(httpRequest);
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
        }
    }
}
