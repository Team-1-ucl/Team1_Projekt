using DogApp.Data;
using DogApp.Modellayer.Model.Items;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class SignRepo : GenericRepository<Sign>
{
    public SignRepo(DataContext context) : base(context)
    {
    }
}