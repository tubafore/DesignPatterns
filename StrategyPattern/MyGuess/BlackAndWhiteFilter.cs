using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class BlackAndWhiteFilter : IImageFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine($"Applying Black and White filter to {image.FileName}");
        }
    }
}
