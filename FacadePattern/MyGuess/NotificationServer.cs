using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class NotificationServer
    {
        // workflow:  connect, authenticate, send, disconnect

        public NotificationServer()
        {

        }

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken token, Message message, string target)
        {
            Console.WriteLine($"Sending the following message to {target}: {message}");
        }
    }
}
