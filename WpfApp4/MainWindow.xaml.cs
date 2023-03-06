using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp4.NewFolder;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
        }
        public ObservableCollection<Product> Products { get; set; } = new()
        {
            new Product{ Name = "Apple" , Price = 2  },
            new Product{Name="Bread",Price=0.7},
            new Product{Name="Water",Price=0.4},
            new Product{Name="Cola",Price=0.9},
            new Product{Name="Cheese",Price=3},
            new Product{Name="Tomato",Price=1.2},
            new Product{Name="Potato",Price=1.4},
            new Product{Name="Onion",Price=0.5},
            new Product{Name="Tea",Price=2},
            new Product{Name="Oil",Price=7.5},


        };

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            secondWindow sw = new();

            sw.Product = listBox.SelectedItem as Product; 
            //Hide();
            sw.ShowDialog();
            Show();


        }
    }
}
