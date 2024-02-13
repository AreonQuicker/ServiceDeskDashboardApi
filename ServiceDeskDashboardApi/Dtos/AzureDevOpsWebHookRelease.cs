using Newtonsoft.Json;

namespace ServiceDeskDashboardApi.Dtos;

public class Account
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("baseUrl")] public string BaseUrl { get; set; }
}

public class ApprovedBy
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("imageUrl")] public string ImageUrl { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }
}

public class Approver
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("imageUrl")] public string ImageUrl { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }
}

public class Artifact
{
    [JsonProperty("sourceId")] public string SourceId { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("alias")] public string Alias { get; set; }

    [JsonProperty("definitionReference")] public DefinitionReference DefinitionReference { get; set; }

    [JsonProperty("isPrimary")] public bool? IsPrimary { get; set; }

    [JsonProperty("isRetained")] public bool? IsRetained { get; set; }
}

public class ArtifactsDownloadInput
{
    [JsonProperty("downloadInputs")] public List<object> DownloadInputs { get; set; }
}

public class ArtifactSourceDefinitionUrl
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class ArtifactSourceVersionUrl
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class Author
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }
}

public class Avatar
{
    [JsonProperty("href")] public string Href { get; set; }
}

public class Branch
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class Branches
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class BuildUri
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class Collection
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("baseUrl")] public string BaseUrl { get; set; }
}

public class Commit
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("message")] public string Message { get; set; }

    [JsonProperty("displayUri")] public string DisplayUri { get; set; }

    [JsonProperty("author")] public Author Author { get; set; }
}

public class Condition
{
    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("conditionType")] public string ConditionType { get; set; }

    [JsonProperty("value")] public string Value { get; set; }

    [JsonProperty("result")] public bool? Result { get; set; }
}

public class Data
{
    [JsonProperty("releaseProperties")] public string ReleaseProperties { get; set; }

    [JsonProperty("environmentStatuses")] public string EnvironmentStatuses { get; set; }

    [JsonProperty("workItems")] public List<object> WorkItems { get; set; }

    [JsonProperty("previousReleaseEnvironment")]
    public PreviousReleaseEnvironment PreviousReleaseEnvironment { get; set; }

    [JsonProperty("commits")] public List<Commit> Commits { get; set; }

    [JsonProperty("testResults")] public TestResults TestResults { get; set; }

    [JsonProperty("moreWorkItemsMessage")] public string MoreWorkItemsMessage { get; set; }
}

public class DataSourceBinding
{
    [JsonProperty("dataSourceName")] public string DataSourceName { get; set; }

    [JsonProperty("parameters")] public Parameters Parameters { get; set; }

    [JsonProperty("endpointId")] public string EndpointId { get; set; }

    [JsonProperty("target")] public string Target { get; set; }
}

public class Definition
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class DefinitionReference
{
    [JsonProperty("artifactSourceDefinitionUrl")]
    public ArtifactSourceDefinitionUrl ArtifactSourceDefinitionUrl { get; set; }

    [JsonProperty("branches")] public Branches Branches { get; set; }

    [JsonProperty("buildUri")] public BuildUri BuildUri { get; set; }

    [JsonProperty("definition")] public Definition Definition { get; set; }

    [JsonProperty("IsMultiDefinitionType")]
    public IsMultiDefinitionType IsMultiDefinitionType { get; set; }

    [JsonProperty("IsTriggeringArtifact")] public IsTriggeringArtifact IsTriggeringArtifact { get; set; }

    [JsonProperty("IsXamlBuildArtifactType")]
    public IsXamlBuildArtifactType IsXamlBuildArtifactType { get; set; }

    [JsonProperty("project")] public Project Project { get; set; }

    [JsonProperty("repository.provider")] public RepositoryProvider RepositoryProvider { get; set; }

    [JsonProperty("repository")] public Repository Repository { get; set; }

    [JsonProperty("requestedFor")] public RequestedFor RequestedFor { get; set; }

    [JsonProperty("requestedForId")] public RequestedForId RequestedForId { get; set; }

    [JsonProperty("sourceVersion")] public SourceVersion SourceVersion { get; set; }

    [JsonProperty("version")] public Version Version { get; set; }

    [JsonProperty("artifactSourceVersionUrl")]
    public ArtifactSourceVersionUrl ArtifactSourceVersionUrl { get; set; }

    [JsonProperty("branch")] public Branch Branch { get; set; }
}

