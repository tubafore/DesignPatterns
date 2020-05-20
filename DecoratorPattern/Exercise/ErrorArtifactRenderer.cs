using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ErrorArtifactRenderer : IArtifactRenderer
    {
        private readonly IArtifactRenderer renderer;

        public ErrorArtifactRenderer(IArtifactRenderer renderer)
        {
            this.renderer = renderer;
        }

        public string Render()
        {
            return $"[Error] - {renderer.Render()}";
        }
    }
}
