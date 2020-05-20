using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class CompressedCloudStream : Stream
    {
        private Stream stream;

        public CompressedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            string compressed = Compress(data);
            stream.Write(compressed);
        }

        private string Compress(string data)
        {
            int max = Math.Min(5, data.Length);
            string transformation = data.Substring(0, max);
            Console.WriteLine($"Compressing {data} to {transformation}");
            return transformation;
        }
    }
}
