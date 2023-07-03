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
    /// Interaction logic for StepsWindow.xaml
    /// </summary>
    public partial class StepsWindow : Window
    {
        int stepNum=1;
        int repetitions = Ingredients_StepsAmount.numSteps;
        public StepsWindow()
        {
            InitializeComponent();
        }

        private void addStepBtn_Click(object sender, RoutedEventArgs e)
        {
            Ingredients_StepsAmount.recipeNum--;
  
            repetitions--;

            if (repetitions > 0)
            {
                
                string recipeStep = stepTxt.Text;
                Step step = new Step(recipeStep);
                Step.steps.Add(step);
                MessageBox.Show($"Step number {stepNum} added!", "Success");
                stepNum++;
                stepTxt.Clear();
                
            }
            else 
            {
                MessageBox.Show($"Step number {stepNum} added!", "Success");

                MessageBox.Show($"{Ingredients_StepsAmount.numIngredients} ingredients added, and {Ingredients_StepsAmount.numSteps} added to recipe.", "Recipe Added", MessageBoxButton.OK);
                Ingredient ingredient = new Ingredient();
                Recipe recipe = new Recipe(Ingredients_StepsAmount.recipeName, Ingredient.ingredients, Step.steps, ingredient.totalCalories());
              Ingredients_StepsAmount ingredients_StepsAmount = new Ingredients_StepsAmount();
                Step step = new Step();
                Ingredient.ingredients.Clear();
                Step.steps.Clear();
                if (Ingredients_StepsAmount.recipeNum > 0) 
                {
                    this.Hide();
                    ingredients_StepsAmount.Show();
                    this.Close();
                }
                else 
                {
                    MenuWindow menuWindow = new MenuWindow();
                    this.Hide();
                    menuWindow.Show();
                    this.Close();
                }
                

            }

        }
    }
}
