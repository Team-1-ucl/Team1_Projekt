using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogApp.ModelLayer.Model;

namespace DogApp.Data
{
    public class DogAppContext : DbContext
    {
        public DogAppContext (DbContextOptions<DogAppContext> options)
            : base(options)
        {
        }
        public DbSet<DateCreate> Dates { get; set; } = default!;
        public DbSet<Placement> Placements { get; set; } = default!;
        public DbSet<Rally> Rallies { get; set; } = default!;
        public DbSet<Sign> Signs { get; set; } = default!;
        public DbSet<ItemList> ItemLists { get; set; } = default!;
        public DbSet<Extra> Extras { get; set; } = default!;
        public DbSet<Difficulty> Difficulties { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rally>().ToTable("Rally");
            modelBuilder.Entity<DateCreate>().ToTable("Date");
            modelBuilder.Entity<Placement>().ToTable("Placement");
            modelBuilder.Entity<Sign>().ToTable("Sign");
            modelBuilder.Entity<ItemList>().ToTable("ItemList");
            modelBuilder.Entity<Extra>().ToTable("Extra");
            modelBuilder.Entity<Difficulty>().ToTable("Difficulty");



        }

    }
}
