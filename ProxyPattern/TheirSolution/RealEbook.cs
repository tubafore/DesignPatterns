using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class RealEbook : Ebook
    {
        public RealEbook(string fileName) : base(fileName)
        {
            Load();
        }

        private void Load()
        {
            Console.WriteLine($"Loading ebook from {FileName}");
        }

        public override void Show()
        {
            Console.WriteLine($"Viewing {FileName}");
        }
    }
}
