//using DogApp.Modellayer;
//using DogApp.Modellayer.Model.Items;
//namespace DogAppTest;
//public class ItemTest
//{
//    [Fact]
//    public void SignItemCreate_ShouldCreate()
//    {
//        // Arrange
//        var item = new Item
//        {
//            Id = 1,
//            Name = "højre om",
//            Description = "hund skal løbe højre om keglen",
//            Image = "en fisk",
//            PlacementId = 1,
//            ItemCategory = Item.Category.Sign,
           
//        };
//        // Act
//        //// Assert
//        Assert.Equal("højre om", item.Name);
//        Assert.Equal(Item.Category.Sign, item.ItemCategory);
   
//        Assert.Equal(1, item.PlacementId);
//        // Add more assertions as needed
//    }
//    [Fact]
//    public void ExtraItemCreate_ShouldCreate()
//    {
//        // Arrange
//        var item = new Item
//        {
//            Id = 2,
//            Name = "extra item name",
//            Description = "extra item description",
//            Image = "extra item image",
//            PlacementId = 2,
//            ItemCategory = Item.Category.Extra,
//        };   
//        // Act
//        // Assert
//        Assert.Equal("extra item name", item.Name);
//        Assert.Equal(Item.Category.Extra, item.ItemCategory);
        
//        Assert.Equal(2, item.PlacementId);
//        // Add more assertions as needed
//    }
//    [Fact]
//    public void ItemUpdate_ShouldUpdate()
//    {
//        //arrange
        
//        var item = new Item
//        {
//            Id = 1,
//            Name = "højre om",
//            Description = "hund skal løbe højre om keglen",
//            Image = "en fisk",
//            PlacementId = 1,
         
//        };
       
//        item.Image = "en hund";
//        // Assert
       
//        Assert.Equal("en hund", item.Image);
//    }
//}