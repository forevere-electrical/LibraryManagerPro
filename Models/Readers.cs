using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Readers
    {

        //Primary Key
        public int ReaderId { get; set; }

        // UniKey
        public string ReadingCard { get; set; }
        public string ReaderName { get; set; }
        public string Gender { get; set; }
        public string IDCard { get; set; }
        public string ReaderAddress { get; set; }
        public string PostCode { get; set; }
        public int RoleId { get; set; }
        public string ReaderImage { get; set; }
        public DateTime RegTime { get; set; }
        public string ReaderPwd { get; set; }

        // Foreign Key From SysAdmin
        public int AdminId { get; set; }

        //Status Id: 1, Normal, 2, Disabled, 3. Deleted ..****Default value: 1
        public int StatusId { get; set; } = 1;

    }
}
