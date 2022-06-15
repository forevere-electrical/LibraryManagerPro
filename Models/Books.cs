using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Books
    {
        public int BoodId { get; set; }
        public string BarCode { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        // Foreign Key From Publishers Class
        public int PublisherId { get; set; }
        public DateTime PublishDate { get; set; }

        // Foreign Key from Categories Class
        public int BookCategory { get; set; }
        public float UnitPrice { get; set; }

        // Book Image name/ directory
        public string BookImage { get; set; }

        // Total count of this book in the library
        public int BookCount { get; set; }

        // Book available for borrowing
        public int Remainder { get; set; }
        // Position of book /book shelf
        public string BookPosition { get; set; }

        // Book available Date
        public DateTime RegTime { get; set; }

    }
}
