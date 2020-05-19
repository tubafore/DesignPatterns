using MyGuess.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    /// <summary>
    /// The preferred method since there is never a guarantee the 
    /// interface requiring adaptation is extendable.
    /// </summary>
    public class CaramelFilter : IFilter
    {
        private Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render(image);
        }
    }
}
