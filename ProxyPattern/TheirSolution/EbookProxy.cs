using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class EbookProxy : Ebook
    {
        private RealEbook ebook;

        public EbookProxy(string fileName) : base(fileName)
        {

        }

        public override void Show()
        {
            if (ebook == null)
            {
                ebook = new RealEbook(FileName);
            }
            ebook.Show();
        }
    }
}
