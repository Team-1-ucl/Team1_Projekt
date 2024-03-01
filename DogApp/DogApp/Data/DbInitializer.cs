using DogApp.ModelLayer.Model;

namespace DogApp.Data;


public class DbInitializer
{

    public static void Initialize(DogAppContext context)
    {
        // Look for any students.
        if (context.Rallies.Any() || context.Signs.Any() || context.Difficulties.Any())
        {
            return;   // DB has been seeded
        }

        var rallies = new Rally[]
        {
        new Rally { Name = "First Rally", Height = 10, Width = 20, Category = "Beginner" },
        new Rally { Name = "Second Rally", Height = 15, Width = 25, Category = "Intermediate" },
        new Rally { Name = "Third Rally", Height = 12, Width = 22, Category = "Advanced" },
        new Rally { Name = "Fourth Rally", Height = 18, Width = 30, Category = "Expert" }
        };


        var dificulties = new Difficulty[]
        {
            new Difficulty { Name = "Open"},
            new Difficulty { Name = "Beginner"},
            new Difficulty { Name = "Intermediate"},
            new Difficulty { Name = "Advanced"},
            new Difficulty { Name = "Expert"},
        };

        var signs = new Sign[]
        {
        new Sign { Number = 1, Description = "Description for Sign 1", Image = "image1.jpg", Difficulty = dificulties[0] },
        new Sign { Number = 2, Description = "Description for Sign 2", Image = "image2.jpg", Difficulty = dificulties[1] },
        new Sign { Number = 3, Description = "Description for Sign 3", Image = "image3.jpg", Difficulty = dificulties[2] },
        new Sign { Number = 4, Description = "Description for Sign 4", Image = "image4.jpg", Difficulty = dificulties[3] },
        new Sign { Number = 5, Description = "Description for Sign 5", Image = "image5.jpg", Difficulty = dificulties[4] }
        };


        context.Rallies.AddRange(rallies);
        context.Difficulties.AddRange(dificulties);
        context.Signs.AddRange(signs);
        context.SaveChanges();

    }
}

