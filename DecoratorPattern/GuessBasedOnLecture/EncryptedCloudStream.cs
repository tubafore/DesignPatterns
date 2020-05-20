using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class EncryptedCloudStream : Stream
    {
        private Stream stream;

        public EncryptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            string encrypted = Encrypt(data);
            stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            string transformation = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
            Console.WriteLine($"Encrypting {data} to {transformation}");
            return transformation;
        }
    }
}
