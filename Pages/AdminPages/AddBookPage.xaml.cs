using Library.Items;
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
    /// Interaction logic for AddBookPage.xaml
    /// </summary>
    public partial class AddBookPage : Page
    {
        DatabaseConnection connection;
        ObservableCollection<Book> books;
        ObservableCollection<Author> authors;

        public AddBookPage(DatabaseConnection connection, ObservableCollection<Book> books, ObservableCollection<Author> authors)
        {
            InitializeComponent();

            this.connection = connection;
            this.books = books;
            this.authors = authors;
        }

        private void addAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            AddAuthor();
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBook();
        }

        private void AddAuthor()
        {
            string name = authorNameTextbox.Text;
            string nationality = nationalityTextbox.Text;
            DateTime birthdate = authorCalendar.DisplayDate.Date;

            foreach (Author auth in authors)
            {
                if(auth.FullName.ToLower() == name.ToLower())
                {
                    MessageBox.Show("Author already exists");
                    ResetAuthorTextboxes();
                    return;
                }
            }

            if (name != "" || nationality != "")
            {
                Author author = new Author(authors.Count + 1, name, birthdate, nationality);

                authors.Add(author);
                connection.AddNewAuthor(author);
            }

            ResetAuthorTextboxes();
        }

        private void ResetAuthorTextboxes()
        {
            authorNameTextbox.Text = "";
            nationalityTextbox.Text = "";
        }

        private void AddBook()
        {
            try
            {
                string title = bookTitleTextbox.Text;
                string author = authorTextbox.Text;
                int pages = int.Parse(pagesTextbox.Text);
                int availableCopies = int.Parse(availableCopiesTextbox.Text);
                DateTime published = bookCalendar.DisplayDate.Date;

                foreach (Book b in books)
                {
                    if (b.Title.ToLower() == title.ToLower() && b.Author.FullName.ToLower() == author.ToLower())
                    {
                        ResetBookTextboxes();
                        MessageBox.Show("Book already exists");
                        return;
                    }
                }

                if (title != "" || author != "" || pagesTextbox.Text != "" || availableCopiesTextbox.Text != "")
                {
                    foreach (Author auth in authors)
                    {
                        if (auth.FullName.ToLower() == author.ToLower())
                        {
                            Book book = new Book(books.Count + 1, title, pages, published, availableCopies, auth);
                            books.Add(book);
                            connection.AddNewBook(book, auth);
                            ResetBookTextboxes();
                            return;
                        }
                    }
                }
            }
            catch
            {
                ResetBookTextboxes();
                MessageBox.Show("Something went wrong!");
                return;
            }

            ResetBookTextboxes();
            MessageBox.Show("Author does'nt exist");
        }

        private void ResetBookTextboxes()
        {
            bookTitleTextbox.Text = "";
            authorNameTextbox.Text = "";
            pagesTextbox.Text = "";
            availableCopiesTextbox.Text = "";
        }
    }
}
