using DogApp.Modellayer.Model;
namespace DogApp.Modellayer.Model.Items
{
    /// <summary>
    /// Represents a base item within the application.
    /// This class serves as a foundation for other item types.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the unique identifier for the item.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name property for the placement of the item.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the description of the item.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the path to an image representing the item.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Gets or sets the foreign key referencing the placement of the item.
        /// </summary>
        public enum Category { Sign, Extra }
        public Category ItemCategory { get; set; }
       
        // public int PlacementId { get; set; }
        // /// <summary>
        // /// Gets or sets the navigation property for the placement of the item.
        // /// </summary>
        // public Placement Placement { get; set; }
        /// <summary>
        /// Gets or sets the navigation property for the item list the item belongs to.
        /// </summary>
        public ICollection<ItemItemList> ItemItemLists { get; set; }
    }
}