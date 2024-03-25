using Library.Pages.AdminPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        List<Book> borrowedBooks = new List<Book>();

        public Member(int id, string fullName, string password, string email)
        {
            Id = id;
            FullName = fullName;
            Password = password;
            Email = email;
        }

        public void AddBook(Book book)
        {
            borrowedBooks.Add(book);
        }
    }
}
