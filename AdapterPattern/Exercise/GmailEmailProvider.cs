using Exercise.Gmail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class GmailEmailProvider : IEmailProvider
    {
        private GmailClient gmailClient;

        public GmailEmailProvider(GmailClient client)
        {
            gmailClient = client;
        }

        public void DownloadEmails()
        {
            gmailClient.Connect();
            gmailClient.GetEmails();
            gmailClient.Disconnect();
        }
    }
}
