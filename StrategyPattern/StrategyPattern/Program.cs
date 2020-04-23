using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunMyGuess()
        {
            MyGuess.ImageStorage storage = new MyGuess.ImageStorage(new MyGuess.JpegCompressor(), new MyGuess.BlackAndWhiteFilter());
            MyGuess.Image image = new MyGuess.Image { FileName = @"C:\Images\Test.bmp" };
            storage.Store(image);
        }
    }
}
