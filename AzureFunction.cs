using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace OnilneCourseFunctions;

public class AzureFunction
{
    private readonly ILogger<AzureFunction> _logger;

    public AzureFunction(ILogger<AzureFunction> logger)
    {
        _logger = logger;
    }

    [Function("AzureFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Admin, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}