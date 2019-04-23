using System;

namespace PipelineHosting
{
    public class StartupLoader : IStartupLoader
    {
        public Action<IApplicationBuilder> GetConfigurationDelegate(Type startpupType)
        {
            return app =>
                startpupType.GetMethod("Configure").Invoke(Activator.CreateInstance(startpupType), new object[] {app});
        }
    }
}
