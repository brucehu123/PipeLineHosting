namespace PipelineHosting
{
    public class HttpListenerServerFactory : IServerFactory
    {
        private string _url;

        public HttpListenerServerFactory(string url=null)
        {
            this._url = url ?? "http://localhost:3721";
        }

        public IServer CreateServer()
        {
            return new HttpListenerServer(this._url);
        }
    }
}
