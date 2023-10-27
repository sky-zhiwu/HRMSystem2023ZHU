using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class SalarySheetGuard
    {
        private SalarySheetSevice ssServ = new SalarySheetSevice();
        private SalarySheetItemService ssiServ = new SalarySheetItemService();
        private EmployeeService empServ = new EmployeeService();
        private SalarySheet ss = new SalarySheet();
        public enum SalarySheetType//无员工， 无工资单，有工资单, 用原来的明细， 新建明细
        {
            NoEmployee, NoSheet, HaveSheet
        }
        public SalarySheetType CheckSalarySheet(int year, int month, Guid deptid)
        {
            if (empServ.GetEmployeeCount(deptid) == 0)
            {
                return SalarySheetType.NoEmployee; //无员工 
            }
            ss.Year = year;
            ss.Month = month;
            ss.DepartmentId = deptid;
            ss.Id = ssServ.GetSalarySheetId(year, month, deptid);
            if (ss.Id == Guid.Empty)//无此工资单
            {
                ss.Id = Guid.NewGuid();//生成新工资单
                ssServ.BuildNewSalarySheet(ss);
                ssiServ.BuildSalarySheetItems(ss.Id, ss.DepartmentId);
                //dgvSalarySheetItems.DataSource = ssiServ.GetSalarySheetItems(ss.Id);
                SalarySheetItemData ssidata = SalarySheetItemData.GetInstance();
                ssidata.InitMember(ssiServ.GetSalarySheetItems(ss.Id));
                return SalarySheetType.NoSheet;
            }
            else//存在工资单
            {
                return SalarySheetType.HaveSheet;
            }
        }
        public void ChooseSheetItem(bool flag)
        {
            if (flag == true)//使用原来的明细
            {
                SalarySheetItemData ssidata = SalarySheetItemData.GetInstance();
                ssidata.InitMember(ssiServ.GetSalarySheetItems(ss.Id));
                //  dgvSalarySheetItems.DataSource = ssiServ.GetSalarySheetItems(ss.Id);
            }
            else//重新生成salarysheetitem
            {
                ssiServ.DeleteSalarySheetItems(ss.Id);
                ssiServ.BuildSalarySheetItems(ss.Id, ss.DepartmentId);
                SalarySheetItemData ssidata = SalarySheetItemData.GetInstance();
                ssidata.InitMember(ssiServ.GetSalarySheetItems(ss.Id));
               // dgvSalarySheetItems.DataSource = ssiServ.GetSalarySheetItems(ss.Id);
            }
        }
    }
}
