using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}
