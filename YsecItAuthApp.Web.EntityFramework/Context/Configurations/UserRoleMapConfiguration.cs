﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using YsecItAuthApp.Web.EntityFramework.Context;
using YsecItAuthApp.Web.EntityFramework.Models;

#nullable disable

namespace YsecItAuthApp.Web.EntityFramework.Context.Configurations
{
    public partial class UserRoleMapConfiguration : IEntityTypeConfiguration<UserRoleMap>
    {
        public void Configure(EntityTypeBuilder<UserRoleMap> entity)
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UserRoleMap> entity);
    }
}