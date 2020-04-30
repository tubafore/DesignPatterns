using System;

namespace TheirSolution
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;

            if (next != null)
                next.Handle(request);
        }

        /// <summary>
        /// Returns true if done processing, otherwise false
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <returns></returns>
        public abstract bool DoHandle(HttpRequest httpRequest);
    }
}
