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
using WpfApp4.NewFolder;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for secondWindow.xaml
    /// </summary>
    public partial class secondWindow : Window
    {
        public Product? Product { get; set; }
        public secondWindow()
        {
            InitializeComponent();
            DataContext = this; 
        }
    }
}
