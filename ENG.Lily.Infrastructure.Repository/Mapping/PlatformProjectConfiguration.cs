using ENG.Lily.Domain.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class PlatformProjectConfiguration : IEntityTypeConfiguration<PlatformProject>
    {
        public void Configure(EntityTypeBuilder<PlatformProject> builder)
        {
            builder.HasOne(t => t.Platform).WithMany(t => t.Projects);
            builder.HasOne(t => t.Project).WithMany(t => t.Platforms);
        }
    }
}
