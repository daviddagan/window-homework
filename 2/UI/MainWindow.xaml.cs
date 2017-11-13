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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using BL;
namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBL bl = BL_Factory.GetInstance();
        public MainWindow()
        {
           // Flower flower = new Flower("calanit", 124, "jersalem", "has bb...", "red");
            //bl.AddFlower(flower);
            InitializeComponent();
            


        }
        private void SearchClick(object sender, RoutedEventArgs e)
        {
            string name = textBox.ToString();
            SearchWindow newWindow = new SearchWindow(name);
            newWindow.ShowDialog();
            Close();
        }

    }
}
