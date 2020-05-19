using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Gmail
{
    public sealed class GmailClient
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Gmail");
        }

        public void GetEmails()
        {
            Console.WriteLine("Downloading emails from Gmail");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from Gmail");
        }
    }
}
