using Library.Items;
using Library.Pages.AdminPages;
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
using System.Windows.Shapes;

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        Administrator admin;
        DatabaseConnection connection;

        BooksPage booksPage;
        BookInfoPage bookInfoPage;
        AuthorInfoPage authorInfoPage;
        AddBookPage addBookPage;
        BorrowedPage borrowedPage;
        MembersPage membersPage;
        AuthorsPage authorsPage;

        ObservableCollection<Author> authors;
        ObservableCollection<Book> books;
        ObservableCollection<Book> borrowed;
        ObservableCollection<Member> members;

        public AdminWindow(DatabaseConnection connection, Administrator admin)
        {
            InitializeComponent();

            this.connection = connection;
            this.admin = admin;

            books = connection.GetBooksAsObservableCollection();
            members = connection.GetMembersAsObservableCollection();
            borrowed = connection.GetAllBorrowedBooks();
            authors = connection.GetAuthorsAsObservableCollection();

            bookInfoPage = new BookInfoPage(this, connection, books, borrowed);
            bookInfoFrame.Navigate(bookInfoPage);
            bookInfoFrame.Visibility = Visibility.Hidden;

            authorInfoPage = new AuthorInfoPage(this, connection);
            authorInfoFrame.Navigate(authorInfoPage);
            authorInfoFrame.Visibility = Visibility.Hidden;

            booksPage = new BooksPage(this, bookInfoPage, books);
            booksFrame.Navigate(booksPage);

            addBookPage = new AddBookPage(connection, books, authors);
            addBookFrame.Navigate(addBookPage);
            addBookFrame.Visibility = Visibility.Hidden;

            borrowedPage = new BorrowedPage(this, bookInfoPage, borrowed);
            borrowedFrame.Navigate(borrowedPage);
            borrowedFrame.Visibility = Visibility.Hidden;

            membersPage = new MembersPage(members);
            membersFrame.Navigate(membersPage);
            membersFrame.Visibility = Visibility.Hidden;

            authorsPage = new AuthorsPage(this, authorInfoPage, authors);
            authorsFrame.Navigate(authorsPage);
            authorsFrame.Visibility = Visibility.Hidden;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        public void libraryButton_Click(object sender, RoutedEventArgs e)
        {
            ShowBooksFrame();
        }

        private void authorsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowAuthorsFrame();
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            ShowAddBookFrame();
        }

        private void borrowedButton_Click(object sender, RoutedEventArgs e)
        {
            ShowBorrowedFrame();
        }

        private void membersButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMembersFrame();
        }

        public void ShowBooksFrame()
        {
            booksFrame.Visibility = Visibility.Visible;
            bookInfoFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
            authorsFrame.Visibility = Visibility.Hidden;
            authorInfoFrame.Visibility = Visibility.Hidden;
        }

        public void ShowBookInfoFrame()
        {
            bookInfoFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
            authorsFrame.Visibility = Visibility.Hidden;
            authorInfoFrame.Visibility = Visibility.Hidden;
        }

        public void ShowAddBookFrame()
        {
            addBookFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
            authorsFrame.Visibility = Visibility.Hidden;
            authorInfoFrame.Visibility = Visibility.Hidden;
        }

        private void ShowBorrowedFrame()
        {
            borrowedFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
            authorsFrame.Visibility = Visibility.Hidden;
            authorInfoFrame.Visibility = Visibility.Hidden;
        }

        private void ShowMembersFrame()
        {
            membersFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            authorsFrame.Visibility = Visibility.Hidden;
            authorInfoFrame.Visibility = Visibility.Hidden;
        }

        public void ShowAuthorsFrame()
        {
            authorsFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
            authorInfoFrame.Visibility = Visibility.Hidden;
        }

        public void ShowAuthorInfoFrame()
        {
            authorInfoFrame.Visibility = Visibility.Visible;
            authorsFrame.Visibility = Visibility.Hidden;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
        }
    }
}
