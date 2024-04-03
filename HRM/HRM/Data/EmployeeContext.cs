using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