public class Deployment
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("release")] public Release Release { get; set; }

    [JsonProperty("releaseDefinition")] public ReleaseDefinition ReleaseDefinition { get; set; }

    [JsonProperty("releaseEnvironment")] public ReleaseEnvironment ReleaseEnvironment { get; set; }

    [JsonProperty("projectReference")] public object ProjectReference { get; set; }

    [JsonProperty("definitionEnvironmentId")]
    public int? DefinitionEnvironmentId { get; set; }

    [JsonProperty("attempt")] public int? Attempt { get; set; }

    [JsonProperty("reason")] public string Reason { get; set; }

    [JsonProperty("deploymentStatus")] public string DeploymentStatus { get; set; }

    [JsonProperty("operationStatus")] public string OperationStatus { get; set; }

    [JsonProperty("requestedBy")] public RequestedBy RequestedBy { get; set; }

    [JsonProperty("requestedFor")] public RequestedFor RequestedFor { get; set; }

    [JsonProperty("queuedOn")] public DateTime? QueuedOn { get; set; }

    [JsonProperty("startedOn")] public DateTime? StartedOn { get; set; }

    [JsonProperty("completedOn")] public DateTime? CompletedOn { get; set; }

    [JsonProperty("lastModifiedOn")] public DateTime? LastModifiedOn { get; set; }

    [JsonProperty("lastModifiedBy")] public LastModifiedBy LastModifiedBy { get; set; }

    [JsonProperty("conditions")] public List<Condition> Conditions { get; set; }

    [JsonProperty("preDeployApprovals")] public List<PreDeployApproval> PreDeployApprovals { get; set; }

    [JsonProperty("postDeployApprovals")] public List<PostDeployApproval> PostDeployApprovals { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }
}

public class DeploymentInput
{
    [JsonProperty("parallelExecution")] public ParallelExecution ParallelExecution { get; set; }

    [JsonProperty("agentSpecification")] public object AgentSpecification { get; set; }

    [JsonProperty("skipArtifactsDownload")]
    public bool? SkipArtifactsDownload { get; set; }

    [JsonProperty("artifactsDownloadInput")]
    public ArtifactsDownloadInput ArtifactsDownloadInput { get; set; }

    [JsonProperty("queueId")] public int? QueueId { get; set; }

    [JsonProperty("demands")] public List<object> Demands { get; set; }

    [JsonProperty("enableAccessToken")] public bool? EnableAccessToken { get; set; }

    [JsonProperty("timeoutInMinutes")] public int? TimeoutInMinutes { get; set; }

    [JsonProperty("jobCancelTimeoutInMinutes")]
    public int? JobCancelTimeoutInMinutes { get; set; }

    [JsonProperty("condition")] public string Condition { get; set; }

    [JsonProperty("overrideInputs")] public OverrideInputs OverrideInputs { get; set; }
}

public class DeploymentJob
{
    [JsonProperty("job")] public Job Job { get; set; }

    [JsonProperty("tasks")] public List<Task> Tasks { get; set; }
}

public class DeployPhasesSnapshot
{
    [JsonProperty("deploymentInput")] public DeploymentInput DeploymentInput { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("phaseType")] public string PhaseType { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("refName")] public object RefName { get; set; }

    [JsonProperty("workflowTasks")] public List<object> WorkflowTasks { get; set; }
}

public class DeployStep
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("deploymentId")] public int? DeploymentId { get; set; }

    [JsonProperty("attempt")] public int? Attempt { get; set; }

    [JsonProperty("reason")] public string Reason { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("operationStatus")] public string OperationStatus { get; set; }

    [JsonProperty("releaseDeployPhases")] public List<ReleaseDeployPhase> ReleaseDeployPhases { get; set; }

    [JsonProperty("requestedBy")] public RequestedBy RequestedBy { get; set; }

    [JsonProperty("requestedFor")] public RequestedFor RequestedFor { get; set; }

    [JsonProperty("queuedOn")] public DateTime? QueuedOn { get; set; }

    [JsonProperty("lastModifiedBy")] public LastModifiedBy LastModifiedBy { get; set; }

    [JsonProperty("lastModifiedOn")] public DateTime? LastModifiedOn { get; set; }

    [JsonProperty("hasStarted")] public bool? HasStarted { get; set; }

    [JsonProperty("tasks")] public List<object> Tasks { get; set; }

    [JsonProperty("runPlanId")] public string RunPlanId { get; set; }

    [JsonProperty("issues")] public List<object> Issues { get; set; }
}

public class DetailedMessage
{
    [JsonProperty("text")] public string Text { get; set; }

    [JsonProperty("html")] public string Html { get; set; }

    [JsonProperty("markdown")] public string Markdown { get; set; }
}

