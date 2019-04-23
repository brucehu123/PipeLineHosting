using System.Threading.Tasks;

namespace PipelineHosting
{
    public delegate Task RequestDelegate(HttpContext context);
}
