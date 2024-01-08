using Microsoft.EntityFrameworkCore;
using TasksList.Models;

namespace TasksList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>( e => 
            {
                e.HasKey(t => t.Id);

                e.Property(t => t.Title).IsRequired()
                .HasMaxLength(50);

                e.Property(t => t.Description).IsRequired(false)
                .HasMaxLength(300);

                e.Property(t => t.Status).IsRequired(true);

            });
        }
    }
}
