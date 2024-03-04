using DogApp.Data;
using DogApp.Modellayer.Model.Items;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class ExtraRepo : GenericRepository<Extra>
{
    public ExtraRepo(DataContext context) : base(context)
    {
    }
}