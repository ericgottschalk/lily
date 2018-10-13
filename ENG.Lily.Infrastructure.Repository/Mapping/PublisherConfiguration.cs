using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Username).HasMaxLength(36).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(250).IsRequired();
            builder.Property(t => t.Password).HasMaxLength(64).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.DateCreate);
            builder.Property(t => t.CompanyName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.IsVerified);

            builder.HasMany(t => t.Games).WithOne(t => t.Publisher);

            builder.HasIndex(t => t.Username).IsUnique();
            builder.HasIndex(t => t.Email).IsUnique();
            builder.HasIndex(t => t.CompanyName).IsUnique();
        }
    }
}
