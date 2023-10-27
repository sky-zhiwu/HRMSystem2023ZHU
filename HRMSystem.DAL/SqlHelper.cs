using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    internal class SqlHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            /** using (SqlConnection conn = new SqlConnection(connStr))
             {
                 
                 conn.Open();
                 SqlCommand comm = new SqlCommand(sql, conn);
                 comm.Parameters.AddRange(parameters);
                 SqlDataReader sdr = comm.ExecuteReader();
                 Operator op = new Operator();
                 if (sdr.Read())
                 {

                     op = new Operator();
                     op.DeptId = (Guid)sdr["DeptId"];
                     op.IsAdmin = (bool)sdr["IsAdmin"];
                     op.IsDeleted = (bool)sdr["IsDeleted"];
                     op.IsLocked = (bool)sdr["IsDeleted"];
                     op.Password = sdr["Password"].ToString();
                     op.RealName = sdr["RealName"].ToString();
                     op.UserName = sdr["UserName"].ToString();
                     sdr.Close();
                     return op;
                 }
                 else
                 {
                     return null;
                 }
             }*/
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            return comm.ExecuteReader(CommandBehavior.CloseConnection);

        }
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                return comm.ExecuteScalar();
            }
        }
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                int cnt = comm.ExecuteNonQuery();
                return cnt;
            }
        }
        public static DataTable GetDataTable(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.SelectCommand.Parameters.AddRange(parameters);
                sda.Fill(dt);
                return dt;
            }
            
        }

        public static bool ExcuteTransactionSQL(List<string> strSQL, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                SqlCommand comm = new SqlCommand();
               // comm.Connection = conn;
               // comm.Transaction = transaction;
                try
                {
                    
                    comm = new SqlCommand(strSQL[0], conn, transaction); 
                    comm.CommandText += strSQL[1];
                    comm.Parameters.AddRange(parameters);
                    comm.ExecuteNonQuery();
                    /**int count = 0;
                    for(int n = 0; n < strSQL.Count; n++)
                    {
                        string sql = strSQL[n];
                        if(!string.IsNullOrEmpty(sql) && sql.Length > 1)
                        {
                            comm.CommandText = sql;
                            comm.Parameters.Add(parameters);
                            count += comm.ExecuteNonQuery();
                        }
                    }*/
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
                return true;
            }

        }


    }
}
