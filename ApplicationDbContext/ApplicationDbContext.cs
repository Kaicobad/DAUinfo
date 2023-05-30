using DAUinfo.Model;
using Microsoft.EntityFrameworkCore;

namespace DAUinfo.ApplicationDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(e => e.Id);
        }

        public DbSet<User> User { get; set; }
    }
}
