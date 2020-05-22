using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Icon
    {
        private byte[] bytes;
        private static Random random = new Random();

        public Icon()
        {
            bytes = new byte[20000000];
            random.NextBytes(bytes);
        }
    }
}
