using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Artifact
    {
        public string Name { get; set; }
        public bool HasError { get; set; }
        public bool Main { get; set; }

        public Artifact(string name)
        {
            Name = name;
        }
    }
}
