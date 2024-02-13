using Microsoft.EntityFrameworkCore;
using ServiceDeskDashboardApi.Entities;

namespace ServiceDeskDashboardApi.Interfaces;

public interface IApplicationDbContext
{
    DbSet<WebHookReleaseEntity> WebHookReleaseEntities { get; }
    DbSet<WebHookReleaseCommitEntity> WebHookReleaseCommitEntities { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}
