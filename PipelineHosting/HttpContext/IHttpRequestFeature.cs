using System;

namespace PipelineHosting
{
    public  interface  IHttpRequestFeature
    {
        Uri Url { get; }
    }
}
