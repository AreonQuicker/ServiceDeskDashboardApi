using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServiceDeskDashboardApi.Dtos;
using ServiceDeskDashboardApi.Interfaces;
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

    [HttpPost("webhook")]
    public async Task<bool> WebHook([FromBody] AzureDevOpsWebHookRelease request)
    {
        return await _azureDevOpsWebHookService.WebHookAsync(request);
    }
}
