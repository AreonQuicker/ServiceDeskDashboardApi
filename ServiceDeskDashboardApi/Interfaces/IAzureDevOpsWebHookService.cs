using ServiceDeskDashboardApi.Dtos;

namespace ServiceDeskDashboardApi.Interfaces;

public interface IAzureDevOpsWebHookService
{
    Task<bool> WebHookAsync(AzureDevOpsWebHookRelease request);
}