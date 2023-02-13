using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Employee:BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? FaxNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int LocationId { get; set; }
        public virtual Location? Location { get; set; }
        public virtual ICollection<Transaction>? PayRolls { get; set; }
    }

}
