using DogApp.Modellayer.Model.Items;
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
        public DbSet<DateCreate> DatesCreate {get; set;}
        public DbSet<ItemList> ItemLists {get; set;}
        public DbSet<Placement> Placements { get; set; }
        public DbSet<ItemItemList> ItemItemLists { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemItemList>()
                .HasKey(il => new { il.ItemId, il.ItemListId });

            modelBuilder.Entity<ItemItemList>()
                .HasOne(il => il.Item)
                .WithMany(i => i.ItemItemLists)
                .HasForeignKey(il => il.ItemId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ItemItemList>()
                .HasOne(il => il.ItemList)
                .WithMany(il => il.ItemItemLists)
                .HasForeignKey(il => il.ItemListId);


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
            // Seed data for ItemList entity
            modelBuilder.Entity<ItemList>().HasData(
                new ItemList { Id = 1 },
                new ItemList { Id = 2 },
                new ItemList { Id = 3 }
            );

            // Seed data for ItemListItemList entity
            modelBuilder.Entity<ItemItemList>().HasData(
                // ItemList 1 uses items 1, 2, and 3
                new ItemItemList { Id = 1, ItemId = 1, ItemListId = 1 },
                new ItemItemList { Id = 2, ItemId = 2, ItemListId = 1 },
                new ItemItemList { Id = 3, ItemId = 3, ItemListId = 1 },
                
                // ItemList 2 uses items 4, 5, and 6
                new ItemItemList { Id = 4, ItemId = 4, ItemListId = 2 },
                new ItemItemList { Id = 5, ItemId = 5, ItemListId = 2 },
                new ItemItemList { Id = 6, ItemId = 6, ItemListId = 2 },

                // ItemList 3 uses items 7, 8, and 9
                new ItemItemList { Id = 7, ItemId = 7, ItemListId = 3 },
                new ItemItemList { Id = 8, ItemId = 8, ItemListId = 3 },
                new ItemItemList { Id = 9, ItemId = 9, ItemListId = 3 }
            );
        }
    }
}
