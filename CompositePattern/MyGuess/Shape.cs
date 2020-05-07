using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Shape : IRenderable
    {
        public void Render()
        {
            Console.WriteLine("Rendering shape");
        }
    }
}