public class Environment
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("releaseId")] public int? ReleaseId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("variables")] public Variables Variables { get; set; }

    [JsonProperty("variableGroups")] public List<object> VariableGroups { get; set; }

    [JsonProperty("preDeployApprovals")] public List<PreDeployApproval> PreDeployApprovals { get; set; }

    [JsonProperty("postDeployApprovals")] public List<PostDeployApproval> PostDeployApprovals { get; set; }

    [JsonProperty("preApprovalsSnapshot")] public PreApprovalsSnapshot PreApprovalsSnapshot { get; set; }

    [JsonProperty("postApprovalsSnapshot")]
    public PostApprovalsSnapshot PostApprovalsSnapshot { get; set; }

    [JsonProperty("deploySteps")] public List<DeployStep> DeploySteps { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("definitionEnvironmentId")]
    public int? DefinitionEnvironmentId { get; set; }

    [JsonProperty("environmentOptions")] public EnvironmentOptions EnvironmentOptions { get; set; }

    [JsonProperty("demands")] public List<object> Demands { get; set; }

    [JsonProperty("conditions")] public List<Condition> Conditions { get; set; }

    [JsonProperty("createdOn")] public DateTime? CreatedOn { get; set; }

    [JsonProperty("modifiedOn")] public DateTime? ModifiedOn { get; set; }

    [JsonProperty("workflowTasks")] public List<object> WorkflowTasks { get; set; }

    [JsonProperty("deployPhasesSnapshot")] public List<DeployPhasesSnapshot> DeployPhasesSnapshot { get; set; }

    [JsonProperty("owner")] public Owner Owner { get; set; }

    [JsonProperty("schedules")] public List<object> Schedules { get; set; }

    [JsonProperty("release")] public Release Release { get; set; }

    [JsonProperty("releaseDefinition")] public ReleaseDefinition ReleaseDefinition { get; set; }

    [JsonProperty("releaseCreatedBy")] public ReleaseCreatedBy ReleaseCreatedBy { get; set; }

    [JsonProperty("triggerReason")] public string TriggerReason { get; set; }

    [JsonProperty("timeToDeploy")] public double? TimeToDeploy { get; set; }

    [JsonProperty("processParameters")] public ProcessParameters ProcessParameters { get; set; }

    [JsonProperty("preDeploymentGatesSnapshot")]
    public PreDeploymentGatesSnapshot PreDeploymentGatesSnapshot { get; set; }

    [JsonProperty("postDeploymentGatesSnapshot")]
    public PostDeploymentGatesSnapshot PostDeploymentGatesSnapshot { get; set; }
}

public class EnvironmentOptions
{
    [JsonProperty("emailNotificationType")]
    public string EmailNotificationType { get; set; }

    [JsonProperty("emailRecipients")] public string EmailRecipients { get; set; }

    [JsonProperty("skipArtifactsDownload")]
    public bool? SkipArtifactsDownload { get; set; }

    [JsonProperty("timeoutInMinutes")] public int? TimeoutInMinutes { get; set; }

    [JsonProperty("enableAccessToken")] public bool? EnableAccessToken { get; set; }

    [JsonProperty("publishDeploymentStatus")]
    public bool? PublishDeploymentStatus { get; set; }

    [JsonProperty("badgeEnabled")] public bool? BadgeEnabled { get; set; }

    [JsonProperty("autoLinkWorkItems")] public bool? AutoLinkWorkItems { get; set; }

    [JsonProperty("pullRequestDeploymentEnabled")]
    public bool? PullRequestDeploymentEnabled { get; set; }
}

public class Input
{
    [JsonProperty("aliases")] public List<object> Aliases { get; set; }

    [JsonProperty("options")] public Options Options { get; set; }

    [JsonProperty("properties")] public Properties Properties { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("label")] public string Label { get; set; }

    [JsonProperty("defaultValue")] public string DefaultValue { get; set; }

    [JsonProperty("required")] public bool? Required { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("helpMarkDown")] public string HelpMarkDown { get; set; }

    [JsonProperty("visibleRule")] public string VisibleRule { get; set; }

    [JsonProperty("groupName")] public string GroupName { get; set; }
}

public class IsMultiDefinitionType
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class IsTriggeringArtifact
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class IsXamlBuildArtifactType
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class Job
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("timelineRecordId")] public string TimelineRecordId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("dateStarted")] public DateTime? DateStarted { get; set; }

    [JsonProperty("dateEnded")] public DateTime? DateEnded { get; set; }

    [JsonProperty("startTime")] public DateTime? StartTime { get; set; }

    [JsonProperty("finishTime")] public DateTime? FinishTime { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("issues")] public List<object> Issues { get; set; }

    [JsonProperty("agentName")] public string AgentName { get; set; }
}

