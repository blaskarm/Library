using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public DateTime Published { get; set; }
        public string PublishedString { get; set; }
        public int AvailableCopies { get; set; }
        public Author Author { get; set; }

        public Book(int id, string title, int pages, DateTime published, int availableCopies, Author author)
        {
            Id = id;
            Title = title;
            Pages = pages;
            Published = published;
            PublishedString = published.ToString("yyyy/MM/dd");
            AvailableCopies = availableCopies;
            Author = author;
        }
    }
}
