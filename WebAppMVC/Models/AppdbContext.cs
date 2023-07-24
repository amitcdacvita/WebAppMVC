using Microsoft.EntityFrameworkCore;

namespace WebAppMVC.Models
{
    public class AppdbContext : DbContext
    {

        public AppdbContext(DbContextOptions<AppdbContext> options)
             : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
