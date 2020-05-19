using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class EmailClient
    {
        private List<IEmailProvider> providers;

        public EmailClient()
        {
            providers = new List<IEmailProvider>();
        }

        public void AddProvider(IEmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in providers)
            {
                provider.DownloadEmails();
            }
        }
    }
}
