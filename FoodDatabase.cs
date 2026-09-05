using System;
using System.Collections.Generic;

namespace NutritionCalculator
{
    public class FoodItem
    {
        public string Name { get; set; }
        public double Energy { get; set; }        // kcal per 100g
        public double Protein { get; set; }       // grams per 100g
        public double Fat { get; set; }           // grams per 100g
        public double Carbohydrates { get; set; } // grams per 100g
    }

    public class FoodDatabase
    {
        private static List<FoodItem> foodItems = new List<FoodItem>
        {
            new FoodItem
            {
                Name = "Beef (lean)",
                Energy = 250,
                Protein = 26,
                Fat = 17,
                Carbohydrates = 0
            },
            new FoodItem
            {
                Name = "Chicken (skinless breast)",
                Energy = 165,
                Protein = 31,
                Fat = 3.6,
                Carbohydrates = 0
            },
            new FoodItem
            {
                Name = "Fish (Salmon, cooked)",
                Energy = 206,
                Protein = 22,
                Fat = 13,
                Carbohydrates = 0
            },
            new FoodItem
            {
                Name = "Egg (whole, boiled)",
                Energy = 155,
                Protein = 13,
                Fat = 11,
                Carbohydrates = 1.1
            },
            new FoodItem
            {
                Name = "Mutton (cooked, lean)",
                Energy = 250,
                Protein = 25,
                Fat = 17,
                Carbohydrates = 0
            }
        };

        public static List<FoodItem> GetAllFoods()
        {
            return foodItems;
        }

        public static FoodItem GetFoodByName(string name)
        {
            return foodItems.Find(f => f.Name == name);
        }
    }
}
