using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{

    public class SysAdminManager
    {
        private SysAdminService sysAdminService = new SysAdminService();
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            return sysAdminService.AdminLogin(admin);
        }
    }
}
