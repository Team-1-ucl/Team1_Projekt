using DogApp.Modellayer.Model;

namespace DogApp.Modellayer.EntityModels;


/// <summary>
/// Represents a base item within the application.
/// This class serves as a foundation for other item types.
/// </summary>
public class Item :BaseEntity
{
   
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
    public ICollection<TrackItem> TrackItems { get; set; }

    public Item()
    {

    }
    public Item(int id, string name)
    {

    }
}