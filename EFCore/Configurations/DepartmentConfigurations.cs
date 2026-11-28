using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            #region Properties
            builder.ToTable("DepartmentInfo", "dbo")
                   .HasKey(d => d.DeptId);

            builder.Property(d => d.DeptId)
            .UseIdentityColumn(10, 10);

            builder.Property(d => d.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.Property(d => d.CreationDate)
                .HasColumnType("Date")
                .HasComputedColumnSql("GETDATE()");

            builder.Property<string>("Address")
                .HasColumnType("nvarchar(100)")
                .HasDefaultValue("Cairo");
            #endregion

            #region RealtionShip Mapping
            //builder.HasMany(d => d.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e => e.DepartmentDeptId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(d => d.Manager)
            //    .WithOne(e => e.DepartmentToMange)
            //    .HasForeignKey<Department>(d => d.MangerId)
            //    .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
