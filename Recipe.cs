using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppPOE
{
    public class Recipe
    {
        public string Name { get; set; }
       public static List<Recipe> recipes { get; set; }
        public List<Ingredient> Ingredients { get; set;}
        public List<Step> Steps { get; set;}
        public double TotalCalories{ get; set;}

        public Recipe() { recipes = new List<Recipe>(); }
        public Recipe(string name, List<Ingredient> ingredients, List<Step> steps, double totalCalories)
        {
            recipes = new List<Recipe>();
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
            TotalCalories = totalCalories;
        }
       
        public void addRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void clearRecipes()
        {
            recipes.Clear();
        }
    }
}
