using System.Net;

namespace PipelineHosting
{
    public class HttpListenerServer : IServer
    {
        public HttpListener Listener { get; }

        public IFeatureCollection Features { get; }=new FeatureCollection();

        public HttpListenerServer(string url)
        {
            this.Listener=new HttpListener();
            this.Listener.Prefixes.Add(url??"http://localhost:3721");
        }

        public void Start<TContext>(IHttpApplication<TContext> application)
        {
            this.Listener.Start();
            while (true)
            {
                HttpListenerContext context = this.Listener.GetContext();

                HttpListenerContextFeature feature=new HttpListenerContextFeature(context);
                FeatureCollection contextFeatures=new FeatureCollection();
                contextFeatures.Set<IHttpRequestFeature>(feature);
                contextFeatures.Set<IHttpResponseFeature>(feature);

                application.ProcessRequestAsync(application.CreateContext(contextFeatures))
                    .ContinueWith(_ => context.Response.Close());
            }
        }
    }
}
