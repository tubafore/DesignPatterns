using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class NotificationService
    {
        private NotificationServer server;
        private AuthToken token;
        private Connection connection;
        private const string APPID = "7E453867-E46E-43C6-BBB6-2BD6B0120AC7";
        private const string APPSECRET = "E6F8FA9E-3D4A-4921-A017-FDB0135FEFB7";

        public NotificationService()
        {
            server = new NotificationServer();
        }

        public void SendMessage(string text, string ipAddress)
        {
            connection = server.Connect(ipAddress);
            token = server.Authenticate(APPID, APPSECRET);
            Message message = new Message(text);
            server.Send(token, message, ipAddress);
            connection.Disconnect();
        }
    }
}
