using DogApp.Data;
using DogApp.Modellayer.EntityModels;
using DogApp.Modellayer.Model;
using DogApp.Modellayer.Repositories;
using Microsoft.EntityFrameworkCore;


namespace DogAppTest
{
    public class TrackRepoTest
    {
        private TrackRepo _trackRepository;
        private readonly DataContext _context;

        public TrackRepoTest()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Web;Trusted_Connection=True;MultipleActiveResultSets=true;")
                 .Options;
            _context = new DataContext(options);
            _trackRepository = new TrackRepo(_context);
        }

        [Fact]
        public async Task CreateItem_ShouldCreate()
        {
            // arrange
            var track = new Track {Name ="Bane 1", Height = 10 , Width = 10, Category = "Open"};

            // act
            await _trackRepository.AddAsync(track);
            await _context.SaveChangesAsync();
            // assert
            Assert.Equal("Bane 1", track.Name);
        }
    }
}
