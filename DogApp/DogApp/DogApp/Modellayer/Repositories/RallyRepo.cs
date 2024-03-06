using DogApp.Data;
using DogApp.Modellayer.Model;
using DogApp.Modellayer.Model.Items;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class RallyRepo : GenericRepository<Rally>
{
    public RallyRepo(DataContext context) : base(context)
    {
    }
}