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
    /// Interaction logic for IngredientsWindow.xaml
    /// </summary>
    public partial class IngredientsWindow : Window
    {

         int repetitions = Ingredients_StepsAmount.numIngredients;
        int ingNum = 1;
        public IngredientsWindow()
        {
            InitializeComponent();
        }

        private void ingredientConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            repetitions--;


            string name;
            double quantity;
            string unitOfMeasurement;
            string foodGroup;
            double calories;

            if (repetitions > 0)
            {
                if (nameTxt.Text == null)
                {
                    MessageBox.Show("Please fill in all the fields for the ingredient you would like to add.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (quantityTxt.Text == null)
                {
                    MessageBox.Show("Please fill in all the fields for the ingredient you would like to add.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (unitTxt.Text == null)
                {
                    MessageBox.Show("Please fill in all the fields for the ingredient you would like to add.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (foodGroupTxt.Text == null)
                {
                    MessageBox.Show("Please fill in all the fields for the ingredient you would like to add.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (caloriesTxt.Text == null)
                {
                    MessageBox.Show("Please fill in all the fields for the ingredient you would like to add.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                name = nameTxt.Text;

                try { quantity = Convert.ToDouble(quantityTxt.Text); }
                catch (Exception exception)
                {
                    MessageBox.Show("Quantity value error: " + exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                unitOfMeasurement = unitTxt.Text;
                foodGroup = foodGroupTxt.Text;
                try { calories = Convert.ToDouble(caloriesTxt.Text); }
                catch (Exception exception)
                {
                    MessageBox.Show("Calories value error: " + exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Ingredient ingredient = new Ingredient(name, quantity, unitOfMeasurement, foodGroup, calories);
                Ingredient.ingredients.Add(ingredient);
                if (ingredient.totalCalories() > 300) { MessageBox.Show("This recipe's calories have exceeded 300!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
                MessageBox.Show($"Ingredient number {ingNum} added!", "Success");
                ingNum++;
                nameTxt.Clear();
                quantityTxt.Clear();
                unitTxt.Clear();
                foodGroupTxt.Clear();
                caloriesTxt.Clear();
                
            }

            else
            {

                StepsWindow stepsWindow = new StepsWindow();
                this.Hide();
                stepsWindow.Show();
                this.Close();
                

            }
        }
    }
}
