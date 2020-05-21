using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Message
    {
        public string Content { get; private set; }

        public Message(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
