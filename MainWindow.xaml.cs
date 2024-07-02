using Lab_11.View;
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

namespace Lab_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public static int IdUser { get; set; }
        public static int IdOrder { get; set; }

        private void Users_onClick(object sender, RoutedEventArgs e)
        {
            WindowUsers wUsers = new WindowUsers();
            wUsers.Show();
        }

        private void Orders_onClick(object sender, RoutedEventArgs e)
        {
            WindowOrders wOrders = new WindowOrders();
            wOrders.Show();
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Spisok_onClick(object sender, RoutedEventArgs e)
        {
            WindowSpisok wSpisok = new WindowSpisok();
            wSpisok.Show();
        }
    }
}
