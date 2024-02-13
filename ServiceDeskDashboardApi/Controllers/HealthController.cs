using Microsoft.AspNetCore.Mvc;

namespace ServiceDeskDashboardApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly ILogger<AzureDevOpsWebHookController> _logger;


    public HealthController(ILogger<AzureDevOpsWebHookController> logger)
    {
        _logger = logger;
    }

    [HttpGet("ping")]
    public async Task<string> ping()
    {
        return "pong";
    }
}