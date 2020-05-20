using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class CloudStream
    {
        public CloudStream()
        {

        }

        public void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}
