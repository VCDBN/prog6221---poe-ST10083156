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
    /// Interaction logic for SpecificRecipeViewer.xaml
    /// </summary>
    public partial class SpecificRecipeViewer : Window
    {
        public SpecificRecipeViewer()
        {
            InitializeComponent();
        }

        private void specificRecipeConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            Recipe recipe1 = new Recipe();
            foreach(Recipe recipe in Recipe.recipes)
            {
                if(specificRecipeTxt.Text == recipe.Name)
                {
                    MessageBox.Show($"Recipe Name: {recipe.Name} \nIngredients: {recipe.Ingredients} \nSteps: {recipe.Steps}");
                }
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.Show();
            this.Close();
        }
    }
}
