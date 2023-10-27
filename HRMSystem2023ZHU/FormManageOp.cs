using HRMSystem.BLL;
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
using static HRMSystem.BLL.SystemGuard;

namespace HRMSystem2023ZHU
{
    public partial class FormManageOp : Form
    {
        public FormManageOp()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e) //添加
        {

            {
                SystemGuard sg = new SystemGuard();
                Operator op = new Operator();
                string Okpwd = CommonHelper.GetMD5(textBoxOkpwd.Text.Trim());
                op.UserName = textBoxUn.Text.Trim();
                op.RealName = textBoxRn.Text.Trim();
                op.Password = CommonHelper.GetMD5(textBoxDespwd.Text.Trim());
                op.IsDeleted = checkBoxDel.Checked ? true : false;
                op.IsLocked = checkBoxLock.Checked ? true : false;
                op.IsAdmin = checkBoxManage.Checked ? true : false;
                AddType at = sg.AddCheck(op, Okpwd);
                if (at == AddType.NoEnterUser)
                {
                    CommonHelper.WarnMessageBox("请输入用户名！");
                }
                else if (at == AddType.NoEnterReName)
                {
                    CommonHelper.WarnMessageBox("请输入真实姓名！");
                }
                else if (at == AddType.NoEnterPwd)
                {
                    CommonHelper.WarnMessageBox("请设置密码！");
                }
                else if (at == AddType.PwdDifferent)
                {
                    CommonHelper.WarnMessageBox("两次密码不一致，请重新输入！");
                    textBoxDespwd.Text = textBoxOkpwd.Text = "";
                }
                else if (at == AddType.ExistUser) //已经存在此用户
                {
                    CommonHelper.WarnMessageBox("此用户名已存在！");
                }
                else
                {
                    CommonHelper.SuccessMessageBox("添加成功！");
                }
                buttonEmpty_Click(sender, e);




            }
        }

        private void buttonInquire_Click(object sender, EventArgs e)//查询
        {
            
            string un = textBoxUn.Text.Trim();
            if (un == "")
            {
                CommonHelper.WarnMessageBox("请输入用户名！");
                buttonEmpty_Click(sender, e);

            }
            else
            {
                SystemGuard sg = new SystemGuard();
                Operator op = sg.InqCheck(un);
                if (op != null)
                {
                    textBoxRn.Text = op.RealName;
                    textBoxDespwd.Text = textBoxOkpwd.Text = "";//密码无法解密
                    checkBoxDel.Checked = op.IsDeleted ? true : false;
                    checkBoxLock.Checked = op.IsLocked ? true : false;
                    checkBoxManage.Checked = op.IsAdmin ? true : false;

                }// 查询成功
                else
                {
                    CommonHelper.WarnMessageBox("未查询到此用户信息，请重新输入！");
                    buttonEmpty_Click(sender, e);
                } //未查询到

            }

        }

        private void buttonLock_Click(object sender, EventArgs e)//锁定
        {
            string un = textBoxUn.Text.Trim();
            if (un == "")
            {
                CommonHelper.WarnMessageBox("请输入用户名！");
                buttonEmpty_Click(sender, e);
            }
            else
            {
                SystemGuard sg = new SystemGuard();
                LoDeType lt = sg.LockCheck(un);
                if (lt == LoDeType.SuccessLoDe)
                {
                    CommonHelper.SuccessMessageBox("该用户成功被锁定！");
                    checkBoxLock.Checked = true;
                }
                else
                {
                    CommonHelper.ErrorMessageBox("用户不存在或已被锁定！");
                }


            }
        }

        private void buttonDel_Click(object sender, EventArgs e)//删除
        {
            string un = textBoxUn.Text.Trim();
            if (un == "")
            {
                CommonHelper.WarnMessageBox("请输入用户名！");
                buttonEmpty_Click(sender, e);
            }
            else
            {
                SystemGuard sg = new SystemGuard();
                LoDeType dt = sg.DelCheck(un);
                if (dt == LoDeType.SuccessLoDe)
                {
                    CommonHelper.SuccessMessageBox("该用户成功被删除！");
                    checkBoxLock.Checked = true;
                }
                else
                {
                    CommonHelper.ErrorMessageBox("用户不存在或已被删除！");
                }


            }
        }

        private void buttonEmpty_Click(object sender, EventArgs e)//清空
        {
            textBoxRn.Text = textBoxUn.Text = textBoxOkpwd.Text = textBoxDespwd.Text = "";
            checkBoxDel.Checked = checkBoxLock.Checked = checkBoxManage.Checked = false;
        }

        private void textBoxUn_KeyPress(object sender, KeyPressEventArgs e)//回车输入真实姓名
        {
            if (e.KeyChar == 13) textBoxRn.Focus();
        }

        private void textBoxRn_KeyPress(object sender, KeyPressEventArgs e)//回车输入密码
        {
            if (e.KeyChar == 13) textBoxDespwd.Focus();
        }

        private void textBoxDespwd_KeyPress(object sender, KeyPressEventArgs e)//回车确认密码
        {
            if (e.KeyChar == 13) textBoxOkpwd.Focus();
        }
    }
}
