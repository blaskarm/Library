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
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        AdminWindow adminWindow;
        BookInfoPage bookInfoPage;

        Book book;
        ObservableCollection<Book> books;

        public BooksPage(AdminWindow adminWindow, BookInfoPage bookInfoPage, ObservableCollection<Book> books)
        {
            InitializeComponent();

            this.adminWindow = adminWindow;
            this.bookInfoPage = bookInfoPage;
            this.books = books;

            booksDataGrid.ItemsSource = books;
        }

        private void booksDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(booksDataGrid.SelectedItem != null)
            {
                book = books[booksDataGrid.SelectedIndex];
                booksDataGrid.SelectedItem = null;
                bookInfoPage.GetCurrentbook(book);
                adminWindow.ShowBookInfoFrame();
            }
        }
    }
}
