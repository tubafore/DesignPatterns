using System;
using System.IO;

namespace Exercise
{
    public abstract class DataReader
    {
        protected string Extension;
        private DataReader next;

        public DataReader(DataReader next)
        {
            this.next = next;
        }

        public void Read(string fileName)
        {
            bool extensionVerified = VerifyExtension(fileName);

            if (extensionVerified && DoRead(fileName))
                return;

            if (next != null)
                next.Read(fileName);
            else if (!extensionVerified)
            {
                Console.WriteLine("File format not supported.");
            }
        }

        private bool VerifyExtension(string fileName)
        {
            return Path.GetExtension(fileName.ToLower()) == Extension;
        }

        protected abstract bool DoRead(string fileName); 
    }
}
