using System;

namespace PipelineHosting
{
    public class DefaultHttpRequest : HttpRequest
    {
        public IHttpRequestFeature RequestFeature { get; private set; }

        public DefaultHttpRequest(DefaultHttpContext context)
        {
            this.RequestFeature = context.HttpContextFeatures.Get<IHttpRequestFeature>();
        }

        public override Uri Url
        {
            get { return this.RequestFeature.Url; }
        }
    }
}
