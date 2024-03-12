using DogApp.Data;
using DogApp.Modellayer.Model;
using DogApp.Modellayer.Model.Items;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class ItemRepo : GenericRepository<Item>
{
    public ItemRepo(DataContext context) : base(context)
    {
    }
}