using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ArtifactRenderer : IArtifactRenderer
    {
        private Artifact artifact;

        public ArtifactRenderer(Artifact artifact)
        {
            this.artifact = artifact;
        }

        public string Render()
        {
            return artifact.Name;
        }
    }
}
