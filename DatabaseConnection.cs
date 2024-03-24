using Library.Items;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GetAuthorsAsDictionary()
        {
            authors = new Dictionary<int, Author>();

            mySqlConnection.Open();

            string query = "SELECT * FROM authors;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

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

        public void RemoveFromFavorites(int bookId, int memberId)
        {
            mySqlConnection.Open();

            string query = $"CALL remove_from_favorites({bookId}, {memberId});";

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

        /*
        public ObservableCollection<Book> GetAllBorrowedBooks()
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();
        }*/

        public void AddBorrowedBook(int bookId, int memberId)
        {
            mySqlConnection.Open();

            string query = $"CALL borrow_book({bookId}, {memberId});";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

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

        }

        public void AddNewAuthor(Author author)
        {
            
        }
    }
}
