using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
    public class DepartmentService
    {
        public List<Department> GetDepartments() //得到所有部门信息
        {
            List<Department> departments = new List<Department>();
            string sql = "select * from Department where isdeleted = 0 or IsDeleted is null";
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                Department de = null;
                while (reader.Read())
                {
                    de = new Department();
                    de.Id = (Guid)reader["Id"];
                    de.Name = reader["Name"].ToString();
                    departments.Add(de);
                }
            }
            return departments;
        }
        public Department GetDepartment(string name) //通过部门名称得到部门
        {
            string sql = "select * from department where name = @Name and (IsDeleted is null or IsDeleted = 0)";
            SqlParameter paraName = new SqlParameter("@Name", name);
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, paraName))
            {
                Department d = null;
                if (reader.Read())
                {
                    d = new Department();
                    d.Name = reader["Name"].ToString();
                    d.Id = (Guid)reader["Id"];
                }

                return d;
            }
        }
        public DataTable GetDeptList(string dname)  //通过部门名称关键字查找部门列表
        {
            string sql = "select name 部门 from department where Name like N'%' + @Name + '%' and (IsDeleted is null or IsDeleted = 0)";
            SqlParameter paraName = new SqlParameter("@Name",dname);

            return SqlHelper.GetDataTable(sql, paraName);

        }
       // public bool HaveEmployees(Guid deptid) //查找该部门是否存在员工
        
        public bool AddDept(Department d)//添加部门
        {
            string sqljudge = string.Format("select count(*) from department where name = N'{0}'", d.Name);
            if((int)SqlHelper.ExecuteScalar(sqljudge) != 0)  //已经存在，不能重复添加
            {
                return false;
            }
            string sql = "insert into department values (@Id, @Name, @Isdeleted);";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", d.Id),
                new SqlParameter("@Name",d.Name),
                new SqlParameter("@IsDeleted", d.IsDeleted)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters) > 0;

        }
        public bool UpdateDept(Department d, string name)//更新部门
        {
            string sql = "update department set name = @Name where id = @Id";
            SqlParameter[] paras =
                {
                    new SqlParameter("@Id", d.Id),
                    new SqlParameter("@Name", name)
                };
            return SqlHelper.ExecuteNonQuery(sql, paras)>0;
        }
        public bool DeleteDept(Department d)//删除部门
        {
            string sql = "UPDATE  department SET IsDeleted = 1 WHERE id = @Id";
            SqlParameter paraId = new SqlParameter("@Id", d.Id);
            return SqlHelper.ExecuteNonQuery(sql, paraId) > 0;
        }
    }
}
