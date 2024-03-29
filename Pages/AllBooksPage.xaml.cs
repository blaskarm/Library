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

namespace Library.Pages
{
    /// <summary>
    /// Interaction logic for AllBooksPage.xaml
    /// </summary>
    public partial class AllBooksPage : Page
    {
        MemberWindow memberWindow;
        BookInfoPage bookInfoPage;
        DatabaseConnection connection;

        ObservableCollection<Book> books;
        Book book;

        public AllBooksPage(MemberWindow memberWindow, BookInfoPage bookInfoPage, DatabaseConnection connection, ObservableCollection<Book> books)
        {
            InitializeComponent();

            this.memberWindow = memberWindow;
            this.bookInfoPage = bookInfoPage;
            this.connection = connection;
            this.books = books;
            booksDataGrid.ItemsSource = books;
        }

        private void booksDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (booksDataGrid.SelectedItem != null)
            {
                book = books[booksDataGrid.SelectedIndex];
                booksDataGrid.SelectedItem = null;
                bookInfoPage.GetCurrentBook(book);
                memberWindow.ShowBookInfoFrame();
            }
        }

        public void RefreshBooks()
        {
            booksDataGrid.ItemsSource = null;
            booksDataGrid.ItemsSource = books;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            books = connection.SearchBook(txtSearch.Text);
            booksDataGrid.ItemsSource = null;
            booksDataGrid.ItemsSource = books;
            txtSearch.Text = "";
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            books = connection.GetBooksAsObservableCollection();
            booksDataGrid.ItemsSource = null;
            booksDataGrid.ItemsSource = books;
        }
    }
}
