using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class EbookProxy
    {
        public Ebook Ebook { get; private set; }

        public EbookProxy(Ebook ebook)
        {
            Ebook = ebook;
        }

        public void LoadContents()
        {
            Ebook.LoadContents();
        }
    }
}
