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
    /// Interaction logic for RecipeAmount.xaml
    /// </summary>
    public partial class RecipeAmount : Window
    {
        public static int numRecipes { get; set; }
        public RecipeAmount()
        {
            InitializeComponent();
        }

        private void recipeAmountConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            
            numRecipes = Convert.ToInt32(recipeAmountSlider.Value);
            
                Ingredients_StepsAmount ingredients_StepsAmount = new Ingredients_StepsAmount();
                this.Hide();
                ingredients_StepsAmount.Show();
                this.Close();
            
            
        }
    }
}
