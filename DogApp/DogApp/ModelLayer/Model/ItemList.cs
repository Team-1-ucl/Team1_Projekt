namespace DogApp.ModelLayer.Model;

public class ItemList
{

    public int Id { get; set; }

    public ICollection<Item> Items { get; set; }

    public int Number { get; set; }

    public ItemList()
    {
    }

  

}
