using Library.Items;
using Library.Pages.AdminPages;
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

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        BooksPage booksPage;

        DatabaseConnection connection;
        Administrator admin;

        public AdminWindow(DatabaseConnection connection, Administrator admin)
        {
            InitializeComponent();

            this.connection = connection;
            this.admin = admin;

            booksPage = new BooksPage();
            booksFrame.Navigate(booksPage);
        }

        private void libraryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void borrowedButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
