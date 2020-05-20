using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class CompressionExtension : ICloudStreamExtension
    {
        public string Transform(string input)
        {
            int max = Math.Min(5, input.Length);
            string transformation = input.Substring(0, max);
            Console.WriteLine($"Compressing {input} to {transformation}");
            return transformation;
        }
    }
}
