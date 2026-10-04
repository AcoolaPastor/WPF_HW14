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

namespace WPF_HW14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product("Яблоки", 129.90, "Data/apple.png", ProductCategory.Еда),
                new Product("Хлеб", 54.50, "Data/bread.png", ProductCategory.Еда),
                new Product("Холодильник", 45990.00, "Data/fridge.png", ProductCategory.БытоваяТехника),
                new Product("Чайник", 2190.00, "Data/kettle.png", ProductCategory.БытоваяТехника),
                new Product("Моющее средство", 399.00, "Data/chemicals.png", ProductCategory.БытоваяХимия),
            };

            DataContext = this;
        }
    }

}
