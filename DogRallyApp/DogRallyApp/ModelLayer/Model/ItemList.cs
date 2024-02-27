namespace DogRallyApp.ModelLayer.Model;

public class ItemList
{
	
	public int Id { get; set; }

	public List<Item> Items { get; set; } = new();

	public int Number { get; set; }
	public Sign Sign { get; set; }
	public Extra Extra { get; set; }
	public Item Item { get; set; }

	public ItemList()
	{
	}

	public List<Item> SortingItemList()
	{
		return Items.OrderBy(item => Sign.Number).ToList();
	}

}
