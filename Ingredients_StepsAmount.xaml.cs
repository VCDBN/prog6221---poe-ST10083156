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
    /// Interaction logic for Ingredients_StepsAmount.xaml
    /// </summary>
    public partial class Ingredients_StepsAmount : Window
    {
        public static string recipeName { get; set; }
        public static int numIngredients { get; set; }
        public static int numSteps { get; set; }
        public static int recipeNum = RecipeAmount.numRecipes;
        public Ingredients_StepsAmount()
        {
            InitializeComponent();
        }

        private void numConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            
           recipeName = recipeNameTxt.Text.ToString().Trim();
            try { numIngredients = Convert.ToInt32(numIngredientsTxt.Text); }
            catch(Exception exception) 
            {
                MessageBox.Show("Number of ingredients error: " + exception.Message, "Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            try { numSteps = Convert.ToInt32(numStepsTxt.Text); }
            catch (Exception exception)
            {
                MessageBox.Show("Number of steps error: " + exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            IngredientsWindow ingredientsWindow = new IngredientsWindow();
            this.Hide();
            ingredientsWindow.Show();
            this.Close();
        }
    }
}
