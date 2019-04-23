using System;
using Microsoft.Extensions.DependencyInjection;

namespace PipelineHosting
{
    public class WebHost : IWebHost
    {
        private IServiceProvider serviceProvider;
        private Type startupType;

        public WebHost(IServiceCollection serviceCollection, Type startupType)
        {
            this.serviceProvider = serviceCollection.BuildServiceProvider();
            this.startupType = startupType;
        }

        public void Start()
        {
            IApplicationBuilder applicationBuilder =
                this.serviceProvider.GetRequiredService<IApplicationBuilderFactory>().CreateBuilder();
            serviceProvider.GetRequiredService<IStartupLoader>().GetConfigurationDelegate(startupType)(
                applicationBuilder);
            IServer server = serviceProvider.GetRequiredService<IServerFactory>().CreateServer();
            server.Start(new HostingApplication(applicationBuilder.Build()));
        }
    }
}
