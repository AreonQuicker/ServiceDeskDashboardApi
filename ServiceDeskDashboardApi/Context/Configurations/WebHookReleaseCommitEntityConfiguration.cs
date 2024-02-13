using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskDashboardApi.Entities;

namespace ServiceDeskDashboardApi.Context.Configurations;

public class
    WebHookReleaseCommitEntityConfiguration : IEntityTypeConfiguration<WebHookReleaseCommitEntity>
{
    public void Configure(EntityTypeBuilder<WebHookReleaseCommitEntity> builder)
    {
        //Table Name
        builder.ToTable("WebHookReleaseCommit");
    }
}
