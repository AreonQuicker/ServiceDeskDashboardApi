using ServiceDeskDashboardApi.Dtos;
using ServiceDeskDashboardApi.Models;

namespace ServiceDeskDashboardApi.Interfaces;

public interface IAzureDevOpsWebHookService
{
    Task<bool> WebHookAsync(AzureDevOpsWebHookReleaseRequest request);
}
