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
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        public FilterWindow()
        {
            InitializeComponent();
        }

        private void filterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(filterComboBox.SelectedItem == foodGroup) 
            {

            }
            if (filterComboBox.SelectedItem == null) { MessageBox.Show("Please select one of the two options", "Error!", MessageBoxButton.OK, MessageBoxImage.Error); }
            if (filterComboBox.SelectedItem == calories)
            {

            }
        }
    }
}
