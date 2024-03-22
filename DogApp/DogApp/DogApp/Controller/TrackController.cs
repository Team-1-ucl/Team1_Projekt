using DogApp.Components.Pages;
using DogApp.Modellayer.EntityModels;
using DogApp.Modellayer.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace DogApp.Controller
{

    public class TrackController
    {

        private readonly ITrackRepo _trackRepository;

        public TrackController(ITrackRepo trackRepository)
        {
            _trackRepository = trackRepository;
        }

        public async Task<List<Track>> GetAllTracksAsync()
        {
            return await _trackRepository.GetAllAsync();
        }

        public async Task DeleteItem(Track track)
        {
            await _trackRepository.DeleteAsync(track);
        }

        public async Task<Track?> GetByIdAsync(int Id)
        {
            return await _trackRepository.GetByIdAsync(Id);
        }

        public async Task UpdateAsync(Track track)
        {

            await _trackRepository.UpdateAsync(track);
        }
        
    }
}
