// using DogApp.Modellayer;
// using DogApp.Modellayer.Model;
// using DogApp.Modellayer.Model.Items;
// using DogApp.ModelLayer;
// using Microsoft.AspNetCore.Routing;
// using System.Diagnostics;

// namespace DogAppTest;

// public class ItemListTest
// {
//     [Fact]
//     public void ItemListCreate_ShouldCreate()
//     {
//         //arrange


//         var item1 = new Item
//         {
//             Id = 1,
//             Name = "højre om",
//             Description = "hund skal løbe højre om keglen",
//             Image = "en fisk",
//             PlacementId = 1,
           
            
//         };
//         var item2 = new Item
//         {
//             Id = 2,
//             Name = "Venstre om",
//             Description = "hund skal løbe højre om keglen",
//             Image = "en fisk",
//             PlacementId = 1,
           
           
//         };
//         var item3 = new Item
//         {
//             Id = 3,
//             Name = "GERADE AUS",
//             Description = "hund skal stå stille",
//             Image = "en fisk",
//             PlacementId = 1,
            
           
//         };
//         var item4 = new Item
//         {
//             Id = 4,
//             Name = "LINKS",
//             Description = "hund skal GÅ TIL HØJRE",
//             Image = "en fisk",
//             PlacementId = 1,
            
            

//         };

//         //Act

//         var itemList = new ItemList
//         {
//             Id = 1,
//             Number = 1,
//             Items = new List<Item> { item1, item2, item3, item4 }

//         };

//         //assert
//         Assert.Equal(4, itemList.Items.Count);
//         Assert.Equal(2, itemList.Items.ElementAt(1).Id);

//     }




//     [Fact]
//     public void ItemListCreate_AddToList_ShouldCreateExpectedList()
//     {
//         // Arrange
       
//         var itemList = new ItemList
//         {
//             Id = 1,
//             Number = 1,
//             Items = new List<Item>
//             {
//                 new Item
//                 {
//                     Id = 1,
//                     Name = "Venstre om",
//                     Description = "Hunden skal løbe højre om keglen.",
//                     Image = "en fisk",
//                     PlacementId = 1,
                  
                    
//                 },
//                 // Add more items as needed
//             }
//         };

//         // Act
//         itemList.Items.Add(new Item
//         {
//             Id = 2,
//             Name = "Højre om",
//             Description = "Hunden skal løbe højre om keglen.",
//             Image = "en fisk",
//             PlacementId = 1,
         
            
//         });
//         itemList.Items.Add(new Item
//         {
//             Id = 3,
//             Name = "Højre om",
//             Description = "Hunden skal løbe højre om keglen.",
//             Image = "en fisk",
//             PlacementId = 1,
            
//         });

//         int højreOmCount = itemList.Items.Count(item => item.Name == "Højre om");

//         //Assert
//         Assert.Equal(3, itemList.Items.Count);
//         Assert.Equal(2, højreOmCount);
//         Assert.Single(itemList.Items, item => item.Name == "Venstre om");




//     }

// }




