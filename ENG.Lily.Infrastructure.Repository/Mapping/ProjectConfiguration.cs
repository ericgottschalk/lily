using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Description).HasMaxLength(1500).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(250).IsRequired();
            builder.Property(t => t.WebSite).HasMaxLength(750);
            builder.Property(t => t.Hash).HasMaxLength(64).IsRequired();
            builder.Property(t => t.DateCreate);
            builder.Property(t => t.TargetReleaseYear);
            builder.Property(t => t.CoverUrl);

            builder.HasOne(t => t.Genre).WithMany(t => t.Projects).HasForeignKey(t => t.GenreId);
            builder.HasMany(t => t.Media).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);
            builder.HasMany(t => t.Feedbacks).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);
            builder.HasMany(t => t.Funds).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);

            builder.HasIndex(t => t.Name);
            builder.HasIndex(t => t.DateCreate);
            builder.HasIndex(t => t.Hash).IsUnique();
        }
    }
}
