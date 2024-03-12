using DogApp.Modellayer.Model.Items;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogApp.Modellayer.Model
{
    public class ItemItemList
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int ItemListId { get; set; }

        public ItemList ItemList { get; set; }
    }
}