﻿using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable ("User");
            builder.HasKey (u => u.Id);
            builder.HasIndex (u => u.Email).IsUnique();
            builder.Property(u => u.Name).HasMaxLength(80);
            builder.Property(u => u.Email).HasMaxLength(100);

        }
    }
}
