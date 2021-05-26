using System;
using System.Linq;
using Exercise4MVC.Models;

namespace Exercise4MVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(FoodContext context) {

            context.Database.EnsureCreated();

            if (context.Foods.Any())
            {
                return;
            }

            var foods = new Food[]
            {
                new Food{FoodName="Muncher",FoodType="Snack",FoodDescription="Green Peas",ExpiryDate=DateTime.Parse("2021-05-21")},
                new Food{FoodName="Chippy",FoodType="Snack",FoodDescription="Chili Cheese",ExpiryDate=DateTime.Parse("2022-01-15")},
                new Food{FoodName="Fish Crackers",FoodType="Snack",FoodDescription="2% Fish added",ExpiryDate=DateTime.Parse("2021-08-09")},
                new Food{FoodName="Cracklings",FoodType="Snack",FoodDescription="Salt and Vinegar",ExpiryDate=DateTime.Parse("2021-10-04")},
            };
            foreach (Food f in foods)
            {
                context.Foods.Add(f);
            }
            context.SaveChanges();
        }
    }
}
