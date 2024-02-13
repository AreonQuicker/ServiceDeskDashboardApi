namespace ServiceDeskDashboardApi.Services;

public interface IAzureDevOpsWebHookService
{
    bool AzureDevOpsReleaseWebHook(string json);
}

public class AzureDevOpsWebHookReleaseModel
{
}

public class AzureDevOpsWebHookReleaseDto
{
}

public class AzureDevOpsWebHookService : IAzureDevOpsWebHookService
{
    public AzureDevOpsWebHookService()
    {
    }

    public bool AzureDevOpsReleaseWebHook(string json)
    {
        return true;
    }
}
