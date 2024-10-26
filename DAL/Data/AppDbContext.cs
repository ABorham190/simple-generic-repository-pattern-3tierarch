using Microsoft.EntityFrameworkCore;
using simple_api_generic_repo.DAL.Data.Entities;

namespace simple_api_generic_repo.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department>Departments { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
