using System;

namespace MyGuess
{
    public class ImageStorage
    {
        public IImageCompressor Compressor { get; set; }
        public IImageFilter Filter { get; set; }

        public ImageStorage(IImageCompressor compressor, IImageFilter filter)
        {
            Compressor = compressor;
            Filter = filter;
        }

        public void Store(Image image)
        {
            Compressor.Compress(image);
            Filter.Apply(image);
        }
    }
}
