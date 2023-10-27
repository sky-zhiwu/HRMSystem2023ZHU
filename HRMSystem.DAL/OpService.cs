using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class OpService
    {
        
        public Operator GetOperator(string un) //通过用户名得到用户类型
        {
            Operator op = null;
            string sql = "SELECT * FROM Operator WHERE UserName = @UserName ";

            SqlParameter paraUn = new SqlParameter("@UserName", un);

            /** using (SqlConnection conn = new SqlConnection(connStr))
             {
                 conn.Open();
                 SqlCommand comm = new SqlCommand(sql, conn);
                 comm.Parameters.Add(paraUn);
                 SqlDataReader sdr = comm.ExecuteReader();

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
             }*/
            SqlDataReader sdr = SqlHelper.ExecuteReader(sql, paraUn);
            if (sdr.Read())
            {
                op = new Operator();
                op.Id = (Guid)sdr["Id"];
                op.IsAdmin = (bool)sdr["IsAdmin"];
                op.IsDeleted = (bool)sdr["IsDeleted"];
                op.IsLocked = (bool)sdr["IsDeleted"];
                op.Password = sdr["Password"].ToString();
                op.RealName = sdr["RealName"].ToString();
                op.UserName = sdr["UserName"].ToString();
                sdr.Close();
            }

            return op;
        }

        public string AddOperator(Operator op, string Okpwd) //传入用户来添加用户
        {
            if (op.UserName == "") return "unempty";
            else if (op.RealName == "") return "rnempty";
            else if (op.Password == "") return "pwdempty";
            else if (op.Password != Okpwd) return "pwddiff";
            else
            {
                string sqlJudge = "SELECT COUNT(*) FROM Operator WHERE UserName = @UserName";
                SqlParameter parau = new SqlParameter("@UserName", op.UserName);
                int usernumber = (int)SqlHelper.ExecuteScalar(sqlJudge, parau);
                if(usernumber != 0)//已经存在此用户
                {
                    return "userexist";
                }
                string sqlAdd = "INSERT INTO Operator(Id, UserName, Password, IsDeleted, RealName, IsLocked, IsAdmin) VALUES(NEWID(), @UserName,  @Password,@IsDeleted, @RealName, @IsLocked , @IsAdmin);";
                SqlParameter paraUn = new SqlParameter("@UserName", op.UserName);
                SqlParameter paraPwd = new SqlParameter("@Password", op.Password);
                SqlParameter paraDel = new SqlParameter("@IsDeleted", op.IsDeleted);
                SqlParameter paraLock = new SqlParameter("@IsLocked", op.IsLocked);
                SqlParameter paraRn = new SqlParameter("@RealName", op.RealName);
                SqlParameter paraAdmin = new SqlParameter("@IsAdmin", op.IsAdmin);
                SqlParameter[] parameters = { paraUn, paraPwd, paraDel, paraLock, paraRn , paraAdmin};
                int adduser = SqlHelper.ExecuteNonQuery(sqlAdd, parameters);
                if (adduser > 0) return "successAddUser";
                else return "errorAddUser";
            }
            

        }

        public Operator InquireOp(string un) //查询
        {
            Operator op = GetOperator(un);
            return op;
        }

        public int LockOp(string un) //锁定
        {
            string sqlLock = "UPDATE  Operator SET IsLocked = 'True' WHERE UserName = @UserName;";
            SqlParameter paraUn = new SqlParameter("@UserName", un);
            return SqlHelper.ExecuteNonQuery(sqlLock, paraUn);

            
        }

        public int DelOprator(string un)
        {
            string sqlDel = "UPDATE  Operator SET IsDeleted = 'True' WHERE UserName = @UserName;";
            SqlParameter paraUn = new SqlParameter("@UserName", un);
            return SqlHelper.ExecuteNonQuery(sqlDel, paraUn);
        }

        public string PwdChange(string un, string pwd, string Okpwd) //修改密码
        {
            if (pwd != Okpwd) return "diff";//密码不一样
            string sqlChangepwd = "UPDATE Operator SET Password = @Password WHERE UserName = @UserName";
            SqlParameter paraUn = new SqlParameter("@UserName", un);
            SqlParameter paraPwd = new SqlParameter("@Password", pwd);
            return SqlHelper.ExecuteNonQuery(sqlChangepwd, paraUn, paraPwd).ToString();

        }
    }
}
