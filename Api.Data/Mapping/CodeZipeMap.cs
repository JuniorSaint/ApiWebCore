using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class CodeZipeMap : IEntityTypeConfiguration<CodeZipEntity>
    {
        public void Configure(EntityTypeBuilder<CodeZipEntity> builder)
        {
            builder.ToTable("ZipCode");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.ZipCode);
            builder.HasOne(c => c.City).WithMany(m => m.CodeZip);
        }
    }
}
