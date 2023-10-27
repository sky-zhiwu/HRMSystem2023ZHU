using HRMSystem.Model;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class SalarySheetSevice
    {
        //根据年、月和部门Id获得工资单号，空表示无此工资单
        public Guid GetSalarySheetId(int year, int month, Guid deptId)
        {
            string sql = "select id from salarysheet where year = @year and month = @month and departmentid = @deptId";
            SqlParameter[] paras =
            {
                new SqlParameter("@year", year),
                new SqlParameter("@month", month),
                new SqlParameter("@deptId", deptId)
            };
            using(SqlDataReader read = SqlHelper.ExecuteReader(sql, paras))
            {
                if (read.Read())
                {
                    return (Guid)read[0];
                }
                else
                {
                    return Guid.Empty;
                }
            }
        }

        //创建新的工资单，返回值为创建的工资单号
        public Guid BuildNewSalarySheet(SalarySheet sheet)
        {
            string sql = "insert into salarysheet values(@id, @year, @month, @deptid);";
            SqlParameter[] paras =
            {
                new SqlParameter("@id", sheet.Id),
                new SqlParameter("@year", sheet.Year),
                new SqlParameter("@month",sheet.Month),
                new SqlParameter("@deptid",sheet.DepartmentId)
            };
            SqlHelper.ExecuteNonQuery(sql, paras);
            return sheet.Id;
        }

        public List<int> GetSalarySheetYear()  //复选框得到工资单的年份
        {
            List<int> ssy = new List<int>();
            int nowYear = DateTime.Now.Year;
            for(int i=0; i<30; i++)
            {
                ssy.Add(nowYear-i);
            }
            return ssy;
        }
        public List<int> GetSalarySheetMonth() //复选框得到工资单的月份
        {
            List<int> ssm = new List<int>();
            int nowMonth = DateTime.Now.Month;
            for(int i=0; i<12; i++)
            {
                if ((nowMonth + i) % 12 == 0) ssm.Add(12);
                else ssm.Add((nowMonth+i)%12);
            }
            return ssm;
        }
        
    }
}
