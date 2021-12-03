﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using YsecItAuthApp.Web.EntityFramework.Context.Configurations;
using YsecItAuthApp.Web.EntityFramework.Models;

#nullable disable

namespace YsecItAuthApp.Web.EntityFramework.Context
{
    public partial class YsecItSecurityContext : IdentityDbContext<YsecItUser, YsecItRole, Guid>
    {
        public YsecItSecurityContext(DbContextOptions<YsecItSecurityContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Configurations.YsecItUserConfiguration());

            modelBuilder.ApplyConfiguration(new Configurations.UserRoleMapConfiguration());
            
            base.OnModelCreating(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}