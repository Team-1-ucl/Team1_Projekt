using DogApp.Data;
using DogApp.Modellayer.EntityModels;
using DogApp.Modellayer.Model;
using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class TrackRepo : GenericRepository<Track>
{
    public TrackRepo(DataContext context) : base(context)
    {
    }
}