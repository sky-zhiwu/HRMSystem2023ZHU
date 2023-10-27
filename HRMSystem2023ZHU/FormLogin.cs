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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {

            string un = textBoxUsername.Text.Trim();
            string pwd = textBoxPassword.Text.Trim();
            SystemGuard sg = new SystemGuard();
            UserType ut = sg.Check(un, CommonHelper.GetMD5(pwd));
            if (un == "")
            {
                CommonHelper.WarnMessageBox("请输入用户名！");
            }
            else if (pwd == "")
            {
                CommonHelper.WarnMessageBox("请输入密码！");
            }
            else
            {
                
                if (ut == UserType.NoUser)
                {
                    CommonHelper.ErrorMessageBox("不存在此用户！");
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (ut == UserType.PasswordError)
                {
                    this.DialogResult = DialogResult.Cancel;
                    CommonHelper.ErrorMessageBox("密码错误！");
                }
                else
                {
                    if (ut == UserType.LoDeUser ) CommonHelper.WarnMessageBox("登录成功 被锁定且删除！");
                    else if(ut == UserType.LockUser ) CommonHelper.WarnMessageBox("登录成功 被锁定！");
                    else if(ut == UserType.DelUser ) CommonHelper.WarnMessageBox("登录成功 被删除！");
                    else CommonHelper.SuccessMessageBox("登录成功!欢迎使用本系统！");
                    this.DialogResult = DialogResult.OK;
                }

            }
            
            
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)//回车输入密码
        {
            if (e.KeyChar == 13)
            {
                textBoxPassword.Focus();
            }
           
        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)//回车代替点击确定
        {
            if (e.KeyChar == 13)
            {
                buttonOK.Focus();
                buttonOK_Click(sender, e);
            }
        }


    }
}
