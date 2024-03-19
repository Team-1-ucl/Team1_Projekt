using DogApp.Data;
using DogApp.Modellayer.Model.Items;
using DogApp.Modellayer.Repositories;
using DogApp.ModelLayer.Repositories;
using Microsoft.EntityFrameworkCore;


namespace DogAppTest
{
    public class ItemRepositoryTest
    {
        private ItemRepo _itemRepository;
        private readonly DataContext _context;

        public ItemRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Web;Trusted_Connection=True;MultipleActiveResultSets=true;")
                 .Options;
            _context = new DataContext(options);
            _itemRepository = new ItemRepo(_context);
        }

        [Fact]
        public async Task CreateItem_ShouldCreate()
        {
            // arrange
            var item = new Item { Name = "Sign 1", Description = "Description of Sign 1", Image = "hest", ItemCategory = Item.Category.Sign };

            // act
            await _itemRepository.AddAsync(item);

            // assert
            Assert.Equal("hest", item.Image);
        }
        [Fact]
        public async Task UpdateItem_ShouldUpdate()
        {
            var item = new Item { Name = "Sign 1", Description = "Description of Sign 1", Image = "hest", ItemCategory = Item.Category.Sign };

            await _itemRepository.AddAsync(item);

            item.Image = "hund";
            await _itemRepository.UpdateAsync(item);

            Assert.Equal("hund", item.Image);
        }
    }
}
