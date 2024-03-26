using Library.Items;
using Library.Windows;
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

namespace Library.Pages.AdminPages
{
    /// <summary>
    /// Interaction logic for AuthorInfoPage.xaml
    /// </summary>
    public partial class AuthorInfoPage : Page
    {
        AdminWindow adminWindow;
        DatabaseConnection connection;

        Author author;

        public AuthorInfoPage(AdminWindow adminWindow, DatabaseConnection connection)
        {
            InitializeComponent();

            this.adminWindow = adminWindow;
            this.connection = connection;
        }

        private void removeAuthor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            adminWindow.ShowAuthorsFrame();
        }

        public void GetCurrentAuthor(Author author)
        {
            this.author = author;
            this.DataContext = author;
        }
    }
}
