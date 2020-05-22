using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private string content;
        private Style style;

        public Style Style
        {
            get { return style; }
            set { style = value; }
        }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public void Render()
        {
            Console.WriteLine($"({row}, {column}): {content} [{style.FontFamily}]");
        }
    }
}
