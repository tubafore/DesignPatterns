using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class Group : IRenderable
    {
        private List<IRenderable> children;

        public Group()
        {
            children = new List<IRenderable>();
        }

        public void Add(IRenderable child)
        {
            children.Add(child);
        }

        public void Remove(IRenderable child)
        {
            children.Remove(child);
        }

        public void Render()
        {
            foreach (IRenderable renderable in children)
            {
                renderable.Render();
            }
        }
    }
}
