using System;

namespace PipelineHosting
{
    public  interface IStartupLoader
    {
        Action<IApplicationBuilder> GetConfigurationDelegate(Type startpupType);
    }
}
