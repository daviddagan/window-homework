using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BL;
using BE;

using System;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace UI
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {

        IBL bl = BL_Factory.GetInstance();


        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a new BitmapImage.
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            Image image;
            ImageSource i;
            string g = "pack://application:,,,/images/flowers.jpg";
            // b.UriSource = new Uri("/2;component/images/flowers.jpg");
            b.UriSource = new Uri(g);
            b.EndInit();

            // ... Get Image reference from sender.
            var image = sender as Image;
            // ... Assign Source.
            image.Source = b;
        }

        public SearchWindow(string name)
        {
            InitializeComponent();

        List<Flower> listFlowers= bl.search(name);
            flowerDataGrid.DataContext = listFlowers;
            Grid imageGrid2 = ImageGrid;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource flowerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("flowerViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // flowerViewSource.Source = [generic data source]
        }

    }
}
