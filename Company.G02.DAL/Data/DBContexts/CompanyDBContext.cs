using Company.G02.DAL.FOLDER_Models;
using Company.G02.DAL.FOLDER_Models.ModelEmployees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.DAL.Data.DBContexts
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //     {
        //         optionsBuilder.UseSqlServer("Server = . ; Database = CompanyG02 ; Trusted_connection = true TrustServerCertificate = true");
        //     }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }


}
