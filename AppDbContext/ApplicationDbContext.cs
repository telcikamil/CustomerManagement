using customerManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace customerManagement.AppDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = Guid.NewGuid(),
                Name = "Starbucks",
                IsMernisRequired = true
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = Guid.NewGuid(),
                Name = "Portal Kahve",
                IsMernisRequired = false
            });
        }
    }
}
