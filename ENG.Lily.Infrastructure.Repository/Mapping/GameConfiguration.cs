using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>

    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.CoverUrl).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(300).IsRequired();

            builder.HasOne(t => t.Genre);
        }
    }
}
