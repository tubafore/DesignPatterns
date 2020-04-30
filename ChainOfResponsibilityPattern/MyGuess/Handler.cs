using System;

namespace MyGuess
{
    public abstract class Handler
    {
        public Handler Next { get; set; }

        public abstract void Handle(HttpRequest httpRequest);
    }
}
