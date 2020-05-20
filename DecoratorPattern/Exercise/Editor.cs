using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Editor
    {
        private List<Artifact> artifacts;
        private List<IArtifactRenderer> renderers;

        public Editor()
        {
            artifacts = new List<Artifact>();
            renderers = new List<IArtifactRenderer>();
        }

        public void OpenProject(string path)
        {
            artifacts.AddRange(new Artifact[]
            {
                new Artifact("Main") { Main = true },
                new Artifact("Demo"),
                new Artifact("EmailClient") { HasError = true },
                new Artifact("EmailProvider")
            });

            for (int i = 0; i < artifacts.Count; i++)
            {
                renderers.Add(new ArtifactRenderer(artifacts[i]));
                if (artifacts[i].Main)
                    renderers[i] = new MainArtifactRenderer(renderers[i]);
                if (artifacts[i].HasError)
                    renderers[i] = new ErrorArtifactRenderer(renderers[i]);
            }

            Render();
        }

        public void Render()
        {
            foreach (var renderer in renderers)
                Console.WriteLine(renderer.Render());
        }
    }
}
