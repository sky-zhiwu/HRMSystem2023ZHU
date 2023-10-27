using HRMSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMSystem.BLL.SystemGuard;

namespace HRMSystem2023ZHU
{
    public partial class FormChangePwd : Form
    {
        public FormChangePwd()
        {
            InitializeComponent();
        }

        private void buttonChangepwd_Click(object sender, EventArgs e)
        {
            string pwd = textBoxChangepwd.Text.Trim();
            string Okpwd = textBoxYespwd.Text.Trim();
            if (pwd == "") CommonHelper.WarnMessageBox("请输入您要修改的密码");
            else
            {
                LoginUser lu = LoginUser.GetInstance();

                SystemGuard sg = new SystemGuard();
                ChangePwdType ct = sg.ChanPwdCheck(lu.UserName, CommonHelper.GetMD5(pwd), CommonHelper.GetMD5(Okpwd));
                if (ct == ChangePwdType.SucChange)
                {
                    CommonHelper.SuccessMessageBox("成功修改密码！");
                    textBoxChangepwd.Text = textBoxYespwd.Text = "";
                }
                else if (ct == ChangePwdType.FailChange)
                {
                    CommonHelper.ErrorMessageBox("修改失败！");
                }
                else
                {
                    CommonHelper.WarnMessageBox("两次密码输入不一致，请重新输入！");
                    textBoxYespwd.Text = textBoxChangepwd.Text = "";
                }
            }
            
        }


        private void textBoxChangepwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) textBoxYespwd.Focus();
        }

        private void FormChangePwd_Load(object sender, EventArgs e)
        {

           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
