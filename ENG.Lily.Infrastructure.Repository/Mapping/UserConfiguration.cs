using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Username).HasMaxLength(36).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(250).IsRequired();
            builder.Property(t => t.Password).HasMaxLength(64).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.City).HasMaxLength(250);
            builder.Property(t => t.Country).HasMaxLength(250);
            builder.Property(t => t.WebSite).HasMaxLength(250);
            builder.Property(t => t.ProfilePictureUrl);
            builder.Property(t => t.Phrase).HasMaxLength(100);
            builder.Property(t => t.DateCreate);
            builder.Property(t => t.Verified);

            builder.HasMany(t => t.Feedbacks).WithOne(t => t.User).HasForeignKey(t => t.UserId);
            builder.HasMany(t => t.Projects).WithOne(t => t.User).HasForeignKey(t => t.UserId);
            builder.HasMany(t => t.SendedFunds).WithOne(t => t.User).HasForeignKey(t => t.UserId);

            builder.HasIndex(t => t.Username).IsUnique();
            builder.HasIndex(t => t.Email).IsUnique();
        }
    }
}
