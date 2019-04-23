using System;

namespace PipelineHosting
{
    public  interface IWebHostBuilder
    {
        IWebHost Build();
        IWebHostBuilder UseServer(IServerFactory factory);
        IWebHostBuilder UseStartup(Type startupType);
    }
}
