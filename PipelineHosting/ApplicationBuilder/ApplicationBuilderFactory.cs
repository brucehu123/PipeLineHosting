namespace PipelineHosting
{
    public class ApplicationBuilderFactory : IApplicationBuilderFactory
    {
        public IApplicationBuilder CreateBuilder()
        {
            return new ApplicationBuilder();
        }
    }
}
