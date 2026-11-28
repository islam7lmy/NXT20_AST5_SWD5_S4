using EFCore.Configurations;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {

        #region DBSets
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion

        ///OnConfiguring => configuration Of Database Server
        ///
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Your_Connection_String_Here");
            //optionsBuilder.UseSqlServer("Data Source = Islam7lmyLapVM\\ISLAM7LMY; Initial Catalog = NXT20.EFMyCompany;integrated security = true; Encrypt = false; Trust server Cirtifcate = true");
            //optionsBuilder.UseSqlServer("Data Source = Islam7lmyLapVM\\ISLAM7LMY; Initial Catalog = NXT20.EFMyCompany;user id = sa; password = 1234567; Encrypt = false; Trust server Cirtifcate = true");
            optionsBuilder.UseSqlServer("Data Source=Islam7lmyLapVM\\ISLAM7LMY;Initial Catalog=NXT20.EFMyCompany;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        }

        ///OnModelCreating => Models of Database [table]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent API
            #region Wayes To Access Property
            //modelBuilder.Entity<Employee>()
            //    .Property("FirstName")
            //    .HasDefaultValue("N/A");

            //modelBuilder.Entity<Employee>()
            //   .Property(nameof(Employee.FirstName))
            //   .HasDefaultValue("N/A");

            //modelBuilder.Entity<Employee>()
            //   .Property(e => e.FirstName)
            //   .HasDefaultValue("N/A");
            #endregion
            #region MappingClass
            ///modelBuilder.Entity<Department>()
            ///    .ToTable("DepartmentInfo", "dbo")
            ///    .HasKey(d => d.DeptId);
            ///modelBuilder.Entity<Department>()
            ///    .Property(d => d.DeptId)
            ///    .UseIdentityColumn(10, 10);
            ///modelBuilder.Entity<Department>()
            ///    .Property(d => d.Name)
            ///    .HasColumnName("DepartmentName")
            ///    .HasColumnType("nvarchar(50)")
            ///    .IsRequired();
            ///modelBuilder.Entity<Department>()
            ///    .Property(d => d.CreationDate)
            ///    .HasColumnType("Date")
            ///    .HasComputedColumnSql("GETDATE()");
            ///#region Shadow Property
            ///modelBuilder.Entity<Department>()
            ///    .Property<string>("Address")
            ///    .HasColumnType("nvarchar(100)")
            ///    .HasDefaultValue("Cairo");
            ///#endregion

            ////efcore 3.1 new feature
            //modelBuilder.Entity<Department>(builder =>
            //{
            //    builder.ToTable("DepartmentInfo", "dbo")
            //   .HasKey(d => d.DeptId);

            //    builder.Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //    builder.Property(d => d.Name)
            //        .HasColumnName("DepartmentName")
            //        .HasColumnType("nvarchar(50)")
            //        .IsRequired();

            //    builder.Property(d => d.CreationDate)
            //        .HasColumnType("Date")
            //        .HasComputedColumnSql("GETDATE()");

            //    builder.Property<string>("Address")
            //        .HasColumnType("nvarchar(100)")
            //        .HasDefaultValue("Cairo");
            //});

            #endregion
            #endregion

            #region 4. ConfigurationClass Per Entity => Organized 3rd way
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion
        }
    }
}
