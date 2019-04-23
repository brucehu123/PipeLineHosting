namespace PipelineHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseServer(new HttpListenerServerFactory("http://localhost:3721/"))
                .UseStartup(typeof(Startup))
                .Build()
                .Start();
        }
    }
}