public class LastModifiedBy
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }
}

public class Links
{
    [JsonProperty("avatar")] public Avatar Avatar { get; set; }

    [JsonProperty("web")] public Web Web { get; set; }

    [JsonProperty("self")] public Self Self { get; set; }

    [JsonProperty("logs")] public Logs Logs { get; set; }
}

public class Logs
{
    [JsonProperty("href")] public string Href { get; set; }
}

public class Message
{
    [JsonProperty("text")] public string Text { get; set; }

    [JsonProperty("html")] public string Html { get; set; }

    [JsonProperty("markdown")] public string Markdown { get; set; }
}

public class Options
{
    [JsonProperty("webApp")] public string WebApp { get; set; }

    [JsonProperty("webAppLinux")] public string WebAppLinux { get; set; }

    [JsonProperty("webAppContainer")] public string WebAppContainer { get; set; }

    [JsonProperty("functionApp")] public string FunctionApp { get; set; }

    [JsonProperty("functionAppLinux")] public string FunctionAppLinux { get; set; }

    [JsonProperty("functionAppContainer")] public string FunctionAppContainer { get; set; }

    [JsonProperty("apiApp")] public string ApiApp { get; set; }

    [JsonProperty("mobileApp")] public string MobileApp { get; set; }
}

public class OverrideInputs
{
}

public class Owner
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("imageUrl")] public string ImageUrl { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }
}

public class ParallelExecution
{
    [JsonProperty("parallelExecutionType")]
    public string ParallelExecutionType { get; set; }
}

public class Parameters
{
    [JsonProperty("WebAppKind")] public string WebAppKind { get; set; }
}

public class PostApprovalsSnapshot
{
    [JsonProperty("approvals")] public List<object> Approvals { get; set; }
}

public class PostDeployApproval
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("revision")] public int? Revision { get; set; }

    [JsonProperty("approvalType")] public string ApprovalType { get; set; }

    [JsonProperty("createdOn")] public DateTime? CreatedOn { get; set; }

    [JsonProperty("modifiedOn")] public DateTime? ModifiedOn { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("comments")] public string Comments { get; set; }

    [JsonProperty("isAutomated")] public bool? IsAutomated { get; set; }

    [JsonProperty("isNotificationOn")] public bool? IsNotificationOn { get; set; }

    [JsonProperty("trialNumber")] public int? TrialNumber { get; set; }

    [JsonProperty("attempt")] public int? Attempt { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("release")] public Release Release { get; set; }

    [JsonProperty("releaseDefinition")] public ReleaseDefinition ReleaseDefinition { get; set; }

    [JsonProperty("releaseEnvironment")] public ReleaseEnvironment ReleaseEnvironment { get; set; }

    [JsonProperty("url")] public string Url { get; set; }
}

public class PostDeploymentGatesSnapshot
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("gatesOptions")] public object GatesOptions { get; set; }

    [JsonProperty("gates")] public List<object> Gates { get; set; }
}

public class PreApprovalsSnapshot
{
    [JsonProperty("approvals")] public List<object> Approvals { get; set; }
}

public class PreDeployApproval
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("revision")] public int? Revision { get; set; }

    [JsonProperty("approver")] public Approver Approver { get; set; }

    [JsonProperty("approvedBy")] public ApprovedBy ApprovedBy { get; set; }

    [JsonProperty("approvalType")] public string ApprovalType { get; set; }

    [JsonProperty("createdOn")] public DateTime? CreatedOn { get; set; }

    [JsonProperty("modifiedOn")] public DateTime? ModifiedOn { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("comments")] public string Comments { get; set; }

    [JsonProperty("isAutomated")] public bool? IsAutomated { get; set; }

    [JsonProperty("isNotificationOn")] public bool? IsNotificationOn { get; set; }

    [JsonProperty("trialNumber")] public int? TrialNumber { get; set; }

    [JsonProperty("attempt")] public int? Attempt { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("release")] public Release Release { get; set; }

    [JsonProperty("releaseDefinition")] public ReleaseDefinition ReleaseDefinition { get; set; }

    [JsonProperty("releaseEnvironment")] public ReleaseEnvironment ReleaseEnvironment { get; set; }

    [JsonProperty("url")] public string Url { get; set; }
}

public class PreDeploymentGatesSnapshot
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("gatesOptions")] public object GatesOptions { get; set; }

    [JsonProperty("gates")] public List<object> Gates { get; set; }
}

public class PreviousReleaseEnvironment
{
    [JsonProperty("status")] public string Status { get; set; }
}

