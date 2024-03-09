using Library.Items;
using Library.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Pages.MemberPages
{
    /// <summary>
    /// Interaction logic for BookInfoPage.xaml
    /// </summary>
    public partial class BookInfoPage : Page
    {
        MemberWindow memberWindow;
        DatabaseConnection connection;

        Book book;
        Member member;

        ObservableCollection<Book> books;
        ObservableCollection<Book> favorites;
        ObservableCollection<Book> borrowed;

        public BookInfoPage(MemberWindow memberWindow, DatabaseConnection connection, Member member, ObservableCollection<Book> books, ObservableCollection<Book> favorites, ObservableCollection<Book> borrowed)
        {
            InitializeComponent();

            this.memberWindow = memberWindow;
            this.connection = connection;
            this.member = member;
            this.books = books;
            this.favorites = favorites;
            this.borrowed = borrowed;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Book b in borrowed)
            {
                if (b.Id == book.Id)
                {
                    connection.ReturnBook(b.Id, member.Id);
                    connection.ChangeAvailableCopies(book.Id, 1);
                    ChangeAvailableCopies(1);
                    borrowed.Remove(b);
                    RefreshDataContext();
                    MessageBox.Show($"You returned {b.Title}");
                    return;
                }
            }
            MessageBox.Show("You don't have this book!");
        }

        private void borrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (book.AvailableCopies < 1)
            {
                MessageBox.Show("No available copies at this moment");
                return;
            }

            foreach (Book b in borrowed)
            {
                if (b.Id == book.Id)
                {
                    MessageBox.Show("You already have this book");
                    return;
                }
            }

            connection.AddBorrowedBook(book.Id, member.Id);
            connection.ChangeAvailableCopies(book.Id, -1);
            ChangeAvailableCopies(-1);
            borrowed.Add(book);
            RefreshDataContext();

            MessageBox.Show($"You borrowed {book.Title}");
        }

        private void favoriteButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Book b in favorites)
            {
                if (b.Id == book.Id)
                {
                    addedToFavText.Text = "Removed from favorites!";
                    connection.RemoveFromFavorites(book.Id, member.Id);
                    favorites.Remove(book);
                    return;
                }
            }
            addedToFavText.Text = "Addded to favorites!";
            connection.AddToFavorites(book.Id, member.Id);
            favorites.Add(book);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            memberWindow.ShowBooksFrame();
        }

        public void GetCurrentBook(Book book)
        {
            this.book = book;
            this.DataContext = book;
        }

        private void RefreshDataContext()
        {
            this.DataContext = null;
            this.DataContext = book;
        }

        public void ChangeAvailableCopies(int num)
        {
            foreach (Book b in favorites)
            {
                if (b.Id == book.Id)
                {
                    b.AvailableCopies += num;
                }
            }

            foreach (Book b in books)
            {
                if (b.Id == book.Id)
                {
                    b.AvailableCopies += num;
                }
            }
        }
    }
}
