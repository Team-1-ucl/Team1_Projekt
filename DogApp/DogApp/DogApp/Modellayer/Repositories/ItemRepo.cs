using DogApp.Data;
using DogApp.Modellayer.EntityModels;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class ItemRepo : GenericRepository<Item>
{
    public ItemRepo(DataContext context) : base(context)
    {
    }
}