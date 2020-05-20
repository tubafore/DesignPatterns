using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class MainArtifactRenderer : IArtifactRenderer
    {
        private readonly IArtifactRenderer renderer;

        public MainArtifactRenderer(IArtifactRenderer renderer)
        {
            this.renderer = renderer;
        }

        public string Render()
        {
            return $"[Main] - {renderer.Render()}";
        }
    }
}
