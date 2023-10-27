using HRMSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class SystemGuard
    {
        public UserType Check(string un, string pwd)//登录类型
        {
            OpService OpServ = new OpService();
            Operator op = OpServ.GetOperator(un);
            OperationLogService LogServ = new OperationLogService();
            OperationLog log = new OperationLog();
            log.Id = Guid.NewGuid();
            log.ActionDate = DateTime.Now;
            UserType ut;
            if (op == null)
            {
                log.OperatorId = Guid.Empty;
                log.ActionDesc = "非法登录，无此用户！";
                ut = UserType.NoUser;
            }
            else if (op.Password != pwd)
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "非法登录，密码不正确！";
                ut = UserType.PasswordError;
            }
            else
            {
                log.OperatorId = op.Id;
                log.ActionDesc = "合法用户，登录成功！";
                LoginUser lu = LoginUser.GetInstance();
                lu.InitMember(op);
                if (op.IsLocked && op.IsDeleted) ut = UserType.LoDeUser;
                else if (op.IsLocked) ut = UserType.LockUser;
                else if (op.IsDeleted) ut = UserType.DelUser;
                else ut = UserType.ValidUser;
            }
            LogServ.Add(log);
            return ut;
        }
        public enum UserType 
        { 
            NoUser, PasswordError, ValidUser, LockUser, DelUser, LoDeUser
        };

        public AddType AddCheck(Operator op, string Okpwd)//添加类型
        {
            OpService OpServ = new OpService();
            string strAdd = OpServ.AddOperator(op, Okpwd);
            if (strAdd.Equals("unempty")) return AddType.NoEnterUser;
            else if (strAdd.Equals("rnempty")) return AddType.NoEnterReName;
            else if (strAdd.Equals("pwdempty")) return AddType.NoEnterPwd;
            else if (strAdd.Equals("pwddiff")) return AddType.PwdDifferent;
            else if (strAdd.Equals("userexist")) return AddType.ExistUser;
            else  return AddType.SucUser;
        }
        public enum AddType
        {
            NoEnterUser, NoEnterReName, NoEnterPwd, PwdDifferent, ExistUser, SucUser
        }

        public Operator InqCheck(string un)  //查询
        {
            OpService OpServ = new OpService();
            Operator op = OpServ.InquireOp(un);
            if (op == null) return null;
            else return op;
        }

        public LoDeType LockCheck(string un)//锁定
        {
            OpService opServ = new OpService();
            int n = opServ.LockOp(un);
            if (n == 1) return LoDeType.SuccessLoDe;
            else return LoDeType.UnsuccesssLoDe;

        }
        public LoDeType DelCheck(string un)//删除
        {
            OpService opServ = new OpService();
            int n = opServ.DelOprator(un);
            if (n == 1) return LoDeType.SuccessLoDe;
            else return LoDeType.UnsuccesssLoDe;

        }
        public enum LoDeType
        {
            SuccessLoDe, UnsuccesssLoDe
        }
        public ChangePwdType ChanPwdCheck(string un, string pwd, string Okpwd) //修改密码
        {
            OpService opserv = new OpService();
            string strpwd = opserv.PwdChange(un, pwd, Okpwd);
            if (strpwd.Equals("diff")) return ChangePwdType.PwdDiff;
            else if (strpwd.Equals("1")) return ChangePwdType.SucChange;
            else return ChangePwdType.FailChange;
        }
        public enum ChangePwdType
        {
            SucChange, FailChange, PwdDiff
        }
        

    }
}
