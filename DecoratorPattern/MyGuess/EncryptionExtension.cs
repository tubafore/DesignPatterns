using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class EncryptionExtension : ICloudStreamExtension
    {
        public string Transform(string input)
        {
            string transformation = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
            Console.WriteLine($"Encrypting {input} to {transformation}");
            return transformation;
        }
    }
}
