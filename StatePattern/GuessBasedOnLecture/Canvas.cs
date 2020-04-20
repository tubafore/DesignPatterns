using System;

namespace GuessBasedOnLecture
{
    public class Canvas
    {
        public ITool CurrentTool { get; set; }

        public Canvas()
        {

        }

        public void MouseDown()
        {
            if (CurrentTool != null)
            {
                CurrentTool.MouseDown();
            }
            else
            {
                Console.WriteLine("Current Tool is null");
            }
        }

        public void MouseUp()
        {
            if (CurrentTool != null)
            {
                CurrentTool.MouseUp();
            }
            else
            {
                Console.WriteLine("Current Tool is null");
            }
        }
    }
}
