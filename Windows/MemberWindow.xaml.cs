    using Library.Items;
using Library.Pages;
using Library.Pages.MemberPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
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
    /// Interaction logic for MemberWindow.xaml
    /// </summary>
    public partial class MemberWindow : Window
    {
        AllBooksPage booksPage;
        BookInfoPage bookInfoPage;
        FavoritesPage favoritesPage;
        BorrowedPage borrowedPage;
        SettingsPage settingsPage;

        DatabaseConnection connection;
        Member member;

        ObservableCollection<Book> books;
        ObservableCollection<Book> favorites;
        ObservableCollection<Book> borrowed;

        public MemberWindow(DatabaseConnection connection, Member member)
        {
            InitializeComponent();

            this.connection = connection;
            this.member = member;

            this.DataContext = member;

            books = connection.GetBooksAsObservableCollection();
            favorites = connection.GetMemberFavorites(member.Id);
            borrowed = connection.GetBorrowedBooks(member.Id);

            bookInfoPage = new BookInfoPage(this, connection, member, books, favorites, borrowed);
            bookInfoFrame.Navigate(bookInfoPage);
            bookInfoFrame.Visibility = Visibility.Hidden;

            booksPage = new AllBooksPage(this, bookInfoPage, books);
            booksFrame.Navigate(booksPage);

            favoritesPage = new FavoritesPage(this, bookInfoPage, favorites);
            favoritesFrame.Navigate(favoritesPage);
            favoritesFrame.Visibility = Visibility.Hidden;

            borrowedPage = new BorrowedPage(this, bookInfoPage, borrowed);
            borrowedFrame.Navigate(borrowedPage);
            borrowedFrame.Visibility = Visibility.Hidden;

            settingsPage = new SettingsPage(this, connection, member);
            settingsFrame.Navigate(settingsPage);
            settingsFrame.Visibility = Visibility.Hidden;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void libraryButton_Click(object sender, RoutedEventArgs e)
        {
            ShowBooksFrame();
        }

        private void favoritesButton_Click(object sender, RoutedEventArgs e)
        {
            ShowFavoritesFrame();
        }

        private void borrowedButton_Click(object sender, RoutedEventArgs e)
        {
            ShowBorrowedFrame();
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowSettingsFrame();
        }


        public void ShowBooksFrame()
        {
            booksFrame.Visibility = Visibility.Visible;
            bookInfoFrame.Visibility = Visibility.Hidden;
            favoritesFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            booksPage.RefreshBooks();
        }

        public void ShowBookInfoFrame()
        {
            bookInfoFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            favoritesFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
        }

        public void ShowFavoritesFrame()
        {
            favoritesFrame.Visibility = Visibility.Visible;
            bookInfoFrame.Visibility = Visibility.Hidden;
            booksFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            favoritesPage.RefreshFavorites();
        }

        public void ShowBorrowedFrame()
        {
            borrowedFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            favoritesFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
        }

        public void ShowSettingsFrame()
        {
            settingsFrame.Visibility = Visibility.Visible;
            booksFrame.Visibility = Visibility.Hidden;
            bookInfoFrame.Visibility = Visibility.Hidden;
            favoritesFrame.Visibility = Visibility.Hidden;
            borrowedFrame.Visibility = Visibility.Hidden;
        }

        public void RefreshDataContext()
        {
            this.DataContext = null;
            this.DataContext = member;
        }
    }
}
