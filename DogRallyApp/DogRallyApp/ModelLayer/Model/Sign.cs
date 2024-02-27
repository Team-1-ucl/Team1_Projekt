namespace DogRallyApp.ModelLayer.Model;

public class Sign : Item
{
    public Placement Placement { get; set; }
    public Difficulty Difficulty { get; set; }  

    public int Id {  get; set; }
    public int Number { get; set; }
    public string Description { get; set; }
    public string Image {  get; set; }
}

