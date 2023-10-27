using HRMSystem.BLL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMSystem.BLL.SystemGuard;

namespace HRMSystem2023ZHU
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

    //    string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            if (fl.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }

            LoginUser lu = LoginUser.GetInstance();
            if (!lu.IsAdmin)
            {
                tsmiAdmin.Visible = false;
                tsmiOpManage.Visible = false;
                tsmiDeptManage.Visible = false;
                tsmiSalaryManage.Visible = false;
            }
            tsslInfo.Text = string.Format("欢迎{0}使用本系统，登录时间{1}", lu.RealName, DateTime.Now);



        }

        private void tsmiChangePwd_Click(object sender, EventArgs e)
        {
            FormChangePwd fcp = new FormChangePwd
            {
                MdiParent = this
            };
            fcp.Show();
        }

        private void tsmiLogQuery_Click(object sender, EventArgs e)
        {
            FormLogQuery flq = new FormLogQuery
            {
                MdiParent = this
            };
            flq.Show();
        }

        private void tsmOpManage_Click(object sender, EventArgs e)
        {
            FormManageOp fmo = new FormManageOp
            {
                MdiParent = this
            };
            fmo.Show();
        }

        private void tsmiOpList_Click(object sender, EventArgs e)
        {
            FormEmployeeList fol = new FormEmployeeList
            {
                MdiParent = this
            };
            fol.Show();
        }

        private void tsmiDeptList_Click(object sender, EventArgs e)
        {
            FormDeptList fdl = new FormDeptList
            {
                MdiParent = this
            };
            fdl.Show();
        }

        private void tsmiSalary_Click(object sender, EventArgs e)
        {
            FormSalaryList fsl = new FormSalaryList
            {
                MdiParent = this
            };
            fsl.Show();
        }

        private void tsmiPrintSalList_Click(object sender, EventArgs e)
        {
            FormPrintSalarySheet fpss = new FormPrintSalarySheet
            {
                MdiParent = this
            };
            fpss.Show();

        }
    }
}
