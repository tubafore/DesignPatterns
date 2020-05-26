using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Library
    {
        private Dictionary<string, EbookProxy> books;

        public Library()
        {
            books = new Dictionary<string, EbookProxy>();
        }

        public EbookProxy this[string index]
        {
            get { return books[index]; }
        }

        public void AddBook(string fileName, string title, byte[] coverArt)
        {
            Ebook ebook = new Ebook { Title = title, CoverArt = coverArt };
            books[fileName] = new EbookProxy(ebook);
        }
    }
}
