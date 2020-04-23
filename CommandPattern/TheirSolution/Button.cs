using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class Button
    {
        private ICommand onClick;
        public string Label { get; set; }

        public Button(ICommand onClick)
        {
            this.onClick = onClick;
        }

        public void Click()
        {
            onClick.Execute();
        }
    }
}
