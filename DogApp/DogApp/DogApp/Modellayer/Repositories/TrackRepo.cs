using DogApp.Data;
using DogApp.Modellayer.EntityModels;

using DogRallyApp.ModelLayer.Repositories;

namespace DogApp.Modellayer.Repositories;

public class TrackRepo : GenericRepository<Track>, ITrackRepo
{
    public TrackRepo(DataContext context) : base(context)
    {
    }
}