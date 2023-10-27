using HRMSystem.DAL;
using HRMSystem.Model;
using Microsoft.Reporting.WinForms;
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

namespace HRMSystem2023ZHU
{
    public partial class FormPrintSalarySheet : Form
    {
        public FormPrintSalarySheet()
        {
            InitializeComponent();
        }
        private DepartmentService dServ = new DepartmentService();
       // private EmployeeService eServ = new EmployeeService();
        private SalarySheetSevice ssServ = new SalarySheetSevice();
        private SalarySheetItemService ssiServ = new SalarySheetItemService();

        private void FormPrintSalarySheet_Load(object sender, EventArgs e)
        {
            this.rvPrintSalary.RefreshReport();

            comboBoxDept.DataSource = dServ.GetDepartments();
            comboBoxDept.DisplayMember = "Name";
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.SelectedIndex = -1;

            comboBoxYear.DataSource = ssServ.GetSalarySheetYear();
            comboBoxYear.SelectedIndex = 0;

            comboBoxMonth.DataSource = ssServ.GetSalarySheetMonth();
            comboBoxMonth.SelectedIndex = 0;
            this.rvPrintSalary.RefreshReport();
            this.rvPrintSalary.RefreshReport();
        }

        private void buttonSearchSalarySheet_Click(object sender, EventArgs e)
        {
            if(comboBoxDept.SelectedIndex == -1)
            {
                CommonHelper.ErrorMessageBox("请选择正确的部门！");
                return;
            }

            SalarySheet salarySheet = new SalarySheet();
            salarySheet.Year = int.Parse(comboBoxYear.Text);
            salarySheet.Month = int.Parse(comboBoxMonth.Text);
            salarySheet.DepartmentId = (Guid)comboBoxDept.SelectedValue;
            salarySheet.Id = ssServ.GetSalarySheetId(salarySheet.Year, salarySheet.Month, salarySheet.DepartmentId);
            if (salarySheet.Id == Guid.Empty)
            {
                CommonHelper.ErrorMessageBox("该工资单尚未生成！");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = ssiServ.GetReportSheet(salarySheet.Id);
                rvPrintSalary.LocalReport.DataSources.Clear();
                rvPrintSalary.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                rvPrintSalary.RefreshReport();

            }
        }
    }
}
