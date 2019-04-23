namespace PipelineHosting
{
    public  interface IServer
    {
        void Start<TContext>(IHttpApplication<TContext> application);
    }
}
