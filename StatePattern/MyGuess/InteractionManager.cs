using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyGuess
{
    public class InteractionManager
    {
        private readonly Dictionary<ToolType, MethodInfo> mouseDownHandlers;
        private readonly Dictionary<ToolType, MethodInfo> mouseUpHandlers;

        public void AddMouseDownHandler(ToolType toolType, MethodInfo handler)
        {
            mouseDownHandlers[toolType] = handler;
        }

        public void AddMouseUpHandler(ToolType toolType, MethodInfo handler)
        {
            mouseUpHandlers[toolType] = handler;
        }

        public InteractionManager()
        {
            mouseDownHandlers = new Dictionary<ToolType, MethodInfo>();
            mouseUpHandlers = new Dictionary<ToolType, MethodInfo>();
        }

        public MethodInfo GetMouseDownHandler(ToolType toolType)
        {
            MethodInfo result = null;
            if (mouseDownHandlers.TryGetValue(toolType, out result))
                return result;
            return null;
        }

        public MethodInfo GetMouseUpHandler(ToolType toolType)
        {
            MethodInfo result = null;
            if (mouseUpHandlers.TryGetValue(toolType, out result))
                return result;
            return null;
        }
    }
}
