using DogApp.Modellayer.Model.Items;
using Microsoft.EntityFrameworkCore;

namespace DogApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Sign> Signs { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Extra> Extra { get; set; }
        public DbSet<Placement> Placements { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Difficulty entity
            modelBuilder.Entity<Difficulty>().HasData(
                new Difficulty { Id = 1, Name = "Open" },
                new Difficulty { Id = 2, Name = "Beginner" },
                new Difficulty { Id = 3, Name = "Expert" },
                new Difficulty { Id = 4, Name = "Champion" }
            );
        }




    }
}
