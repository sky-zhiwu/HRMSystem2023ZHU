using HRMSystem.BLL;
using HRMSystem.DAL;
using HRMSystem.Model;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMSystem.BLL.SalarySheetGuard;

namespace HRMSystem2023ZHU
{
    public partial class FormSalaryList : Form
    {
        public FormSalaryList()
        {
            InitializeComponent();
        }
        private DepartmentService dServ = new DepartmentService();
        private EmployeeService eServ = new EmployeeService();
        private SalarySheetSevice ssServ = new SalarySheetSevice();
        private SalarySheetItemService ssiServ = new SalarySheetItemService();

        private void FormSalaryList_Load(object sender, EventArgs e)
        {
            comboBoxDept.DataSource = dServ.GetDepartments();
            comboBoxDept.DisplayMember = "Name";
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.SelectedIndex = -1;

            comboBoxYear.DataSource = ssServ.GetSalarySheetYear();
            comboBoxYear.SelectedIndex = 0;

            comboBoxMonth.DataSource = ssServ.GetSalarySheetMonth();
            comboBoxMonth.SelectedIndex = 0;
        }

        private void buttonSal_Click(object sender, EventArgs e)
        {
            //年月部门选择错误
            if(string.IsNullOrEmpty(comboBoxYear.Text) || string.IsNullOrEmpty(comboBoxMonth.Text) || string.IsNullOrEmpty(comboBoxDept.Text))
            {
                CommonHelper.ErrorMessageBox("请选择正确的年，月和部门！");
                return;
            }
            SalarySheetGuard ssg = new SalarySheetGuard();
            Guid deptid = (Guid)comboBoxDept.SelectedValue;
            int year = Convert.ToInt32(comboBoxYear.Text);
            int month = Convert.ToInt32(comboBoxMonth.Text);
            SalarySheetType sst = ssg.CheckSalarySheet(year, month, deptid);
            //如果部门不存在员工
            if (sst == SalarySheetType.NoEmployee)
            {
                CommonHelper.ErrorMessageBox("该部门不存在员工！");
                return;
            }
            
            if(sst == SalarySheetType.NoSheet)//无此工资单
            {
                SalarySheetItemData ssiData = SalarySheetItemData.GetInstance();
                dgvSalarySheetItems.DataSource = ssiData.Salarysheetitems;
            }
            else//存在工资单
            {
                if(CommonHelper.YesOrNoMessageBox("工资单已存在，是否提取原工资单？[是]提取原工资单；[否]将新建工资单") == DialogResult.Yes)
                {
                    ssg.ChooseSheetItem(true);
                    SalarySheetItemData ssiData = SalarySheetItemData.GetInstance();
                    dgvSalarySheetItems.DataSource = ssiData.Salarysheetitems;
                }
                else//重新生成salarysheetitem
                {
                    ssg.ChooseSheetItem(false);
                    SalarySheetItemData ssiData = SalarySheetItemData.GetInstance();
                    dgvSalarySheetItems.DataSource = ssiData.Salarysheetitems;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SalarySheetItem item = null;
            //int count = dgvSalarySheetItems.Rows.Count; //多了一行，设置属性用户不可添加
            foreach (DataGridViewRow row in dgvSalarySheetItems.Rows)
            {
                item = new SalarySheetItem();
                
              //  string str = row.Cells[0].Value.ToString();
                item.Id = (Guid)row.Cells[0].Value;
                item.BaseSalary = (decimal)row.Cells[2].Value;
                item.Bonus = (decimal)row.Cells[3].Value;
                item.Fine = (decimal)row.Cells[4].Value;
                item.Other = (decimal)row.Cells[5].Value;
                ssiServ.UpdateSalarySheetItems(item);
            }
            CommonHelper.SuccessMessageBox("工资单保存成功！");
        }
    }
}
