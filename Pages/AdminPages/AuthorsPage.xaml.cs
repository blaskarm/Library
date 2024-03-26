using Library.Items;
using Library.Pages.MemberPages;
using Library.Windows;
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

namespace Library.Pages.AdminPages
{
    /// <summary>
    /// Interaction logic for AuthorsPage.xaml
    /// </summary>
    public partial class AuthorsPage : Page
    {
        AdminWindow adminWindow;
        AuthorInfoPage authorInfoPage;

        Author author;
        ObservableCollection<Author> authors;

        public AuthorsPage(AdminWindow adminWindow, AuthorInfoPage authorInfoPage, ObservableCollection<Author> authors)
        {
            InitializeComponent();

            this.adminWindow = adminWindow;
            this.authorInfoPage = authorInfoPage;
            this.authors = authors;

            authorsDataGrid.ItemsSource = authors;
        }

        private void authorsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (authorsDataGrid.SelectedItem != null)
            {
                author = authors[authorsDataGrid.SelectedIndex];
                authorsDataGrid.SelectedItem = null;
                authorInfoPage.GetCurrentAuthor(author);
                adminWindow.ShowAuthorInfoFrame();
            }
        }
    }
}
