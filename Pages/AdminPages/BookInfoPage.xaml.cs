using Library.Items;
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
    /// Interaction logic for BookInfoPage.xaml
    /// </summary>
    public partial class BookInfoPage : Page
    {
        AdminWindow adminWindow;
        DatabaseConnection connection;

        Book book;
        ObservableCollection<Book> books;
        ObservableCollection<Book> borrowed;

        public BookInfoPage(AdminWindow adminWindow, DatabaseConnection connection, ObservableCollection<Book> books, ObservableCollection<Book> borrowed)
        {
            InitializeComponent();

            this.adminWindow = adminWindow;
            this.connection = connection;
            this.books = books;
            this.borrowed = borrowed;
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Book b in borrowed)
            {
                if (book.Id == b.Id)
                {
                    MessageBox.Show("This book is out on loan");
                    return;
                }
            }
            books.Remove(book);
            connection.RemoveBook(book);
            adminWindow.ShowBooksFrame();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            adminWindow.ShowBooksFrame();
        }
        
        public void GetCurrentbook(Book book)
        {
            this.book = book;
            this.DataContext = book;
        }
    }
}
