using Microsoft.EntityFrameworkCore;
using git_build.Data;

namespace git_build.Data.Database
{
    public class LibDbContext : DbContext
    {
        public DbSet<Books_in_store> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books_in_store>()
                .HasKey(b => b.ISBN);
        }
    }
}