public class ProcessParameters
{
    [JsonProperty("inputs")] public List<Input> Inputs { get; set; }

    [JsonProperty("dataSourceBindings")] public List<DataSourceBinding> DataSourceBindings { get; set; }
}

public class Project
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("baseUrl")] public string BaseUrl { get; set; }
}

public class ProjectReference
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class Properties
{
    [JsonProperty("EditableOptions")] public string EditableOptions { get; set; }
}

public class Release
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }

    [JsonProperty("artifacts")] public List<Artifact> Artifacts { get; set; }

    [JsonProperty("webAccessUri")] public string WebAccessUri { get; set; }

    [JsonProperty("description")] public string Description { get; set; }

    [JsonProperty("reason")] public string Reason { get; set; }
}

public class ReleaseCreatedBy
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("imageUrl")] public string ImageUrl { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }
}

public class ReleaseDefinition
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("path")] public string Path { get; set; }

    [JsonProperty("projectReference")] public object ProjectReference { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }
}

public class ReleaseDeployPhase
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("phaseId")] public string PhaseId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("phaseType")] public string PhaseType { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("runPlanId")] public string RunPlanId { get; set; }

    [JsonProperty("deploymentJobs")] public List<DeploymentJob> DeploymentJobs { get; set; }

    [JsonProperty("manualInterventions")] public List<object> ManualInterventions { get; set; }

    [JsonProperty("startedOn")] public DateTime? StartedOn { get; set; }
}

public class ReleaseEnvironment
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }
}

public class Repository
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class RepositoryProvider
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class RequestedBy
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }
}

public class RequestedFor
{
    [JsonProperty("displayName")] public string DisplayName { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("_links")] public Links Links { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("uniqueName")] public string UniqueName { get; set; }

    [JsonProperty("imageUrl")] public string ImageUrl { get; set; }

    [JsonProperty("descriptor")] public string Descriptor { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class RequestedForId
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class Resource
{
    [JsonProperty("environment")] public Environment Environment { get; set; }

    [JsonProperty("project")] public Project Project { get; set; }

    [JsonProperty("deployment")] public Deployment Deployment { get; set; }

    [JsonProperty("comment")] public object Comment { get; set; }

    [JsonProperty("data")] public Data Data { get; set; }

    [JsonProperty("stageName")] public string StageName { get; set; }

    [JsonProperty("attemptId")] public int? AttemptId { get; set; }

    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("url")] public string Url { get; set; }
}

public class ResourceContainers
{
    [JsonProperty("collection")] public Collection Collection { get; set; }

    [JsonProperty("account")] public Account Account { get; set; }

    [JsonProperty("project")] public Project Project { get; set; }
}

public class AzureDevOpsWebHookRelease
{
    [JsonProperty("subscriptionId")] public string SubscriptionId { get; set; }

    [JsonProperty("notificationId")] public int? NotificationId { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("eventType")] public string EventType { get; set; }

    [JsonProperty("publisherId")] public string PublisherId { get; set; }

    [JsonProperty("message")] public Message? Message { get; set; }

    [JsonProperty("detailedMessage")] public DetailedMessage? DetailedMessage { get; set; }

    [JsonProperty("resource")] public Resource Resource { get; set; }

    [JsonProperty("resourceVersion")] public string ResourceVersion { get; set; }

    [JsonProperty("resourceContainers")] public ResourceContainers ResourceContainers { get; set; }

    [JsonProperty("createdDate")] public DateTime? CreatedDate { get; set; }
}

public class Self
{
    [JsonProperty("href")] public string Href { get; set; }
}

public class SourceVersion
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public object Name { get; set; }
}

public class Task
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("timelineRecordId")] public string TimelineRecordId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("dateStarted")] public DateTime? DateStarted { get; set; }

    [JsonProperty("dateEnded")] public DateTime? DateEnded { get; set; }

    [JsonProperty("startTime")] public DateTime? StartTime { get; set; }

    [JsonProperty("finishTime")] public DateTime? FinishTime { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("rank")] public int? Rank { get; set; }

    [JsonProperty("issues")] public List<object> Issues { get; set; }

    [JsonProperty("agentName")] public string AgentName { get; set; }

    [JsonProperty("task")] public Task2 Task2 { get; set; }

    [JsonProperty("percentComplete")] public int? PercentComplete { get; set; }
}

public class Task2
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("version")] public string Version { get; set; }
}

public class TestResults
{
}

public class Variables
{
}

public class Version
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}

public class Web
{
    [JsonProperty("href")] public string Href { get; set; }
}
