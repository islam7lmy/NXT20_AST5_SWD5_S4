using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {

        #region DBSets
        public DbSet<Employee> Employees { get; set; }
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
    }
}
