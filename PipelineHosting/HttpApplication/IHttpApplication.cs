using System;
using System.Threading.Tasks;

namespace PipelineHosting
{
    public interface IHttpApplication<TContext>
    {
        TContext CreateContext(IFeatureCollection contextFeatures);
        void DisposeContext(TContext context, Exception exception);
        Task ProcessRequestAsync(TContext context);
    }
}
