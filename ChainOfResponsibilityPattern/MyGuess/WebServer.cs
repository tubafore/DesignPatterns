using System;
using System.Collections.Generic;
using System.Text;

namespace MyGuess
{
    public class WebServer
    {
        private readonly Handler requestPipeline;

        public Handler RequestPipeline
        {
            get { return requestPipeline; }
        }


        public WebServer(Handler pipeline)
        {
            requestPipeline = pipeline;
        }

        public void Handle(HttpRequest request)
        {
            if (RequestPipeline != null)
            {
                requestPipeline.Handle(request);
            }
        }
    }
}
