using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class OperationLog
    {
        public Guid Id { get; set; }
        public Guid OperatorId { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionDesc { get; set; }
    }
}
