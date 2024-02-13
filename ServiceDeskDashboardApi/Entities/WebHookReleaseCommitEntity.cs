using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceDeskDashboardApi.Entities;

public class WebHookReleaseCommitEntity : AuditableEntity
{
    public int Id { get; set; }
    public int WebHookReleaseId { get; set; }
    public WebHookReleaseEntity WebHookRelease { get; set; } = null!;
    public string CommitId { get; set; } = null!;
    public string CommitMessage { get; set; } = null!;
    public string CommitAuthor { get; set; } = null!;
}
