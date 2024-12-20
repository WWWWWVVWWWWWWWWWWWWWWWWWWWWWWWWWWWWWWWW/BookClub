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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private ObservableCollection<OrderItem> OrderItems;

        public Page2(ObservableCollection<OrderItem> orderItems)
        {
            InitializeComponent();
            OrderItems = orderItems;
            OrderItemsListView.ItemsSource = OrderItems;
        }
        public Page2()
        {
            InitializeComponent();
        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
            var pickupCode = new Random().Next(100, 999).ToString();
            MessageBox.Show($"Ваш код для получения: {pickupCode}", "Заказ оформлен");
        }
    }
}
