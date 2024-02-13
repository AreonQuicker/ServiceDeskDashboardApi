using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskDashboardApi.Entities;

namespace ServiceDeskDashboardApi.Context.Configurations;

public class WebHookReleaseEntityConfiguration : IEntityTypeConfiguration<WebHookReleaseEntity>
{
    public void Configure(EntityTypeBuilder<WebHookReleaseEntity> builder)
    {
        //Table Name
        builder.ToTable("WebHookRelease");

        //One To Many Relationship
        builder.HasMany(e => e.Commits)
            .WithOne(e => e.WebHookRelease)
            .HasForeignKey(e => e.WebHookReleaseId);
    }
}
