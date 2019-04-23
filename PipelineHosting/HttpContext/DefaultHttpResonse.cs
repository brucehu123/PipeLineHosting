using System.IO;

namespace PipelineHosting
{
    public class DefaultHttpResonse : HttpResponse
    {
        public IHttpResponseFeature ResponseFeature { get; private set; }

        public DefaultHttpResonse(DefaultHttpContext context)
        {
            this.ResponseFeature = context.HttpContextFeatures.Get<IHttpResponseFeature>();
        }

        public override Stream OutputStream
        {
            get { return this.ResponseFeature.OutputStream; }
        }

        public override string ContentType
        {
            get { return this.ResponseFeature.ContentType; }
            set { this.ResponseFeature.ContentType = value; }
        }

        public override int StatusCode
        {
            get { return this.ResponseFeature.StatusCode; }
            set { this.ResponseFeature.StatusCode = value; }
        }
    }
}
