using DogApp.Modellayer.Model.Items;
using System.Collections.ObjectModel;

namespace DogApp.Modellayer.Model;

/// <summary>
/// This class represents a Rally in an application. 
/// 
/// Rallies likely refer to a collection of items or data points with some sort of spatial or organizational relationship.
/// </summary>
public class Rally
{
    /// <summary>
    /// Unique identifier for the rally.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Human-readable name of the rally.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Height of the rally (likely in pixels or some other unit).
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Width of the rally (likely in pixels or some other unit).
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// An ItemList object containing items associated with the rally.
    /// </summary>
    public Collection<Item> Items  { get; set; }

    /// <summary>
    /// The category of the rally.
    /// </summary>
    public string Category { get; set; }

    // Default constructor
    public Rally()
    {
    }

}
