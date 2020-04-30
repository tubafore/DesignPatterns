using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class WebServer
    {
        private readonly Handler requestPipeline;

        public WebServer(Handler pipeline)
        {
            requestPipeline = pipeline;
        }

        public void Handle(HttpRequest request)
        {
            if (requestPipeline != null)
            {
                requestPipeline.Handle(request);
            }
        }
    }
}
