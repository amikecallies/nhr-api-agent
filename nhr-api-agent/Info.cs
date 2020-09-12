using Microsoft.OpenApi.Models;

namespace nhr_api_agent
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}