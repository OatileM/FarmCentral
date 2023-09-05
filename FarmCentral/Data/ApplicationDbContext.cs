using FarmCentral.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmCentral.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //DB Sets that represent the models that will be created inside the database
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Employee> Employees { get; set; }


    }
    
}
    
