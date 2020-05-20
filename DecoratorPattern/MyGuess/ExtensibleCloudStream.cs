using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class ExtensibleCloudStream
    {
        private CloudStream _cloudStream;
        private List<ICloudStreamExtension> _extensions;

        public List<ICloudStreamExtension> Extensions
        {
            get { return _extensions; }
        }

        public CloudStream CloudStream
        {
            get { return _cloudStream; }
            set { _cloudStream = value; }
        }

        public ExtensibleCloudStream(CloudStream stream)
        {
            _extensions = new List<ICloudStreamExtension>();
            _cloudStream = stream;
        }

        public void Write(string input)
        {
            foreach (var extension in Extensions)
            {
                input = extension.Transform(input);
            }
            _cloudStream.Write(input);
        }
    }
}
