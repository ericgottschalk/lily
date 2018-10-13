using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Level);
            builder.Property(t => t.Text).HasMaxLength(300);
            builder.Property(t => t.DateCreate);
        }
    }
}
