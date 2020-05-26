using System;

namespace TheirSolution
{
    public abstract class Ebook
    {
        public string FileName { get; set; }

        public Ebook(string fileName)
        {
            FileName = fileName;
        }

        public abstract void Show();
    }
}
