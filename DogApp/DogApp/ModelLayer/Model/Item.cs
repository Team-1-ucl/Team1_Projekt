namespace DogApp.ModelLayer.Model;

public abstract class Item
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public Placement Placement { get; set; }
}
