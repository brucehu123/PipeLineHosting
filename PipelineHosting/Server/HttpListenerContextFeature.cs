using System;
using System.IO;
using System.Net;

namespace PipelineHosting
{
    public class HttpListenerContextFeature : IHttpRequestFeature, IHttpResponseFeature
    {
        public HttpListenerContext Context { get; }

        public HttpListenerContextFeature(HttpListenerContext context)
        {
            this.Context = context;
        }

        public long ContentLength64
        {

            get
            {
                return this.Context.Response.ContentLength64;
            }
            set
            {
                this.Context.Response.ContentLength64 = value;
            }
        }

        public Stream OutputStream { get; }

        public string ContentType
        {
            get { return this.Context.Response.ContentType; }
            set { this.Context.Response.ContentType = value; }
        }
        public int StatusCode
        {
            get { return this.Context.Response.StatusCode; }
            set { this.Context.Response.StatusCode = value; }
        }
        public Uri Url { get; }
    }
}
