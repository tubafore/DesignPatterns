using System;
using System.Collections.Generic;
using System.Text;

namespace GuessBasedOnLecture
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Eraser something.");
        }
    }
}
