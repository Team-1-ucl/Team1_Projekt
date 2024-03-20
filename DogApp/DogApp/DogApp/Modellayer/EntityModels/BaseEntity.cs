using DogApp.Modellayer.Model;

namespace DogApp.Modellayer.EntityModels;

/// <summary>
/// Represents a base item within the application.
/// This class serves as a foundation for other item types.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the item.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Gets or sets the name property for the placement of the item.
    /// </summary>
    public string Name { get; set; }
    
    
}