namespace DogApp.ModelLayer.Model;

public class Rally
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public ItemList ItemList { get; set; }
    public DateCreate Date { get; set; }
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
