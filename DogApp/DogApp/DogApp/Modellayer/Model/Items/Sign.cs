namespace DogApp.Modellayer.Model.Items;

/// <summary>
/// Represents a sign within the application. 
/// Inherits from the base Item class.
/// </summary>
public class Sign : Item
{
    /// <summary>
    /// Gets or sets the difficulty level of the sign.
    /// </summary>
    public Difficulty? Difficulty { get; set; }
    /// <summary>
    /// Gets or sets the number associated with the sign.
    /// </summary>
    public int Number { get; set; }

}
