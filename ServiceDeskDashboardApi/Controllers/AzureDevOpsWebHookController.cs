using Microsoft.AspNetCore.Mvc;
using ServiceDeskDashboardApi.Services;

namespace ServiceDeskDashboardApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AzureDevOpsWebHookController : ControllerBase
{
    private readonly ILogger<AzureDevOpsWebHookController> _logger;
    private readonly IAzureDevOpsWebHookService _azureDevOpsWebHookService;

    public AzureDevOpsWebHookController(ILogger<AzureDevOpsWebHookController> logger,
        IAzureDevOpsWebHookService azureDevOpsWebHookService)
    {
        _logger = logger;
        _azureDevOpsWebHookService = azureDevOpsWebHookService;
    }

    [HttpGet("azure-dev-ops-release-web-hook")]
    public bool AzureDevOpsReleaseWebHook()
    {
        return _azureDevOpsWebHookService.AzureDevOpsReleaseWebHook("");
    }
}
