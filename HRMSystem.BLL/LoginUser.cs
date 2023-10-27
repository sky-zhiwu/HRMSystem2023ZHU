using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.BLL
{
    public class LoginUser
    {
        public Guid Id { get; set; }
        public string RealName { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }

        private static LoginUser lu = null;//初始化
        private LoginUser() { }

        public static LoginUser GetInstance()
        {
            if (lu == null)
            {
                lu = new LoginUser();
            }
            return lu;//返回实例对象
        }
        public void InitMember(Operator op)
        {
            Id = op.Id;
            RealName = op.RealName;
            IsAdmin = op.IsAdmin;
            UserName = op.UserName;
        }
    }
}
