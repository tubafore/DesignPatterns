using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Apply Vivid Filter");
        }
    }
}
