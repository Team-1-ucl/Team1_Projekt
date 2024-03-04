using Microsoft.EntityFrameworkCore;

namespace DogApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
        {
        }
    }
}
