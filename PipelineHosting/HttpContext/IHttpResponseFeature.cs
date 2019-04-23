using System.IO;

namespace PipelineHosting
{
    public interface IHttpResponseFeature
    {
        Stream OutputStream { get; }

        string ContentType { get; set; }

        int StatusCode { get; set; }
    }
}
