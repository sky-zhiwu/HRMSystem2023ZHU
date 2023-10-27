using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class SalarySheet
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public Guid DepartmentId { get; set; }

    }
}
