using DogApp.Modellayer;
using DogApp.Modellayer.Model.Items;

namespace DogAppTest;

public class ItemTest 
{
    [Fact]
    public void ItemCreate_ShouldCreate()
    {
        //arrange
        var difficulty1 = new Difficulty { Name =  "open"};
        //Act
        var item = new Sign 
        { 
            Id = 1,
            Name = "højre om",
            Description = "hund skal løbe højre om keglen", 
            Image = "en fisk", 
            PlacementId = 1, 
            Difficulty = difficulty1, 
            Number = 1 
        };

        // Assert
        Assert.Equal(item.Difficulty, difficulty1);
        Assert.Equal(item.Number, 1);
        Assert.Equal(item.Id, 1);
    }
    [Fact]
    public void ExtraCreate_ShouldCreate()
    {
        //arrange 
        var placement = new Placement { PlacementId = 1 , X = 1, Y = 2 };

        // act
        var extra = new Extra
        {
            Id = 1,
            Name = "tunnel",
            Description = "hund løber igennem tunnel",
            Image = "zoomies",
            PlacementId = placement.PlacementId,
            
        };

        //assert
        Assert.Equal("tunnel" , extra.Name);
        Assert.Equal(1 , extra.PlacementId);
        Assert.Matches(extra.Image, "zoomies");

    }

	[Fact]
	public void ItemUpdate_ShouldUpdate()
	{
		//arrange
		var difficulty1 = new Difficulty { Name = "open" };

		var item = new Sign
		{
			Id = 1,
			Name = "højre om",
			Description = "hund skal løbe højre om keglen",
			Image = "en fisk",
			PlacementId = 1,
			Difficulty = difficulty1,
			Number = 1
		};

        item.Number = 2;
        item.Image = "en hund";

		// Assert
		Assert.Equal(item.Difficulty, difficulty1);
		Assert.Equal(2, item.Number);
		Assert.Equal("en hund",item.Image);
	}
}