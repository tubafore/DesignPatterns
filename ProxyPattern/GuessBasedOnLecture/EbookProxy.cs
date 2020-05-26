using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class EbookProxy : Ebook
    {
        private RealEbook ebook;
        private string fileName;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Show()
        {
            if (ebook == null)
            {
                ebook = new RealEbook(fileName);
            }
            ebook.Show();
        }
    }
}
