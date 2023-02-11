using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class PayRoll : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Description { get; set; } 
        public string? Type { get; set; } 
        public string? TypeCode { get; set; } 
        public decimal? TransferAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? SalaryMonth { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
