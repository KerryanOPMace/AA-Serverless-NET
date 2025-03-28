using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ResizeAPI
{
    public class ResizeFunction
    {
        private readonly ILogger<ResizeFunction> _logger;

        public ResizeFunction(ILogger<ResizeFunction> logger)
        {
            _logger = logger;
        }

        [Function("ResizeFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
