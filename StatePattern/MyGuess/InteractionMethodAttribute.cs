using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class InteractionMethodAttribute : Attribute
    {
        private readonly ToolType _toolType;
        private readonly InteractionType _interactionType;

        public ToolType ToolType
        {
            get { return _toolType; }
        }

        public InteractionType InteractionType
        {
            get { return _interactionType; }
        }

        public InteractionMethodAttribute(InteractionType interactionType, ToolType toolType)
        {
            _interactionType = interactionType;
            _toolType = toolType;
        }
    }
}
