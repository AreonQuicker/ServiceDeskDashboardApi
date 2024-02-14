using ServiceDeskDashboardApi.Dtos;
using ServiceDeskDashboardApi.Entities;
using ServiceDeskDashboardApi.Interfaces;
using ServiceDeskDashboardApi.Models;

namespace ServiceDeskDashboardApi.Services;

public class AzureDevOpsWebHookService : IAzureDevOpsWebHookService
{
    private readonly IApplicationDbContext _applicationDbContext;

    public AzureDevOpsWebHookService(IApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<bool> WebHookAsync(AzureDevOpsWebHookReleaseRequest request)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request));

        var entity = new WebHookReleaseEntity
        {
            CreatedBy = "System",
            Created = DateTime.Now,
            ReleaseCreatedDate = request.CreatedDate,
            ReleaseId = request.Id,
            EventType = request.EventType,
            MessageText = request.Message?.Text,
            DetailedMessageText = request.DetailedMessage?.Text,
            ProjectId = request.Resource.Project.Id,
            ProjectName = request.Resource.Project.Name,
            StageName = request.Resource.StageName,
            ResourceUrl = request.Resource.Url,
            DeploymentId = request.Resource.Deployment.Id!.Value,
            DeploymentReleaseId = request.Resource.Deployment.Release.Id!.Value,
            DeploymentReleaseName = request.Resource.Deployment.Release.Name,
            DeployReleaseDefinitionId = request.Resource.Deployment.ReleaseDefinition.Id!.Value,
            DeployReleaseDefinitionName = request.Resource.Deployment.ReleaseDefinition.Name,
            DeployReleaseEnvironmentId = request.Resource.Deployment.ReleaseEnvironment.Id!.Value,
            DeployReleaseEnvironmentName = request.Resource.Deployment.ReleaseEnvironment.Name,
            DeployRequestedForUser = request.Resource.Deployment.RequestedFor?.DisplayName,
            DeployRequstedByUser = request.Resource.Deployment.RequestedBy?.DisplayName,
            DeployQueuedOn = request.Resource.Deployment.QueuedOn!.Value,
            DeployStartedOn = request.Resource.Deployment.StartedOn!.Value,
            DeployCompletedOn = request.Resource.Deployment.CompletedOn!.Value,
            DeployApproveMessage = request.Resource.Deployment.PreDeployApprovals?.FirstOrDefault()?.Comments,
            DeployApproverUser =
                request.Resource.Deployment.PreDeployApprovals?.FirstOrDefault()?.Approver?.DisplayName,
            DeployApprovedByUser = request.Resource.Deployment.PreDeployApprovals?.FirstOrDefault()?.ApprovedBy
                ?.DisplayName,
            Commits = request.Resource.Data?.Commits?.Select(c => new WebHookReleaseCommitEntity
            {
                CreatedBy = "System",
                Created = DateTime.Now,
                CommitId = c.Id,
                CommitMessage = c.Message,
                CommitAuthor = c.Author.DisplayName,
            }).ToList() ?? new List<WebHookReleaseCommitEntity>()
        };

        await _applicationDbContext.WebHookReleaseEntities.AddAsync(entity);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }
}
