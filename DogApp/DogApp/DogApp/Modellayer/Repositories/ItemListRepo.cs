using DogApp.Data;
using DogApp.Modellayer.Model;
using DogApp.Modellayer.Model.Items;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class ItemListRepo : GenericRepository<ItemList>
{
    public ItemListRepo(DataContext context) : base(context)
    {
    }
}