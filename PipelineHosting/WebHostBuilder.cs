using System;
using Microsoft.Extensions.DependencyInjection;

namespace PipelineHosting
{
    public class WebHostBuilder : IWebHostBuilder
    {
        private Type startupType;
        IServiceCollection services;

        public WebHostBuilder()
        {
            services = new ServiceCollection()
                .AddTransient<IStartupLoader, StartupLoader>()
                .AddTransient<IApplicationBuilderFactory, ApplicationBuilderFactory>();
        }

        public IWebHost Build()
        {
            return  new WebHost(services,startupType);
        }

        public IWebHostBuilder UseServer(IServerFactory factory)
        {
            services.AddSingleton<IServerFactory>(factory);
            return this;
        }

        public IWebHostBuilder UseStartup(Type startupType)
        {
            this.startupType = startupType;
            return this;
        }
    }
}
