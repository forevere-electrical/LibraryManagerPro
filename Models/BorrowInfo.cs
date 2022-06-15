using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class BorrowInfo
    {
        // Primary Key
        public int BorrowId { get; set; }

        // Foreign Key from Reader Class
        public int ReaderId { get; set; }
        public DateTime BorrowDate { get; set; }

        // Admin for Borrower
        public string AdminName_B { get; set; }
    }
}
