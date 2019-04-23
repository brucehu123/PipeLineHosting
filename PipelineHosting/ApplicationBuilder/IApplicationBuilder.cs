using System;

namespace PipelineHosting
{
    public  interface IApplicationBuilder
    {
        RequestDelegate Build();
        IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
    }
}
