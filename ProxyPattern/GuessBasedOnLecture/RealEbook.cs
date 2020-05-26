using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class RealEbook : Ebook
    {
        private string fileName;

        public RealEbook(string fileName)
        {
            this.fileName = fileName;
        }

        public void Show()
        {
            Console.WriteLine($"Viewing {fileName} ebook");
        }
    }
}
