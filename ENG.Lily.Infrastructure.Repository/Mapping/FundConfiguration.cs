using ENG.Lily.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ENG.Lily.Infrastructure.Repository.Mapping
{
    public class FundConfiguration : IEntityTypeConfiguration<Fund>
    {
        public void Configure(EntityTypeBuilder<Fund> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.IsConfirmed);
            builder.Property(t => t.Aumont);
            builder.Property(t => t.CreditCardCompany).IsRequired();
            builder.Property(t => t.CreditCardLastFourDigits).HasMaxLength(4).IsRequired();
            builder.Property(t => t.DateCreate);
            builder.Property(t => t.TransactionId).IsRequired();
        }
    }
}
