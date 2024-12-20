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
using UpBookClub.ApplicationData;

namespace UpBookClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();
        public ObservableCollection<OrderItem> OrderItems { get; set; } = new ObservableCollection<OrderItem>();

        public Page1()
        {
            InitializeComponent();
            Products.Add(new Product
            {
                ProductId = 1,
                Name = "Книга 1",
                Description = "Описание книги 1",
                Manufacturer = "Издатель 1",
                Price = 500,
                Discount = 10,
            });

            Products.Add(new Product
            {
                ProductId = 2,
                Name = "Книга 2",
                Description = "Описание книги 2",
                Manufacturer = "Издатель 2",
                Price = 700,
            });

            ProductsListView.ItemsSource = Products;
        }

        private void ViewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoForward();
        }
    }
}
