using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class ReaderRoles
    {
        // Role Id and Name Details: 1, Normal Member, 2. Vip Member, 3. Gold Member
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        // days a book allowed to be borrowed 
        public int AllowDays { get; set; }
        
        //Total books allowed to be borrowed
        public int AllowCounts { get; set; } 

    }
}
