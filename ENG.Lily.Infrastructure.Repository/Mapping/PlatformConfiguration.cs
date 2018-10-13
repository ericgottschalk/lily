using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Code).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(150).IsRequired();

            builder.HasIndex(t => t.Code).IsUnique();
        }
    }
}
