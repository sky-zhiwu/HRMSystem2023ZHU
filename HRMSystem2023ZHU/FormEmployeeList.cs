using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HRMSystem2023ZHU
{
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }
        private EmployeeService eServ = new EmployeeService();
        private DepartmentService dServ = new DepartmentService();
        private EmployeeSearchWhere esw = new EmployeeSearchWhere();

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            comboBoxDept.DataSource = dServ.GetDepartments();
            comboBoxDept.DisplayMember = "Name";
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.SelectedIndex = -1;
            
            dgvList.DataSource = eServ.GetEmployeeList(esw);
            dgvList.AllowUserToAddRows = false;
            dgvList.ReadOnly = true;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            EmployeeSearchWhere esw = new EmployeeSearchWhere();
            esw.ExistDate = false;
            if (checkBoxName.Checked)
            {
               esw.Name = textBoxName.Text.Trim();
                if (string.IsNullOrEmpty(esw.Name))
                {
                    CommonHelper.ErrorMessageBox("请输入一个员工姓名关键字！");
                    return;
                }
            }
            if (checkBoxTimeIn.Checked)
            {
                esw.ExistDate = true;
                esw.InDateFrom = dtpInDateFrom.Value;
                esw.InDateTo = dtpInDateTo.Value;
            }
            if (checkBoxDept.Checked)
            {
                if(comboBoxDept.SelectedIndex == -1)
                {
                    CommonHelper.ErrorMessageBox("请选择一个部门！");
                    return;
                }
                esw.DeptId = (Guid)comboBoxDept.SelectedValue;
            }
            dgvList.DataSource = eServ.GetEmployeeList(esw);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee fae = new FormAddEmployee();
            if(fae.ShowDialog() == DialogResult.OK)
            {
                dgvList.DataSource = eServ.GetEmployeeList(esw);
                fae.Close();
            }
            else
            {
                fae.Close();

            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if(dgvList.SelectedRows.Count > 0)
            {
                Guid id = (Guid)dgvList.SelectedRows[0].Cells[0].Value;
                if(id != Guid.Empty)
                {
                    FormEditEmployee fee = new FormEditEmployee(id);
                    if (fee.ShowDialog() == DialogResult.OK)
                    {
                        dgvList.DataSource = eServ.GetEmployeeList(esw);
                        fee.Close();
                    }
                    else
                    {
                        fee.Close();
                    }
                }
                else
                {
                    CommonHelper.ErrorMessageBox("无此用户！");
                }
                
                
            }
            else
            {
                CommonHelper.ErrorMessageBox("请通过选中一行数据来选择需要编辑的员工！");
            }
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if(dgvList.SelectedRows.Count > 0)
            {
                Guid id = (Guid)dgvList.SelectedRows[0].Cells[0].Value;
                if(CommonHelper.YesOrNoMessageBox("你确定要删除这个员工吗？") == DialogResult.Yes)
                {
                    if (eServ.DeleteEmployee(id))
                    {
                        CommonHelper.SuccessMessageBox("删除员工成功！");
                        dgvList.DataSource = eServ.GetEmployeeList(esw);
                    }
                    else
                    {
                        CommonHelper.ErrorMessageBox("删除失败！");
                    }
                }

            }
            else
            {
                CommonHelper.ErrorMessageBox("请通过选中一行数据来选择需要删除的员工！");
            }

        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            sfd.DefaultExt = "xlsx";
            sfd.FileName = "员工信息.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<ExportEmployees> ees = new List<ExportEmployees>();
                ExportEmployees ee = null;
                foreach(DataGridViewRow row in dgvList.Rows)
                {
                    ee = new ExportEmployees();
                    ee.No = row.Cells[1].Value.ToString();
                    ee.Name = row.Cells[2].Value.ToString();
                    ee.InDay = Convert.ToDateTime(row.Cells[3].Value);
                    ee.Nation = row.Cells[4].Value.ToString();
                    ee.NativePlace = row.Cells[5].Value.ToString();
                    ees.Add(ee);
                }
                if(eServ.ExportEmployees(ees, sfd.FileName))
                {
                    CommonHelper.SuccessMessageBox("导出成功！");
                }
                else
                {
                    CommonHelper.ErrorMessageBox("导出失败！");
                }
            }
            else
            {
                return;
            }
            
            
        }
    }
}
