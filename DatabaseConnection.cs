using Library.Items;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library
{
    public class DatabaseConnection
    {
        string server = "localhost";
        string database = "librarydb";
        string username = "library_manager";
        string password = "librarypassword";
        string connectionString = "";

        MySqlConnection mySqlConnection;
        Dictionary<int, Author>? authors;
        Dictionary<int, Book> borrowedBooks;
        List<Book> favorites;
        

        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            mySqlConnection = new MySqlConnection(connectionString);
        }

        public ObservableCollection<Book> GetBooksAsObservableCollection()
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();
            GetAuthorsAsDictionary();

            mySqlConnection.Open();

            string query = "SELECT * FROM books;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book((int)reader["book_id"], (string)reader["title"], (int)reader["pages"], (DateTime)reader["published"], (int)reader["available_copies"], authors[(int)reader["author_id"]]);
                books.Add(book);
            }

            mySqlConnection.Close();
            return books;
        }

        public ObservableCollection<Author> GetAuthorsAsObservableCollection()
        {
            ObservableCollection<Author> authors = new ObservableCollection<Author>();

            mySqlConnection.Open();

            string query = "SELECT * FROM authors;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Author author = new Author((int)reader["author_id"], (string)reader["full_name"], (DateTime)reader["birthdate"], (string)reader["nationality"]);
                authors.Add(author);
            }

            mySqlConnection.Close();
            return authors;
        }

        public void GetAuthorsAsDictionary()
        {
            authors = new Dictionary<int, Author>();

            mySqlConnection.Open();

            string query1 = "SELECT * FROM authors;";

            MySqlCommand command1 = new MySqlCommand(query1, mySqlConnection);

            MySqlDataReader reader = command1.ExecuteReader();

            while (reader.Read())
            {
                Author author = new Author((int)reader["author_id"], (string)reader["full_name"], (DateTime)reader["birthdate"], (string)reader["nationality"]);
                authors.Add(author.Id, author);
            }

            mySqlConnection.Close();
        }

        public Dictionary<int, Member> GetMembersAsDictionary()
        {
            Dictionary<int, Member> members = new Dictionary<int, Member>();

            mySqlConnection.Open();

            string query = "SELECT * FROM members;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Member member = new Member((int)reader["member_id"], (string)reader["full_name"], (string)reader["member_password"], (string)reader["email"]);
                members.Add(member.Id, member);
            }

            mySqlConnection.Close();
            return members;
        }

        public ObservableCollection<Member> GetMembersAsObservableCollection()
        {
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            mySqlConnection.Open();

            string query = "SELECT * FROM members;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Member member = new Member((int)reader["member_id"], (string)reader["full_name"], (string)reader["member_password"], (string)reader["email"]);
                members.Add(member);
            }

            mySqlConnection.Close();
            return members;
        }

        public ObservableCollection<Book> GetMemberFavorites(int id)
        {
            ObservableCollection<Book> favorites = new ObservableCollection<Book>();

            mySqlConnection.Open();

            string query = $"CALL get_member_favorites({id});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book((int)reader["book_id"], (string)reader["title"], (int)reader["pages"], (DateTime)reader["published"], (int)reader["available_copies"], authors[(int)reader["author_id"]]);
                favorites.Add(book);
            }

            mySqlConnection.Close();
            return favorites;
        }

        public void AddToFavorites(int bookId, int memberId)
        {
            mySqlConnection.Open();

            string query = $"CALL add_to_favorites({bookId}, {memberId});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            mySqlConnection.Close();
        }

        public ObservableCollection<Book> GetMemberBorrowedBooks(int id)
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();

            mySqlConnection.Open();

            string query = $"CALL get_member_borrowed_books({id});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book((int)reader["book_id"], (string)reader["title"], (int)reader["pages"], (DateTime)reader["published"], (int)reader["available_copies"], authors[(int)reader["author_id"]]);
                books.Add(book);
            }

            mySqlConnection.Close();
            return books;
        }
        public ObservableCollection<Book> GetAllBorrowedBooks()
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();

            mySqlConnection.Open();

            string query = "CALL get_borrowed_books();";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book((int)reader["book_id"], (string)reader["title"], (int)reader["pages"], (DateTime)reader["published"], (int)reader["available_copies"], authors[(int)reader["author_id"]]);
                books.Add(book);
            }

            mySqlConnection.Close();
            return books;
        }

        public void AddBorrowedBook(int bookId, int memberId)
        {
            mySqlConnection.Open();

            string storedProcedure = "borrow_book";

            MySqlCommand command = new MySqlCommand(storedProcedure, mySqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            MySqlParameter p1 = new MySqlParameter("book_id", MySqlDbType.Int32) { Value = bookId };
            MySqlParameter p2 = new MySqlParameter("member_id", MySqlDbType.Int32) { Value = memberId };

            command.Parameters.Add(p1);
            command.Parameters.Add(p2);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void ChangeAvailableCopies(int bookId, int change)
        {
            mySqlConnection.Open();

            string query = $"CALL change_available_copies({bookId}, {change});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            mySqlConnection.Close();
        }

        public void ReturnBook(int bookId, int memberId)
        {
            mySqlConnection.Open();

            string query = $"CALL return_book({bookId}, {memberId});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            mySqlConnection.Close();
        }

        public void SaveMemberName(int memberId, string name)
        {
            mySqlConnection.Open();

            string storedProcedure = "change_member_name";

            MySqlCommand command = new MySqlCommand(storedProcedure, mySqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            MySqlParameter p1 = new MySqlParameter("id", MySqlDbType.Int32) { Value = memberId };
            MySqlParameter p2 = new MySqlParameter("_name", MySqlDbType.VarChar, 150) { Value = name };

            command.Parameters.Add(p1);
            command.Parameters.Add(p2);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void SaveMemberPassword(int memberId, string password)
        {
            mySqlConnection.Open();

            string storedProcedure = "change_member_password";

            MySqlCommand command = new MySqlCommand(storedProcedure, mySqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            MySqlParameter parameter1 = new MySqlParameter("id", MySqlDbType.Int32) { Value = memberId };
            MySqlParameter parameter2 = new MySqlParameter("_password", MySqlDbType.VarChar, 25) { Value = password };

            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void SaveMemberEmail(int memberId, string email)
        {
            mySqlConnection.Open();

            string storedProcedure = "change_member_email";

            MySqlCommand command = new MySqlCommand(storedProcedure, mySqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            MySqlParameter parameter1 = new MySqlParameter("id", MySqlDbType.Int32) { Value = memberId };
            MySqlParameter parameter2 = new MySqlParameter("_email", MySqlDbType.VarChar, 320) { Value = email };

            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void AddNewBook(Book book, Author author)
        {
            mySqlConnection.Open();

            string query = "INSERT INTO books VALUES (DEFAULT, @title, @pages, @published, @availableCopies, @authorId)";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@pages", book.Pages);
            command.Parameters.AddWithValue("@published", book.Published.Date);
            command.Parameters.AddWithValue("@availableCopies", book.AvailableCopies);
            command.Parameters.AddWithValue("@authorId", author.Id);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void AddNewAuthor(Author author)
        {
            mySqlConnection.Open();

            string query = $"INSERT INTO authors VALUES (DEFAULT, @name, @date, @nationality);";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            command.Parameters.AddWithValue("@name", author.FullName);
            command.Parameters.AddWithValue("@date", author.Birthdate.Date);
            command.Parameters.AddWithValue("@nationality", author.Nationality);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void RemoveBook(Book book)
        {
            mySqlConnection.Open();

            RemoveFromFavorites(book);
            string query = $"DELETE FROM books WHERE books.book_id = {book.Id};";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            command.ExecuteNonQuery();

            mySqlConnection.Close();
        }

        public void RemoveAuthor(Author author)
        {
            mySqlConnection.Open();
            //DeleteAuthorBooks(books, mySqlConnection);
            List<Book> books = new List<Book>();
            
            books = GetAuthorBooks(author);
            RemoveFromFavorites(books);

            string query1 = $"DELETE FROM books WHERE author_id = {author.Id};";
            string query2 = $"DELETE FROM authors WHERE author_id = {author.Id};";

            MySqlCommand command1 = new MySqlCommand(query1, mySqlConnection);
            MySqlCommand command2 = new MySqlCommand(query2, mySqlConnection);

            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();

            mySqlConnection.Close();
        }
        private List<Book> GetAuthorBooks(Author author)
        {
            List<Book> books = new List<Book>();

            string query = $"SELECT * FROM books WHERE author_id = {author.Id};";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book((int)reader["book_id"], (string)reader["title"], (int)reader["pages"], (DateTime)reader["published"], (int)reader["available_copies"], authors[(int)reader["author_id"]]);
                books.Add(book);
            }
            reader.Close();
            return books;
        }

        public void RemoveFromFavorites(int bookId, int memberId)
        {
            mySqlConnection.Open();

            string query = $"CALL remove_from_favorites({bookId}, {memberId});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            mySqlConnection.Close();
        }

        private void RemoveFromFavorites(Book book)
        {
            string query = $"DELETE FROM favorites WHERE book_id = {book.Id};";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);

            command.ExecuteNonQuery();
        }

        private void RemoveFromFavorites(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                //favorites.Remove(books[i]);
                Book b = books[i];
                string query = $"DELETE FROM favorites WHERE book_id = {b.Id}";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                command.ExecuteNonQuery();
            }
        }
        /*
        private void DeleteAuthorBooks(List<Book> books, MySqlConnection mySqlConnection)
        {
            for (int i = 0; i < authors.Count; i++)
            {
                string query = $"DELETE FROM books WHERE author_id = {authors[i].Id}";

                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                command.ExecuteNonQuery();
            }
        }*/
    }
}
