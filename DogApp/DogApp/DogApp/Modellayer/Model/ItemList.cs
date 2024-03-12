using DogApp.Modellayer.Model.Items;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogApp.Modellayer.Model;
/// <summary>
/// This class represents a collection of items, likely used in association with a Rally object.
/// </summary>
public class ItemList
{
    /// <summary>
    /// Unique identifier for the item list. This property is likely marked with a `[Key]` attribute 
    /// indicating it's the primary key for the database table representing item lists.
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// An identifier used for the item list itself, separate from the unique Id. 
    /// The purpose of this property depends on your specific application logic.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// A collection of Item objects associated with this item list. This property is likely marked with a 
    /// `[ForeignKey("Id")]` attribute indicating it references the Id property of the Item class, 
    /// establishing a one-to-many relationship between ItemList and Item objects.
    /// </summary>
        
        
    /// <summary>
    /// Default constructor for the ItemList class. It initializes the Items collection with a new List object.
    /// </summary>
    public ItemList()
    {
        ItemItemLists = new List<ItemItemList>();
    }

    [ForeignKey("Id")]
    public ICollection<ItemItemList> ItemItemLists { get; set; }

}