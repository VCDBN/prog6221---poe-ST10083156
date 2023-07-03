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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }


        private void menuConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if(selectionComboBox.SelectedItem == number1) 
            {
                RecipeAmount recipeAmount = new RecipeAmount();
                this.Hide();
                recipeAmount.Show();
                this.Close();
            }
            if(selectionComboBox.SelectedItem == number2) 
            {
                ViewRecipe viewRecipe = new ViewRecipe();
                this.Hide();
                viewRecipe.Show();
                this.Close();
            }
            if(selectionComboBox.SelectedItem == number3)
            {
                SpecificRecipeViewer specificRecipeViewer = new SpecificRecipeViewer();
                this.Hide();
                specificRecipeViewer.Show();
                this.Close();
            }
            if (selectionComboBox.SelectedItem == number4) 
            {
                FilterWindow filterWindow = new FilterWindow();
                this.Hide();
                filterWindow.Show();
                this.Close();
            }
            if(selectionComboBox.SelectedItem==number5) 
            {
                Recipe.recipes.Clear();
                MainWindow mainWindow = new MainWindow();
                this.Hide();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
