using Leoni.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leoni.Infraestructure.Persistance.Configuration
{
    public class AnalysisConfiguration : IEntityTypeConfiguration<Analysis>
    {
        public void Configure(EntityTypeBuilder<Analysis> builder)
        {
            builder.ToTable("Analysis", "Audit");

            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.Id);

            builder.Property(e => e.Name).
                IsRequired().
                HasMaxLength(128);

            builder.Property(e => e.Description).
                IsRequired(false).
                HasMaxLength(500);

            builder.Property(e => e.CreatedByUserId).
                IsRequired();
        }
    }
}
