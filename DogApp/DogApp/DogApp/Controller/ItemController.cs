using DogApp.Components.Pages;
using DogApp.Modellayer.EntityModels;
using DogApp.Modellayer.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace DogApp.Controller
{

    public class ItemController
    {

        private readonly IItemRepo _itemRepository;

        public ItemController(IItemRepo itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            return await _itemRepository.GetAllAsync();
        }

        public async Task DeleteItem(Item item)
        {
            await _itemRepository.DeleteAsync(item);
        }

        public async Task<Item?> GetByIdAsync(int Id)
        {
            return await _itemRepository.GetByIdAsync(Id);
        }

        public async Task UpdateAsync(Item item)
        {

            await _itemRepository.UpdateAsync(item);
        }
        
    }
}
