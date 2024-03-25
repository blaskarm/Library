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
        AddBookPage addBookPage;
        BorrowedPage borrowedPage;
        MembersPage membersPage;

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

            bookInfoPage = new BookInfoPage(this, connection);
            bookInfoFrame.Navigate(bookInfoPage);
            bookInfoFrame.Visibility = Visibility.Hidden;

            booksPage = new BooksPage(this, bookInfoPage, connection, admin, books);
            booksFrame.Navigate(booksPage);

            addBookPage = new AddBookPage();
            addBookFrame.Navigate(addBookPage);
            addBookFrame.Visibility = Visibility.Hidden;

            borrowedPage = new BorrowedPage(this, bookInfoPage, borrowed);
            borrowedFrame.Navigate(borrowedPage);
            borrowedFrame.Visibility = Visibility.Hidden;

            membersPage = new MembersPage(members);
            membersFrame.Navigate(membersPage);
            membersFrame.Visibility = Visibility.Hidden;
        }

        public void libraryButton_Click(object sender, RoutedEventArgs e)
        {
            ShowBooksFrame();
        }

        public void ShowBooksFrame()
        {
            booksFrame.Visibility = Visibility.Visible;
            bookInfoFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
        }

        public void ShowBookInfoFrame()
        {
            bookInfoFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
        }

        public void ShowAddBookFrame()
        {
            addBookFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
        }

        private void borrowedButton_Click(object sender, RoutedEventArgs e)
        {
            borrowedFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            membersFrame.Visibility = Visibility.Hidden;
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            ShowAddBookFrame();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void membersButton_Click(object sender, RoutedEventArgs e)
        {
            membersFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            addBookFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
        }
    }
}
