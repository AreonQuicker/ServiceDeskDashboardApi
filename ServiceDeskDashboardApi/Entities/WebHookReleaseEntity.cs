namespace ServiceDeskDashboardApi.Entities;

public class WebHookReleaseEntity : AuditableEntity
{
    public WebHookReleaseEntity()
    {
        Commits = new List<WebHookReleaseCommitEntity>();
    }

    public int Id { get; set; }
    public DateTime? ReleaseCreatedDate { get; set; }
    public string ReleaseId { get; set; }
    public string? EventType { get; set; }
    public string? MessageText { get; set; }
    public string? DetailedMessageText { get; set; }
    public string ProjectId { get; set; } = null!;
    public string ProjectName { get; set; } = null!;
    public string StageName { get; set; } = null!;
    public string? ResourceUrl { get; set; }

    public int DeploymentId { get; set; }
    public int DeploymentReleaseId { get; set; }
    public string DeploymentReleaseName { get; set; } = null!;

    public int DeployReleaseDefinitionId { get; set; }
    public string DeployReleaseDefinitionName { get; set; } = null!;

    public int DeployReleaseEnvironmentId { get; set; }
    public string DeployReleaseEnvironmentName { get; set; } = null!;

    public string? DeployRequstedByUser { get; set; }
    public string? DeployRequestedForUser { get; set; }
    public DateTime DeployQueuedOn { get; set; }
    public DateTime DeployStartedOn { get; set; }
    public DateTime DeployCompletedOn { get; set; }
    public string? DeployApproveMessage { get; set; }
    public string? DeployApproverUser { get; set; }
    public string? DeployApprovedByUser { get; set; }

    public List<WebHookReleaseCommitEntity> Commits { get; set; }
}
