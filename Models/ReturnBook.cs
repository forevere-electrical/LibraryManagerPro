
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class ReturnBook
    {
        // Primary Key
        public int ReturnId { get; set; }

        // Foreign Key, Detailed Number for borrowing
        public int BorrowDetailId { get; set; }

        // Total books returned this time
        public int ReturnCount { get; set; }

        // date for this return
        public DateTime ReturnDate { get; set; }

        // Admin Name: for readers
        public string AdminName_R { get; set; }
    }
}
