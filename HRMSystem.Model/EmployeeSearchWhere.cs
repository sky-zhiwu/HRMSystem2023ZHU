using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class EmployeeSearchWhere
    {
        public string Name { get; set; }
        public bool ExistDate { get; set; }
        public DateTime InDateFrom { get; set; }
        public DateTime InDateTo { get; set; }
        public Guid DeptId { get; set; }

    }
}
