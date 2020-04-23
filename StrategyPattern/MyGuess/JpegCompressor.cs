using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class JpegCompression : IImageCompression
    {
        public void Compress(Image image)
        {
            Console.WriteLine($"Compressing {image.FileName} with JPEG");
        }
    }
}
