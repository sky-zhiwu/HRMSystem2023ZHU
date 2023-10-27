using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class LogSearchWhere
    {
        public string Name { get; set; }
        public bool ExistBeginDate { get; set; }
        public bool ExistEndDate { get; set; }
        public DateTime InDateFrom { get; set; }
        public DateTime InDateTo { get; set; }
        public string OperationKey { get; set; }

    }
}
