namespace ServiceDeskDashboardApi.Entities;

public class AzureDevOpsWebHookReleaseEntity : AuditableEntity
{
    public int Id { get; set; }

    public string Project { get; set; } = null!;

    public string ReleaseName { get; set; } = null!;
}
