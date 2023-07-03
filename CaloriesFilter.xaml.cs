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
    /// Interaction logic for CaloriesFilter.xaml
    /// </summary>
    public partial class CaloriesFilter : Window
    {
        public CaloriesFilter()
        {
            InitializeComponent();
        }

        private void caloriesFilterBtn_Click(object sender, RoutedEventArgs e)
        {
            string display = "";
            foreach (Recipe recipe in Recipe.recipes)
            {
                if (recipe.TotalCalories > Convert.ToDouble(caloriesFilterTxt.Text))
                {
                    display = display + recipe.Name;
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
