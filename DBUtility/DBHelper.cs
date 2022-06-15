using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;

namespace DBUtility
{
    public class DBHelper
    {
        // Define database connection string;
        private static string ConnString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        #region common CRUD methods using ADO.net database access 

        // update database row

        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // create object of SqlDataAdapter
            DataSet ds = new DataSet();     // create a dataset in memory
            try
            {
                conn.Open();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                string errorInfo = $"Error on calling method GetDataSet(string sql): {e.Message}.";
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }

        }

 
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                WriteLog(e.Message);
                throw new Exception($"There is something wrong: {e.Message}");
            }
            finally
            {
                conn.Close();
            }

        }


        // used for sql string is SELECT and result is single result.
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                conn.Close();
                string errorInfo = $"Error on calling GetSingleResult(string sql): {e.Message}";
                WriteLog(errorInfo);
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // used on SELECT query and returns multiple lines.

        public static object GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                string errorInfo = $"Error on calling GetReader(string sql) method: {e.Message}";
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
        }
        #endregion

        #region Methods  with  @parameter sql query sentenses
        // all @parameters are sent to SqlCommand objects
        public static int Update(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                WriteLog(e.Message);
                throw new Exception($"There is something wrong: {e.Message}");
            }
            finally
            {
                conn.Close();
            }

        }


        // used for sql string is SELECT and result is single result.
        public static object GetSingleResult(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                conn.Close();
                string errorInfo = $"Error on calling GetSingleResult(string sql, SqlParameter[] param): {e.Message}";
                WriteLog(errorInfo);
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // used on SELECT query and returns multiple lines.

        public static SqlDataReader GetReader(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                string errorInfo = $"Error on calling GetReader(string sql, SqlParameter[] param) method: {e.Message}";
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
        }
        #endregion

        #region Methods with  Stored procedure 

        // create procedure usp_QueryBorrowCount
        // @ReadingCard varchar(20) as 
        // declare @BorrowCount int = 0
        // select @BorrowCount = SUM(NonReturnCount) from BorrowDetail
        // inner join BorrowInfo on BorrowInfo.BorrowId = BorrowDetail.BorrowId
        // inner join Readers on BorrowInfo.ReaderId = Readers.ReaderId
        // where NonReturnCount>0 and ReadingCard=@ReadingCard
        // if @BorrowCount is null
        // select BorrowCount = 0
        //
        // exec usp_QueryBorrowCount '0006092947'

        public static int UpdateByStoredProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                WriteLog(e.Message);
                throw new Exception($"Error on calling UpdateByStoredProcedure: {e.Message}");
            }
            finally
            {
                conn.Close();
            }

        }


        // used for sql string is SELECT and result is single result.
        public static object GetSingleResultByStoredProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                conn.Close();
                string errorInfo = $"Error on calling GetSingleResultByStoredProcedure: {e.Message}";
                WriteLog(errorInfo);
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // used on SELECT query and returns multiple lines.

        public static object GetReaderByStoredProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                string errorInfo = $"Error on calling GetReaderByStoredProcedure method: {e.Message}";
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
        }

        public static bool UpdateByTranscation(string mainSql, SqlParameter[] mainParam, string detailSql, SqlParameter[] detailParam)
        {
            SqlConnection conn=new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; 
            try
            {
                conn.Open();
                cmd.Transaction= conn.BeginTransaction();
                if (mainSql != null && mainSql.Length != 0)
                {
                    cmd.CommandText = mainSql;
                    cmd.Parameters.AddRange(mainParam);
                    cmd.ExecuteNonQuery();
                }
                foreach (SqlParameter param  in detailParam)
                {
                    cmd.CommandText = detailSql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                if (cmd.Transaction != null) cmd.Transaction.Rollback();
                string errorInfo = $"Error on calling UpdateByTranscation method: {e.Message} ";
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                if (cmd.Transaction != null) cmd.Transaction = null; // clear transctions
                conn.Close();
            }
        }

        #endregion

        #region Other Methods:
        // If something is wrong, record error infomation into a log book file
        private static void WriteLog(string log)
        {
            FileStream fs = new FileStream("sqlhelper.log", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToString() + " " + log);
            sw.Close();
            fs.Close();
        }

        #endregion

    }
}
