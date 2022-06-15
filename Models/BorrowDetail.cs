using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class BorrowDetail
    {
        // Primary Key
        public int BorrowDetialId { get; set; }

        //Foreign Key
        public int BorrowId { get; set; }

        //Foreign Key
        public int BookId { get; set; }
        public int BorrowCount { get; set; }
        public int ReturnCount { get; set; } = 0;

        public int NonReturnCount { get; set; }
        public DateTime Expire { get; set; }
    }
}
