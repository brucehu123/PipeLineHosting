using System;

namespace PipelineHosting
{
    public abstract class HttpRequest
    {
        public abstract Uri Url { get; }
    }
}
