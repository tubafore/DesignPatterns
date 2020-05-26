using System;

namespace MyGuess
{
    public class Ebook
    {
        public string Title { get; set; }
        public byte[] CoverArt { get; set; }
        public string Contents { get; internal set; }

        internal void LoadContents()
        {
            Contents = "Contents loaded.";
        }

        public override string ToString()
        {
            return $"{Title} {(string.IsNullOrEmpty(Contents) ? "" : $"- {Contents}")}";
        }
    }
}
