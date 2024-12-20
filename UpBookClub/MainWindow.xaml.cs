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
using UpBookClub.Pages;

namespace UpBookClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sing_Click(object sender, RoutedEventArgs e)
        {
            string username = login.Text;
            string password = pass.Password;

            if (username == "User" && password == "1234")
            {
                FrmMain.Navigate(new Page1());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");

            }
        }


    }
}
