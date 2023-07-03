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
    /// Interaction logic for ViewRecipe.xaml
    /// </summary>
    public partial class ViewRecipe : Window
    {
        
        public ViewRecipe()
        {
            InitializeComponent();
            
            Recipe recipe1= new Recipe();
            foreach(Recipe recipe in Recipe.recipes) 
            {
                displayRecipesLbl.Content = recipe.Name;
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.Show();
            this.Close();
        }

        
    }
}
