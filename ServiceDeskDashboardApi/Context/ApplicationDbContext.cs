using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ServiceDeskDashboardApi.Entities;
using ServiceDeskDashboardApi.Interfaces;

namespace ServiceDeskDashboardApi.Context;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<WebHookReleaseEntity> WebHookReleaseEntities =>
        Set<WebHookReleaseEntity>();

    public DbSet<WebHookReleaseCommitEntity> WebHookReleaseCommitEntities =>
        Set<WebHookReleaseCommitEntity>();

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
