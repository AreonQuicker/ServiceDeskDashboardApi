using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ServiceDeskDashboardApi.Entities;

namespace ServiceDeskDashboardApi.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<AzureDevOpsWebHookReleaseEntity> AzureDevOpsWebHookReleaseEntities =>
        Set<AzureDevOpsWebHookReleaseEntity>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
