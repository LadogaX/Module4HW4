using Microsoft.EntityFrameworkCore;
using Module4HW4.Entities;
using Module4HW4.EntityConfigurations;

namespace Module4HW4
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        {
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<OfficeEntity> Office { get; set; }

        public DbSet<TitleEntity> Title { get; set; }

        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<EmployeeProjectEntity> EmployeeProjects { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
    }
}
