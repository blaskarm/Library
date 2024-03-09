using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string BirthdateString { get; set; }
        public string Nationality { get; set; }

        public Author(int id, string fullName, DateTime birthdate, string nationality)
        {
            Id = id;
            FullName = fullName;
            Birthdate = birthdate;
            BirthdateString = birthdate.ToString("yyyy/MM/dd");
            Nationality = nationality;
        }
    }
}
