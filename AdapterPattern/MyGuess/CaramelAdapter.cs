using MyGuess.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
