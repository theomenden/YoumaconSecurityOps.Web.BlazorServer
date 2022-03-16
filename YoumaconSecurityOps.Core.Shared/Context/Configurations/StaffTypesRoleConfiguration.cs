﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
namespace YoumaconSecurityOps.Core.Shared.Context.Configurations;

public partial class StaffTypesRoleConfiguration : IEntityTypeConfiguration<StaffTypesRoles>
{
    public void Configure(EntityTypeBuilder<StaffTypesRoles> entity)
    {
        entity.ToTable("StaffTypesRoles");

        entity.HasKey(e => e.Id)
            .IsClustered(false);

        entity.Property(e => e.Id)
            .HasDefaultValueSql("(newsequentialid())");

        entity.Property(e => e.StaffTypeId)
            .HasColumnName("StaffTypeId");

        entity.Property(e => e.RoleId)
            .HasColumnName("RoleId");

        entity.HasOne(d => d.Role)
            .WithMany(p => p.StaffTypeRoleMap)
            .HasForeignKey(d => d.RoleId)
            .HasConstraintName("FK_StaffTypesRoles_Roles")
            .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Staff)
            .WithMany(p => p.StaffTypeRoleMaps)
            .HasForeignKey(d => d.StaffId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.StaffTypeNavigation)
            .WithMany(p => p.StaffTypeRoleMaps)
            .HasForeignKey(d => d.StaffTypeId)
            .HasConstraintName("FK_StaffTypesRoles_Types")
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StaffTypesRoles> entity);
}