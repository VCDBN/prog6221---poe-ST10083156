using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeAppPOE
{
    /// <summary>
    /// Interaction logic for FoodGroupFilter.xaml
    /// </summary>
    public partial class FoodGroupFilter : Window
    {
        public FoodGroupFilter()
        {
            InitializeComponent();
        }

        private void confirmFilterBtn_Click(object sender, RoutedEventArgs e)
        {
            string display = "";
            foreach(Recipe recipe in Recipe.recipes)
            {
                List<Ingredient> recipeIngredients = recipe.Ingredients;
                    foreach (Ingredient ingredient in recipeIngredients) 
                {
                    if (ingredient.FoodGroup == filterTxt.Text) 
                    { display = display + "\n"+recipe.Name; 
                    }
                }
                  
            }
            MessageBox.Show(display, "Filtered List", MessageBoxButton.OK);

            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.Show();
            this.Close();
        }
    }
}
