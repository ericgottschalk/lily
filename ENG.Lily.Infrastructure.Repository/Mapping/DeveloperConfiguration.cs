﻿using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Username).HasMaxLength(36).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(250).IsRequired();
            builder.Property(t => t.Password).HasMaxLength(64).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(250).IsRequired();
            builder.Property(t => t.Cpf).HasMaxLength(9).IsRequired();
            builder.Property(t => t.DateCreate);

            builder.HasMany(t => t.Feedbacks).WithOne(t => t.Developer);
            builder.HasMany(t => t.Projects).WithOne(t => t.Developer);
            builder.HasMany(t => t.SendedFunds).WithOne(t => t.Developer);

            builder.HasIndex(t => t.Username).IsUnique();
            builder.HasIndex(t => t.Email).IsUnique();
            builder.HasIndex(t => t.Cpf).IsUnique();
        }
    }
}
