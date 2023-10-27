using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2023ZHU
{
    public partial class FormLogQuery : Form
    {
        private const int NUM_PER_PAGE = 10;
        private int totalPages = 0;
        private int currentPage = 1;//当前页
        private LogSearchWhere lsw = null;
        private OperationLogService logServ = new OperationLogService();

        public FormLogQuery()
        {
            InitializeComponent();
        }
        private void displayOnePage()
        {
            labelPositionPage.Text = string.Format("第{0}页", currentPage);
            dgvLog.DataSource = logServ.GetLogList(currentPage, NUM_PER_PAGE, lsw);
        }
        
        private void FormLogQuery_Load(object sender, EventArgs e)
        {
            int n = logServ.GetLogCount(lsw);
            dgvLog.AllowUserToAddRows = false;
            dgvLog.ReadOnly = true;
            dgvLog.Height = NUM_PER_PAGE * dgvLog.RowTemplate.Height + dgvLog.ColumnHeadersHeight;
            totalPages = n % NUM_PER_PAGE == 0 ? n / NUM_PER_PAGE : n / NUM_PER_PAGE + 1;
            labelPages.Text = string.Format("共{0}页 ", totalPages);
            dgvLog.DataSource = logServ.GetLogList(currentPage, NUM_PER_PAGE, lsw);
            displayOnePage();

            //日志查询绑定数据
            comboBoxDescription.Items.Add("合法用户，登录成功！");
            comboBoxDescription.Items.Add("非法登录，密码不正确！");
            comboBoxDescription.Items.Add("非法登录，无此用户！");
            comboBoxDescription.SelectedIndex = -1;

            comboBoxName.DataSource = logServ.SearchName();
            comboBoxName.SelectedIndex = -1;

        }
        private void labelBegin_Click(object sender, EventArgs e)//首页
        {
            currentPage = 1;
            displayOnePage();
        }

        private void labelEndPage_Click(object sender, EventArgs e)//末页
        {
           // dgvLog.DataSource = logServ.GetLogList(totalPages * NUM_PER_PAGE + 1, logServ.GetLogCount());
            currentPage = totalPages;
            displayOnePage();
        }
         private void labelBefore_Click(object sender, EventArgs e)
        {
            currentPage = Math.Max(currentPage - 1, 1);
            displayOnePage();
        }
        private void labelNextPage_Click(object sender, EventArgs e)
        {
            currentPage = Math.Min(currentPage + 1, totalPages);
            displayOnePage();
        }


        private void buttonTranOk_Click(object sender, EventArgs e)
        {
            if(CommonHelper.YesOrNoMessageBox("你确定要进行日志迁移吗？") == DialogResult.Yes)
            {
                if (logServ.TransactionLog(dtpTranslation.Value.Date))
                {
                    CommonHelper.SuccessMessageBox("日志迁移成功！");
                }
                else
                {
                    CommonHelper.ErrorMessageBox("迁移失败！" + dtpTranslation.Value);
                }
                displayOnePage();
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(checkBoxBeginDate.Checked || checkBoxEndDate.Checked || checkBoxName.Checked || checkBoxDescription.Checked)
            {
                lsw = new LogSearchWhere();
                lsw.ExistBeginDate = lsw.ExistEndDate = false;
                if (checkBoxBeginDate.Checked)
                {
                    lsw.ExistBeginDate = true;
                    lsw.InDateFrom = dtpBeginDate.Value;
                }
                if (checkBoxEndDate.Checked)
                {
                    lsw.ExistEndDate = true;
                    lsw.InDateTo = dtpEndDate.Value;
                }
                if (checkBoxName.Checked)
                {
                    if (comboBoxName.SelectedIndex == -1)
                    {
                        CommonHelper.WarnMessageBox("请选择姓名！");
                        return;
                    }
                    lsw.Name = comboBoxName.Text.Trim();
                }
                if (checkBoxDescription.Checked)
                {
                    if (comboBoxDescription.SelectedIndex == -1)
                    {
                        CommonHelper.WarnMessageBox("请选择操作描述！");
                        return;
                    }
                    lsw.OperationKey = comboBoxDescription.Text.Trim();
                }
            }
            else
            {
                lsw = null;
            }
            int n = logServ.GetLogCount(lsw);
            totalPages = n % NUM_PER_PAGE == 0 ? n / NUM_PER_PAGE : n / NUM_PER_PAGE + 1;
            labelPages.Text = string.Format("共{0}页 ", totalPages);
           // dgvLog.DataSource = logServ.GetLogList(currentPage, NUM_PER_PAGE, lsw);
            displayOnePage();

        }
    }
}
