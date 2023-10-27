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
    public class SalarySheetItemService
    {
        //根据工资单号和部门创建工资明细
        public void BuildSalarySheetItems(Guid sheetId, Guid deptId)
        {
            EmployeeService eServ = new EmployeeService();
            EmployeeSearchWhere esw = new EmployeeSearchWhere();
            esw.DeptId = deptId;
            DataTable dt = eServ.GetEmployeeList(esw);
            Guid empId;
            string sql;
            foreach(DataRow row in dt.Rows)
            {
                empId = (Guid)row["编号"];
                sql = "insert into salarysheetitem values(@Id, @SheetId, @EmployeeId, 0, 0, 0, 0)";
                SqlParameter[] paras = 
                    { 
                    new SqlParameter("@Id", Guid.NewGuid()),
                    new SqlParameter("@SheetId", sheetId),
                    new SqlParameter("@EmployeeId", empId)
                };
                SqlHelper.ExecuteNonQuery(sql, paras);
            }
        }

        //根据工资单号获得工资明细
 	    public DataTable GetSalarySheetItems(Guid sheetId)
        {
            string sql =
                "select s.id '编号', e.name '姓名', s.basesalary '基本工资', s.bonus '奖金', s.fine '应扣', s.other '其他' " +
                "from salarysheetitem s, employee e " +
                " where s.sheetid = @sheetId and s.employeeid = e.id and (e.IsDeleted is null or e.IsDeleted = 0)";
            SqlParameter paraSheetid = new SqlParameter("@sheetId", sheetId);
            return SqlHelper.GetDataTable(sql, paraSheetid);
        }

        //删除指定工资单的工资明细
   	    public void DeleteSalarySheetItems(Guid sheetId)
        {
            string sql = "delete from salarysheetitem where sheetId = @sheetId";
            SqlParameter parasheetId = new SqlParameter("@sheetId", sheetId);
            SqlHelper.ExecuteNonQuery(sql, parasheetId);
        }
        
        //更新工资明细
        public bool UpdateSalarySheetItems(SalarySheetItem item)
        {
            string sql = 
                "update salarysheetitem set basesalary = @basesalary, bonus = @bonus, fine = @fine, other = @other " + 
                "where id = @id";
            SqlParameter[] paras =
            {
                new SqlParameter("@id", item.Id),
                new SqlParameter("@basesalary", item.BaseSalary),
                new SqlParameter("@bonus", item.Bonus),
                new SqlParameter("@fine", item.Fine),
                new SqlParameter("@other", item.Other)
            };
            return SqlHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        //得到报表
        public DataTable GetReportSheet(Guid sheetid)
        {
            string sql = "select ss.year as year, ss.month as month, d.name as dept, ssi.id, e.name as name, ssi.basesalary as baseSalary, ssi.bonus as bonus, ssi.fine as fine, ssi.other as other from Employee e, salarysheetitem ssi, salarysheet ss, department d where ssi.sheetid = @id and e.id = ssi.employeeid and ssi.sheetid = ss.id and ss.departmentid = d.id";
            SqlParameter paraId = new SqlParameter("@Id", sheetid);
            return SqlHelper.GetDataTable(sql, paraId);
        }
    }
}
