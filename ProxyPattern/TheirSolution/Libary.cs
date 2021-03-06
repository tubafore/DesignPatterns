﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Libary
    {
        private Dictionary<string, Ebook> books;

        public Libary()
        {
            books = new Dictionary<string, Ebook>();
        }

        public void AddEbook(string fileName)
        {
            books[fileName] = new EbookProxy(fileName);
        }

        public void OpenEbook(string fileName)
        {
            books[fileName].Show();
        }
    }
}
