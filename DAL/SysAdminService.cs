using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using DBUtility;

namespace DAL
{
    public class SysAdminService
    {
        /// <summary>
        ///  query database about admin's other information according to login info
        /// </summary>
        /// <param name="objAdmin">login information </param>
        /// <returns>admin's object including all information</returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "Select AdminName, StatusId, RoleId from SysAdmin where ";
            sql += "AdminId=@AdminId, LoginPwd=@LoginPwd";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@AdminId", objAdmin.AdminId),
                new SqlParameter("@LoginPwd", objAdmin.LoginPwd)
            };
            SqlDataReader sqlDataReader = DBHelper.GetReader(sql, param);
            if (sqlDataReader.Read())
            {
                objAdmin.AdminName = sqlDataReader["AdminName"].ToString();
                objAdmin.StatusId = Convert.ToInt32(sqlDataReader["StatusId"]);
                objAdmin.RoleId = Convert.ToInt32(sqlDataReader["RoleId"]);
            }
            else
                objAdmin = null;
            sqlDataReader.Close();
            return objAdmin;
        }
    }
}
