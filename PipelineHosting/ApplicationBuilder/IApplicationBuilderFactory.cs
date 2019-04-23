namespace PipelineHosting
{
    public  interface IApplicationBuilderFactory
    {
        IApplicationBuilder CreateBuilder();
    }
}
