using System;

namespace Exercise
{
    public abstract class Window
    {
        public void Close()
        {
            BeforeClose();
            Console.WriteLine("Remove the window from the screen");
            AfterClose();
        }

        public abstract void BeforeClose();
        public abstract void AfterClose();
    }
}
