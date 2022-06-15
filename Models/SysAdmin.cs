using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class SysAdmin
    {
        // Admin Id and Name, password
        public int AdminId { get; set; }
        public string AdminName { get; set; }

        public string LoginPwd { get; set; }

        // Admin Status: 1: Normal, 2, Disabled  * Default: 1
        public int StatusId { get; set; } = 1;
        // Admin Role: 1: Super Admin, 2: Regular Admin * Default: 2
        public int RoleId { get; set; } = 2;

    }
}
