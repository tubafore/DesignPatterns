using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class Libary
    {
        private Dictionary<string, Ebook> books;

        public Libary()
        {
            books = new Dictionary<string, Ebook>();
        }

        public Ebook this[string index]
        {
            get { return books[index]; }
        }

        public void AddEbook(string fileName)
        {
            books[fileName] = new EbookProxy(fileName);
        }
    }
}
