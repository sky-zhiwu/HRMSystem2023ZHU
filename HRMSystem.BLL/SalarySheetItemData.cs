using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class SalarySheetItemData //传递实例
    {
        public DataTable Salarysheetitems { get; set; }
        private static SalarySheetItemData ssidata = null;//初始化
        private SalarySheetItemData() { }
        public static SalarySheetItemData GetInstance()
        {
            if (ssidata == null)
            {
                ssidata = new SalarySheetItemData();
            }
            return ssidata;//返回实例对象
        }
        public void InitMember(DataTable dt)
        {
            Salarysheetitems = dt;
        }
    }
}
