using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime InDay { get; set; }
        public Guid MarriageId { get; set; }
        public Guid PartyId { get; set; }
        public Guid EducationId { get; set; }
        public Guid GenderId { get; set; }
        public Guid DepartmentId { get; set; }
        public string TelePhone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public string Resume { get; set; }
        public byte[] Photo { get; set; }
        public string Nation { get; set; }
        public string NativePlace { get; set; }
        public bool IsDeleted { get; set; }
    }
}
