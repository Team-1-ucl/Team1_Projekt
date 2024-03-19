﻿using DogApp.Modellayer.Model.Items;
using Microsoft.EntityFrameworkCore;
using DogApp.Modellayer.Model;

namespace DogApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
      
        public DbSet<Rally> Rally {get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Placement> Placements { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           


            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Sign 1", Description = "Description of Sign 1", Image = "hest", ItemCategory = Item.Category.Sign },
                new Item { Id = 2, Name = "Sign 2", Description = "Description of Sign 2", Image = "hest", ItemCategory = Item.Category.Sign },
                new Item { Id = 3, Name = "Sign 3", Description = "Description of Sign 3", Image = "hest", ItemCategory = Item.Category.Sign },
                new Item { Id = 4, Name = "Sign 4", Description = "Description of Sign 4", Image = "hest", ItemCategory = Item.Category.Sign },
                new Item { Id = 5, Name = "Sign 5", Description = "Description of Sign 5", Image = "hest", ItemCategory = Item.Category.Sign },

                new Item { Id = 6, Name = "Extra 1", Description = "Description of Extra 1", Image = "hest", ItemCategory = Item.Category.Extra },
                new Item { Id = 7, Name = "Extra 2", Description = "Description of Extra 2", Image = "hest", ItemCategory = Item.Category.Extra },
                new Item { Id = 8, Name = "Extra 3", Description = "Description of Extra 3", Image = "hest", ItemCategory = Item.Category.Extra },
                new Item { Id = 9, Name = "Extra 4", Description = "Description of Extra 4", Image = "hest", ItemCategory = Item.Category.Extra },
                new Item { Id = 10, Name = "Extra 5", Description = "Description of Extra 5", Image = "hest", ItemCategory = Item.Category.Extra }
            );
        }
    }
}
