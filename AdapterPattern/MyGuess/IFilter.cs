using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}
