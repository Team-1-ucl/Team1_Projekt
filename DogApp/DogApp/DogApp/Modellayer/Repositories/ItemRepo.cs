using DogApp.Data;
using DogApp.Modellayer.EntityModels;
using DogApp.ModelLayer.Repositories;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class ItemRepo : GenericRepository<Item>, IItemRepo
{
    public ItemRepo(DataContext context) : base(context)
    {
    }

}
