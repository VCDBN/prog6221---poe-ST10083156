using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPOE
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string FoodGroup { get; set; }
        public double Calories { get; set; }
        public static List<Ingredient> ingredients {get; set;}
        public Ingredient()
        {
            ingredients = new List<Ingredient>();
        }
        public Ingredient(string name, double quantity, string unitOfMeasurement, string foodGroup, double calories) 
        {
            ingredients = new List<Ingredient>();
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            FoodGroup = foodGroup;
            Calories = calories;
            
        }

      
       
        public double totalCalories() 
        {
            double total = 0;

           
            foreach (Ingredient ingredient in Ingredient.ingredients)
            {
                 total = total + ingredient.Calories;
            }
            return total;
        }
    }
}
