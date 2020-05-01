using System;
using System.Collections.Generic;

namespace Exercise
{
    public class WavFile
    {
        private List<Segment> segments;

        public WavFile()
        {
            segments = new List<Segment>();
        }

        public static WavFile Read(string fileName)
        {
            WavFile result = new WavFile();
            
            result.segments.Add(new FormatSegment());
            result.segments.Add(new FactSegment());
            result.segments.Add(new FactSegment());
            result.segments.Add(new FactSegment());

            return result;
        }

        public void Execute(Operation operation)
        {
            foreach (Segment segment in segments)
            {
                segment.Execute(operation);
            }
        }
    }
}
