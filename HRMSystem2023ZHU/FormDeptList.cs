using HRMSystem.DAL;
using HRMSystem.Model;
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
    public partial class FormDeptList : Form
    {
        public FormDeptList()
        {
            InitializeComponent();
        }
        private DepartmentService dServ = new DepartmentService();
        //private Department dept = null;
        private void FormDeptList_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = dServ.GetDeptList("");
            dgvList.AllowUserToAddRows = false;
            dgvList.ReadOnly = true;
        }
        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text.Trim();
            if (name == "")
            {
                CommonHelper.WarnMessageBox("请输入至少一个关键字进行查询！");
                dgvList.DataSource = dServ.GetDeptList("");
                return;
            }
            dgvList.DataSource = dServ.GetDeptList(name);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Department d = null;
            if (textBoxName.Text.Trim() == "")
            {
                CommonHelper.WarnMessageBox("请输入至少一个字进行添加！");
                return;
            }
            d = new Department
            {
                Name = textBoxName.Text,
                Id = Guid.NewGuid(),
                IsDeleted = false
             };
            if (dServ.AddDept(d))
            {
                CommonHelper.SuccessMessageBox("添加成功！");
                textBoxName.Text = "";
            }
            else
            {
                CommonHelper.ErrorMessageBox("添加失败！");
            }
            dgvList.DataSource = dServ.GetDeptList("");
        }

        private void buttonRevise_Click(object sender, EventArgs e)
        {
            if(dgvList.SelectedRows.Count == 0)
            {
                CommonHelper.WarnMessageBox("请至少选中一行数据进行修改！");
                return;
            }
            string newName = textBoxReviseName.Text.Trim();
            if(newName == "")
            {
                CommonHelper.WarnMessageBox("请输入修改后的数据！");
                return;
            }
            Department d = dServ.GetDepartment(dgvList.SelectedRows[0].Cells[0].Value.ToString());
            if (dServ.UpdateDept(d, newName))
            {
                CommonHelper.SuccessMessageBox("修改成功！");
            }
            else
            {
                CommonHelper.ErrorMessageBox("修改失败！");
            }
            dgvList.DataSource = dServ.GetDeptList("");
            textBoxReviseName.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                Department d = dServ.GetDepartment(dgvList.SelectedRows[0].Cells[0].Value.ToString());
                if (CommonHelper.YesOrNoMessageBox("你确定要删除这个部门吗？") == DialogResult.Yes)
                {
                    if (dServ.DeleteDept(d))
                    {
                        CommonHelper.SuccessMessageBox("删除部门成功！");
                        dgvList.DataSource = dServ.GetDeptList("");
                    }
                    else
                    {
                        CommonHelper.ErrorMessageBox("删除失败！");
                    }
                }

            }
            else
            {
                CommonHelper.ErrorMessageBox("请通过选中一行数据来选择需要删除的部门！");
            }
        }
    }
}
