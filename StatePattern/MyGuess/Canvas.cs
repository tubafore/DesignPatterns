using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyGuess
{
    public class Canvas
    {
        private InteractionManager interactionManager;
        public ToolType CurrentTool { get; set; }

        public Canvas()
        {
            interactionManager = new InteractionManager();
            RegisterInteractions();
        }

        private void RegisterInteractions()
        {
            foreach (var method in typeof(Canvas).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var attr = method.GetCustomAttribute(typeof(InteractionMethodAttribute), false);
                
                if (attr != null)
                {
                    InteractionMethodAttribute attribute = attr as InteractionMethodAttribute;
                    if (attribute.InteractionType == InteractionType.MouseDown)
                        interactionManager.AddMouseDownHandler(attribute.ToolType, method);
                    else
                        interactionManager.AddMouseUpHandler(attribute.ToolType, method);
                }
            }
        }

        public void MouseDown()
        {
            MethodInfo handler = interactionManager.GetMouseDownHandler(CurrentTool);
            if (handler != null)
            {
                handler.Invoke(this, null);
            }
            else
            {
                Console.WriteLine($"No registered MouseDown interaction for {Enum.GetName(typeof(ToolType), CurrentTool)}");
            }
        }

        public void MouseUp()
        {
            MethodInfo handler = interactionManager.GetMouseUpHandler(CurrentTool);
            if (handler != null)
            {
                handler.Invoke(this, null);
            }
            else
            {
                Console.WriteLine($"No registered MouseUp interaction for {Enum.GetName(typeof(ToolType), CurrentTool)}");
            }
        }

        #region Handlers

        [InteractionMethod(InteractionType.MouseDown, ToolType.Selection)]
        private void SelectionMouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        [InteractionMethod(InteractionType.MouseDown, ToolType.Brush)]
        private void BrushMouseDown()
        {
            Console.WriteLine("Brush Icon");
        }

        [InteractionMethod(InteractionType.MouseDown, ToolType.Eraser)]
        private void EraserMouseDown()
        {
            Console.WriteLine("Eraser Icon");
        }

        [InteractionMethod(InteractionType.MouseUp, ToolType.Selection)]
        private void SelectionMouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }

        [InteractionMethod(InteractionType.MouseUp, ToolType.Brush)]
        private void BrushMouseUp()
        {
            Console.WriteLine("Draw a line");
        }

        [InteractionMethod(InteractionType.MouseUp, ToolType.Eraser)]
        private void EraserMouseUp()
        {
            Console.WriteLine("Eraser something.");
        }

        #endregion
    }
}
