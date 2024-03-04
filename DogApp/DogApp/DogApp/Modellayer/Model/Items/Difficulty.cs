namespace DogApp.Modellayer.Model.Items;
/// <summary>
/// In this case, a Difficulty object represents a difficulty level.
/// </summary>
public class Difficulty
{
    /// <summary>
    /// This property is to represent a
    /// unique identifier for the difficulty level. 
    /// </summary>

    public int Id { get; set; }

    /// <summary>
    ///  This property is of type string and stores the human-readable name 
    ///  of the difficulty level (e.g., "Easy", "Medium", "Hard").
    /// </summary>
    public string Name { get; set; }
}