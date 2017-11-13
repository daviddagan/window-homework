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
using BL;
using BE;

namespace UI
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {

        IBL bl = BL_Factory.GetInstance();
      
        
        
        public SearchWindow(string name)
        {
            InitializeComponent();

            List<Flower> listFlowers= bl.search(name);
            flowerDataGrid.DataContext = listFlowers;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource flowerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("flowerViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // flowerViewSource.Source = [generic data source]
        }
    }
}
