using System.ComponentModel.DataAnnotations;

namespace DogApp.Modellayer.Model.Items;
/// <summary>
/// Represents the placement of an item within the application.
/// </summary>
public class Placement
{
    /// <summary>
    /// Gets or sets the unique identifier for the placement.
    /// </summary>
    [Key]
    public int PlacementId { get; set; }
    /// <summary>
    /// Gets or sets the Y-coordinate of the placement.
    /// </summary>
    public int Y { get; set; }
    /// <summary>
    /// Gets or sets the X-coordinate of the placement.
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Gets a collection of items associated with this placement.
    /// May be null if no items are linked.
    /// </summary>
    public ICollection<Item>? Items { get; set; }
}
