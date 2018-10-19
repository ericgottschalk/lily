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
            builder.Property(t => t.WhyInvest).HasMaxLength(750).IsRequired();
            builder.Property(t => t.DateCreate);
            builder.Property(t => t.TargetReleaseYear);

            builder.HasOne(t => t.Genre).WithMany(t => t.Projects).HasForeignKey(t => t.GenreId);
            builder.HasMany(t => t.Media).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);
            builder.HasMany(t => t.Feedbacks).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);
            builder.HasMany(t => t.Funds).WithOne(t => t.Project).HasForeignKey(t => t.ProjectId);

            builder.HasIndex(t => t.Name);
            builder.HasIndex(t => t.DateCreate);
        }
    }
}
