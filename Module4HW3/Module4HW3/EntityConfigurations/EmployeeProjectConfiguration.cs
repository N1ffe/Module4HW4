﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(ep => ep.EmployeeProjectId);
            builder.Property(ep => ep.EmployeeProjectId).ValueGeneratedOnAdd();
            builder.Property(ep => ep.Rate).IsRequired().HasColumnType("money");
            builder.Property(ep => ep.StartedDate).IsRequired();
            builder.HasOne(ep => ep.Employee).WithMany(e => e.EmployeeProjects).HasForeignKey(ep => ep.EmployeeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(ep => ep.Project).WithMany(p => p.EmployeeProjects).HasForeignKey(ep => ep.ProjectId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
