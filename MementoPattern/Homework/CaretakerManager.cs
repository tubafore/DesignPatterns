using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class CaretakerManager
    {
        private Dictionary<object, Caretaker> caretakers;
        private static CaretakerManager instance;

        private CaretakerManager()
        {
            caretakers = new Dictionary<object, Caretaker>();
        }

        public static CaretakerManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaretakerManager();
                return instance;
            }
        }

        public Caretaker this[object index]
        {
            get { return caretakers[index]; }
            set { caretakers[index] = value; }
        }
    }
}
