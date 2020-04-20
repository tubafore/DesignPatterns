using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Document : IOriginator
    {
        private string content;
        private string fontName;
        private double fontSize;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                SaveState();
            }
        }

        public string FontName
        {
            get
            {
                return fontName;
            }
            set
            {
                fontName = value;
                SaveState();
            }
        }

        public double FontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
                SaveState();
            }
        }


        public Document()
        {
            CaretakerManager.Instance[this] = new Caretaker();
        }

        public void Redo()
        {
            Memento m = CaretakerManager.Instance[this].Redo();
            if (m != null)
            {
                LoadState(m);
            }
        }

        public IOriginator ShallowCopy()
        {
            return (Document)this.MemberwiseClone();
        }

        public void Undo()
        {
            Memento m = CaretakerManager.Instance[this].Undo();
            if (m != null)
            {
                LoadState(m);
            }
        }

        public void SaveState()
        {
            CaretakerManager.Instance[this].SaveState(new Memento(this));
        }

        public void LoadState(Memento memento)
        {
            Document d = (Document)memento.Content;
            content = d.Content;
            fontName = d.FontName;
            fontSize = d.FontSize;
        }

        public override string ToString()
        {
            return $"Font - {FontName}\nFont Size - {FontSize}\nContent - {Content}";
        }
    }
}
