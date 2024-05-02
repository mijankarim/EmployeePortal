using EmployeePortal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;

namespace EmployeePortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
