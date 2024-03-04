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
    public ItemList ItemList { get; set; }

    /// <summary>
    /// A DateCreate object representing the date the rally was created.
    /// </summary>
    public DateCreate Date { get; set; }

    /// <summary>
    /// The category of the rally.
    /// </summary>
    public string Category { get; set; }

    // Default constructor
    public Rally()
    {
    }

    // Constructor that initializes all properties
    public Rally(int id, string name, int height, int width, ItemList itemlist, DateCreate date, string category)
    {
        Id = id;
        Name = name;
        Height = height;
        Width = width;
        ItemList = itemlist;
        Date = date;
        Category = category;
    }
}
